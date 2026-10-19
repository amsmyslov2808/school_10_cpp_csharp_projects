#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <Windows.h>
#include <cstdio>
#include <fcntl.h>
#include <io.h>
#include <iostream>
#include <random>
#include <stdexcept>
#include <string>

using namespace std;

constexpr int ID_EDIT_MIN = 101;
constexpr int ID_EDIT_MAX = 102;
constexpr int ID_BUTTON_RANDOM = 103;
constexpr int ID_BUTTON_CLEAR = 104;
constexpr int ID_RESULT = 105;

HWND editMin = nullptr;
HWND editMax = nullptr;
HWND resultLabel = nullptr;

wstring ReadText(HWND control)
{
    const int length = GetWindowTextLengthW(control);
    wstring text(length + 1, L'\0');

    const int copied = GetWindowTextW(control, text.data(), length + 1);
    text.resize(copied);

    const auto first = text.find_first_not_of(L" \t\r\n");
    if (first == wstring::npos)
    {
        return L"";
    }
    return text.substr(first, text.find_last_not_of(L" \t\r\n") - first + 1);
}

int ParseNumber(const wstring& text)
{
    size_t used = 0;
    const int number = stoi(text, &used);
    return number;
}

void GenerateNumber(HWND hwnd)
{
    const wstring minText = ReadText(editMin);
    const wstring maxText = ReadText(editMax);

    int minNumber = ParseNumber(minText);
    int maxNumber = ParseNumber(maxText);

    static mt19937 generator(random_device{}());
    uniform_int_distribution<int> distribution(minNumber, maxNumber);
    const int number = distribution(generator);

    SetWindowTextW(resultLabel, to_wstring(number).c_str());
}

LRESULT CALLBACK WindowProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
	case WM_CREATE:
	{
        const HINSTANCE instance = reinterpret_cast<LPCREATESTRUCTW>(lParam)->hInstance;

        HWND minLabel = CreateWindowExW(0, L"STATIC", L"Минимальное число:",
            WS_CHILD | WS_VISIBLE, 24, 28, 195, 24, hwnd, nullptr, instance, nullptr);

        editMin = CreateWindowExW(WS_EX_CLIENTEDGE, L"EDIT", L"1",
            WS_CHILD | WS_VISIBLE | WS_TABSTOP | ES_AUTOHSCROLL,
            225, 24, 220, 28, hwnd, reinterpret_cast<HMENU>(static_cast<INT_PTR>(ID_EDIT_MIN)), instance, nullptr);

        HWND maxLabel = CreateWindowExW(0, L"STATIC", L"Максимальное число:",
            WS_CHILD | WS_VISIBLE, 24, 76, 195, 24, hwnd, nullptr, instance, nullptr);

        editMax = CreateWindowExW(WS_EX_CLIENTEDGE, L"EDIT", L"100",
            WS_CHILD | WS_VISIBLE | WS_TABSTOP | ES_AUTOHSCROLL,
            225, 72, 220, 28, hwnd, reinterpret_cast<HMENU>(static_cast<INT_PTR>(ID_EDIT_MAX)), instance, nullptr);

        HWND generateButton = CreateWindowExW(0, L"BUTTON", L"Сгенерировать",
            WS_CHILD | WS_VISIBLE | WS_TABSTOP | BS_PUSHBUTTON,
            24, 124, 195, 34, hwnd, reinterpret_cast<HMENU>(static_cast<INT_PTR>(ID_BUTTON_RANDOM)), instance, nullptr);

        HWND resultCaption = CreateWindowExW(0, L"STATIC", L"Результат:",
            WS_CHILD | WS_VISIBLE, 24, 186, 110, 28, hwnd, nullptr, instance, nullptr);

        resultLabel = CreateWindowExW(0, L"STATIC", L"",
            WS_CHILD | WS_VISIBLE, 140, 186, 305, 28,
            hwnd, reinterpret_cast<HMENU>(static_cast<INT_PTR>(ID_RESULT)), instance, nullptr);

        const HWND controls[] = { minLabel, editMin, maxLabel, editMax,
            generateButton, resultCaption, resultLabel };

        for (HWND control : controls)
        {
            SendMessageW(control, WM_SETFONT, reinterpret_cast<WPARAM>(GetStockObject(DEFAULT_GUI_FONT)), TRUE);
        }

		return 0;
	}
    case WM_COMMAND:
    {
        const int id = LOWORD(wParam);
        const int notification = HIWORD(wParam);

        if (id == ID_BUTTON_RANDOM && notification == BN_CLICKED)
        {
            GenerateNumber(hwnd);
        }

		return 0;
    }
    case WM_DESTROY:
    {
        PostQuitMessage(0);
        return 0;
    }
    }
    return DefWindowProcW(hwnd, message, wParam, lParam);
}

int WINAPI wWinMain(HINSTANCE instance, HINSTANCE, PWSTR, int showCommand)
{
    const wchar_t CLASS_NAME[] = L"RandomNumberGeneratorWindow";
    WNDCLASSEXW windowClass{};
    windowClass.cbSize = sizeof(windowClass);
    windowClass.lpfnWndProc = WindowProc;
    windowClass.hInstance = instance;
    windowClass.hCursor = LoadCursorW(nullptr, IDC_ARROW);
    windowClass.hbrBackground = reinterpret_cast<HBRUSH>(COLOR_BTNFACE + 1);
    windowClass.lpszClassName = CLASS_NAME;

    RegisterClassExW(&windowClass);

    HWND hwnd = CreateWindowExW(0, CLASS_NAME, L"Random Number Generator",
        WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 500, 300,
        nullptr, nullptr, instance, nullptr);

    ShowWindow(hwnd, showCommand);
    UpdateWindow(hwnd);

    MSG message{};
    BOOL status;
    while ((status = GetMessageW(&message, nullptr, 0, 0)) > 0)
    {
        TranslateMessage(&message);
        DispatchMessageW(&message);
    }

	return 0;
}