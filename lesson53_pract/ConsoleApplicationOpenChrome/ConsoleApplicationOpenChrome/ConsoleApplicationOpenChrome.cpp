#include <iostream>
#include <string>
#include <windows.h>
#include <shellapi.h>

#pragma comment(lib, "Shell32.lib")
#pragma comment(lib, "Advapi32.lib")

using namespace std;

int main()
{
    // Включаем UTF-8 для русского текста в консоли.
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);

    // Получаем полный путь к этой программе.
    wchar_t path[32768];
    DWORD length = GetModuleFileNameW(nullptr, path, 32768);

    if (length > 0 && length < 32768)
    {
        // Кавычки нужны, если в пути есть пробелы.
        wstring command = L"\"" + wstring(path) + L"\"";
        HKEY key;

        // Автозапуск только для текущего пользователя, без прав администратора.
        LONG status = RegCreateKeyExW(
            HKEY_CURRENT_USER,
            L"Software\\Microsoft\\Windows\\CurrentVersion\\Run",
            0, nullptr, 0, KEY_SET_VALUE, nullptr, &key, nullptr);

        if (status == ERROR_SUCCESS)
        {
            status = RegSetValueExW(
                key, L"OpenChromeAliExpress", 0, REG_SZ,
                reinterpret_cast<const BYTE*>(command.c_str()),
                static_cast<DWORD>((command.size() + 1) * sizeof(wchar_t)));
            RegCloseKey(key);
        }

        if (status == ERROR_SUCCESS)
            cout << "Программа добавлена в автозапуск текущего пользователя.\n";
        else
            cout << "Не удалось добавить программу в автозапуск. Код ошибки: " << status << "\n";
    }
    else
    {
        cout << "Не удалось получить путь программы для автозапуска.\n";
    }

    cout << "Открываем AliExpress в Google Chrome...\n";

    // Запускаем установленный Chrome и передаём ему адрес сайта.
    HINSTANCE result = ShellExecuteW(
        nullptr, L"open", L"chrome.exe",
        L"https://www.aliexpress.com/", nullptr, SW_SHOWNORMAL);

    if ((INT_PTR)result <= 32)
        cout << "Не удалось открыть Chrome. Проверьте, установлен ли он.\n";
    else
        cout << "Сайт открыт!\n";

    cout << "Нажмите Enter, чтобы закрыть программу.\n";
    cin.get();
    return 0;
}
