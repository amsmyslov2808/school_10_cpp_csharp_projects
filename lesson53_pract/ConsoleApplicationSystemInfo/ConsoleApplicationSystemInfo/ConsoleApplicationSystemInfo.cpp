#include <Windows.h>
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    // Настраиваем консоль для вывода русского текста в UTF-8.
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);
    cout << fixed << setprecision(2);
    cout << "ИНФОРМАЦИЯ О КОМПЬЮТЕРЕ\n";

    // 1. Имя компьютера. Массив хранит текст, size — размер массива.
    char name[MAX_COMPUTERNAME_LENGTH + 1]{};
    DWORD size = sizeof(name);
    if (GetComputerNameA(name, &size))
        cout << "Имя компьютера: " << name << "\n";

    // 2. Информация о процессоре.
    // {} заполняет поля структуры нулями, & передаёт её адрес функции.
    SYSTEM_INFO system{};
    GetNativeSystemInfo(&system);
    cout << "Логических процессоров: " << system.dwNumberOfProcessors << "\n";

    // 3. Архитектура компьютера.
    if (system.wProcessorArchitecture == PROCESSOR_ARCHITECTURE_AMD64)
        cout << "Архитектура: x64\n";
    else if (system.wProcessorArchitecture == PROCESSOR_ARCHITECTURE_ARM64)
        cout << "Архитектура: ARM64\n";
    else if (system.wProcessorArchitecture == PROCESSOR_ARCHITECTURE_INTEL)
        cout << "Архитектура: x86\n";
    else
        cout << "Архитектура: другая\n";

    // 4–6. Общий объём, доступный объём и загрузка оперативной памяти.
    // Один ГиБ равен 1024 * 1024 * 1024 байт.
    const double gib = 1024.0 * 1024 * 1024;
    MEMORYSTATUSEX memory{};
    memory.dwLength = sizeof(memory);
    if (GlobalMemoryStatusEx(&memory))
    {
        cout << "Всего памяти: " << memory.ullTotalPhys / gib << " ГиБ\n";
        cout << "Доступно памяти: " << memory.ullAvailPhys / gib << " ГиБ\n";
        cout << "Загрузка памяти: " << memory.dwMemoryLoad << " %\n";
    }
    else
        cout << "Не удалось получить сведения о памяти.\n";

    // Основной монитор: разрешение и частота обновления.
    DEVMODEA monitor{};
    monitor.dmSize = sizeof(monitor);
    if (EnumDisplaySettingsA(nullptr, ENUM_CURRENT_SETTINGS, &monitor))
    {
        cout << "\nОсновной монитор\n";
        cout << "Разрешение: " << monitor.dmPelsWidth << " x " << monitor.dmPelsHeight << "\n";
        if (monitor.dmDisplayFrequency > 1)
            cout << "Частота: " << monitor.dmDisplayFrequency << " Гц\n";
        else
            cout << "Частота: неизвестна\n";
    }
    else
        cout << "Не удалось получить сведения о мониторе.\n";

    // Диски: перебираем буквы от A до Z обычным циклом.
    // Это разделы (например, C: и D:), а не отдельные физические устройства.
    cout << "\nРазделы жёстких дисков\n";
    for (char letter = 'A'; letter <= 'Z'; letter++)
    {
        char path[] = "A:\\";
        path[0] = letter;
        if (GetDriveTypeA(path) == DRIVE_FIXED)
        {
            ULARGE_INTEGER available{}, total{}, free{};
            if (GetDiskFreeSpaceExA(path, &available, &total, &free))
            {
                cout << path << " Всего: " << total.QuadPart / gib << " ГиБ";
                cout << "; свободно: " << free.QuadPart / gib << " ГиБ\n";
            }
            else
                cout << path << " Не удалось получить размер.\n";
        }
    }

    // 7. Время работы: переводим миллисекунды в часы и минуты.
    ULONGLONG minutes = GetTickCount64() / 1000 / 60;
    cout << "\nВремя работы: " << minutes / 60 << " ч. " << minutes % 60 << " мин.\n";

    // 8. Заряд батареи. Значение 255 означает, что данные неизвестны.
    SYSTEM_POWER_STATUS power{};
    if (GetSystemPowerStatus(&power))
    {
        if (power.BatteryFlag == 255)
            cout << "Состояние батареи неизвестно.\n";
        else if (power.BatteryFlag & 128)
            cout << "Батареи нет.\n";
        else if (power.BatteryLifePercent != 255)
            cout << "Заряд батареи: " << static_cast<int>(power.BatteryLifePercent) << " %\n";
        else
            cout << "Заряд батареи неизвестен.\n";
    }
    else
        cout << "Не удалось получить сведения о батарее.\n";

    return 0;
}
