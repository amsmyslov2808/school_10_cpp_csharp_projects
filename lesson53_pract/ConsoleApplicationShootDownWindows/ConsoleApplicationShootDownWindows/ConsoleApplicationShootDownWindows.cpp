#include <windows.h>
#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);

    // Старое решение: выключение через 5 секунд.
    // cout << "Компьютер выключится через 5 секунд!\n";
    // system("shutdown /s /f /t 5");

    int hours, minutes, seconds;
    cout << "Введите время выключения: часы минуты секунды (например, 23 30 0): ";
    if (!(cin >> hours >> minutes >> seconds) ||
        hours < 0 || hours > 23 ||
        minutes < 0 || minutes > 59 ||
        seconds < 0 || seconds > 59)
    {
        cout << "Неверное время!\n";
        return 1;
    }

    // Получаем текущее время компьютера.
    SYSTEMTIME now;
    GetLocalTime(&now);

    // Переводим оба времени в секунды от начала дня.
    int currentTime = now.wHour * 3600 + now.wMinute * 60 + now.wSecond;
    int shutdownTime = hours * 3600 + minutes * 60 + seconds;
    int waitSeconds = shutdownTime - currentTime;

    // Если время уже прошло, выключение будет завтра.
    if (waitSeconds < 0)
        waitSeconds += 24 * 3600;

    cout << "До выключения: " << waitSeconds << " секунд.\n";
    cout << "Несохранённые данные могут быть потеряны!\n";
    cout << "Для отмены выполните команду shutdown /a.\n";

    string command = "shutdown /s /f /t " + to_string(waitSeconds);
    if (system(command.c_str()) != 0)
    {
        cout << "Не удалось запланировать выключение.\n";
        return 1;
    }
    return 0;
}
