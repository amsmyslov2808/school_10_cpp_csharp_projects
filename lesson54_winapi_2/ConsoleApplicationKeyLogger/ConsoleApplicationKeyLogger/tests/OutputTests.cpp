// Test synthetic events without capturing real keyboard input or changing focus.
#include <Windows.h>

HWND testWindow = nullptr;
BYTE testState[256]{};

HWND TestForegroundWindow() { return testWindow; }
BOOL TestGuiThreadInfo(DWORD, LPGUITHREADINFO) { return FALSE; }
BOOL TestKeyboardState(PBYTE state)
{
    CopyMemory(state, testState, sizeof(testState));
    return TRUE;
}
SHORT TestAsyncKeyState(int vk)
{
    return (testState[vk] & 0x80) ? static_cast<SHORT>(0x8000) : 0;
}

#define GetForegroundWindow TestForegroundWindow
#define GetGUIThreadInfo TestGuiThreadInfo
#define GetKeyboardState TestKeyboardState
#define GetAsyncKeyState TestAsyncKeyState
#define main KeyLoggerMain
#include "../ConsoleApplicationKeyLogger.cpp"
#undef main
#undef GetForegroundWindow
#undef GetGUIThreadInfo
#undef GetKeyboardState
#undef GetAsyncKeyState

#include <iterator>
#include <stdexcept>

void Require(bool condition, const char* message)
{
    if (!condition) {
        throw runtime_error(message);
    }
}

string Utf8(const wstring& text)
{
    int length = WideCharToMultiByte(CP_UTF8, 0, text.data(),
        static_cast<int>(text.size()), nullptr, 0, nullptr, nullptr);
    string result(length, '\0');
    WideCharToMultiByte(CP_UTF8, 0, text.data(), static_cast<int>(text.size()),
        result.data(), length, nullptr, nullptr);
    return result;
}

wstring allRecords;

wstring LogKey(UINT vk, HKL layout)
{
    ActivateKeyboardLayout(layout, 0);
    KBDLLHOOKSTRUCT key{};
    key.vkCode = vk;
    wostringstream console;
    auto previous = wcout.rdbuf(console.rdbuf());
    try {
        WriteKey(key);
    }
    catch (...) {
        wcout.rdbuf(previous);
        throw;
    }
    wcout.rdbuf(previous);
    allRecords += console.str();
    return console.str();
}

int main()
{
    _setmode(_fileno(stdout), _O_U16TEXT);
    _setmode(_fileno(stderr), _O_U16TEXT);

    HWND window = nullptr;
    HKL originalLayout = GetKeyboardLayout(0);
    try {
        // Unicode escapes keep this test independent of the source-file encoding.
        const wchar_t* title = L"Test window / \u0422\u0435\u0441\u0442";
        window = CreateWindowExW(0, L"STATIC", title, WS_POPUP,
            0, 0, 100, 100, nullptr, nullptr, GetModuleHandleW(nullptr), nullptr);
        Require(window != nullptr, "Unable to create the test window.");
        testWindow = window;

        // Seed the temporary log to verify that existing content is preserved.
        {
            ofstream file("keys.txt", ios::binary | ios::trunc);
            file << "Existing record\n";
        }

        HKL english = LoadKeyboardLayoutW(L"00000409", KLF_NOTELLSHELL);
        HKL russian = LoadKeyboardLayoutW(L"00000419", KLF_NOTELLSHELL);
        Require(english && russian, "English and Russian layouts must be available.");

        wstring englishRecord = LogKey('Q', english);
        Require(englishRecord.find(L"Letter: q") != wstring::npos, "English mapping failed.");
        Require(englishRecord.find(L"Key code: 81") != wstring::npos, "Key code is missing.");
        Require(englishRecord.find(title) != wstring::npos, "Unicode window title is missing.");

        wstring russianRecord = LogKey('Q', russian);
        Require(russianRecord.find(L"Letter: \u0439") != wstring::npos, "Russian Q-to-letter mapping failed.");
        testState[VK_SHIFT] = 0x80;
        Require(LogKey('Q', russian).find(L"Letter: \u0419") != wstring::npos,
            "Russian Shift mapping failed.");
        Require(LogKey('Q', english).find(L"Letter: Q") != wstring::npos,
            "English Shift mapping failed.");
        testState[VK_SHIFT] = 0;
        testState[VK_CAPITAL] = 1;
        Require(LogKey('Q', russian).find(L"Letter: \u0419") != wstring::npos,
            "Russian Caps Lock mapping failed.");
        testState[VK_CAPITAL] = 0;

        Require(LogKey('F', russian).find(L"Letter: \u0430") != wstring::npos,
            "Russian F-to-letter mapping failed.");
        Require(LogKey(VK_LEFT, russian).find(L"[non-character key]") != wstring::npos,
            "Non-character key formatting failed.");
        Require(LogKey(VK_RETURN, russian).find(L"[Enter]") != wstring::npos,
            "Enter formatting failed.");
        testWindow = nullptr;
        Require(LogKey(VK_RETURN, english).find(L"Untitled or unavailable") != wstring::npos,
            "Missing-window fallback failed.");

        ifstream input("keys.txt", ios::binary);
        string bytes((istreambuf_iterator<char>(input)), istreambuf_iterator<char>());
        Require(bytes == "Existing record\n" + Utf8(allRecords),
            "UTF-8 file contents, console output or append behavior are incorrect.");

        // Also exercise actual stdout; the runner checks the resulting UTF-16 bytes.
        wcout << englishRecord << russianRecord;
        wcout << L"PASS: layouts, Unicode title, key codes, console output, UTF-8 file, append, special keys." << endl;
        ActivateKeyboardLayout(originalLayout, 0);
        DestroyWindow(window);
        return 0;
    }
    catch (const exception& error) {
        ActivateKeyboardLayout(originalLayout, 0);
        if (window) {
            DestroyWindow(window);
        }
        // Test failures are ASCII.
        wcerr << L"FAIL: ";
        for (const char* p = error.what(); *p; ++p) {
            wcerr << static_cast<wchar_t>(*p);
        }
        wcerr << endl;
        return 1;
    }
}
