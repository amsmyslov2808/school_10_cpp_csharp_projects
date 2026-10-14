#include <Windows.h>
#include <iostream>
#include <fstream>
#include <filesystem>
#include <string>
#include <cstdlib>
#include <ctime>

#pragma comment(lib, "User32.lib")

using namespace std;
namespace fs = std::filesystem;

int main()
{
    // Русский текст в консоли и случайные числа для выбора шутки.
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);
    srand(static_cast<unsigned int>(time(nullptr)));

    // Узнаём папку, в которой находится EXE.
    wchar_t exePath[32768];
    DWORD length = GetModuleFileNameW(nullptr, exePath, 32768);
    if (length == 0 || length >= 32768)
    {
        cout << "Не удалось определить папку программы.\n";
        return 1;
    }
    fs::path folder = fs::path(exePath).parent_path();

    string jokes[] = {
        "Почему компьютер замёрз? Он оставил Windows открытыми.",
        "Мой код работает. Не трогайте, он стесняется.",
        "Кот лёг на клавиатуру и написал код лучше моего.",
        "Мой пароль настолько надёжный, что даже я не могу войти.",
        "Всё идёт по плану. Просто план очень странный."
    };

    // Метка в первой строке защищает чужие файлы от удаления.
    string marker = "\xEF\xBB\xBF" "FilesFoldersMessages joke file v1";
    string prefix = "FilesFoldersMessages_joke_";

    int answer = MessageBoxW(nullptr,
        L"Что вы хотите сделать?\n\n"
        L"Да — создать 10 новых файлов с шутками рядом с EXE.\n"
        L"Нет — удалить файлы, созданные программой.\n"
        L"Отмена — выйти.",
        L"Файлы с шутками", MB_YESNOCANCEL | MB_ICONQUESTION);

    try
    {
        if (answer == IDYES)
        {
            int created = 0;
            int number = 1;

            while (created < 10)
            {
                fs::path filePath = folder / (prefix + to_string(number++) + ".txt");
                if (fs::exists(filePath))
                    continue; // Не перезаписываем существующие файлы.

                ofstream file(filePath, ios::binary);
                if (!file)
                {
                    cout << "Не удалось создать файл. Проверьте права доступа.\n";
                    return 1;
                }
                file << marker << "\r\n" << jokes[rand() % 5] << "\r\n";
                file.close();
                if (!file)
                {
                    cout << "Ошибка записи файла.\n";
                    return 1;
                }
                created++;
            }
            cout << "Создано 10 текстовых файлов со случайными шутками.\n";
        }
        else if (answer == IDNO)
        {
            int deleted = 0;

            for (const auto& entry : fs::directory_iterator(folder))
            {
                if (entry.is_symlink() || !entry.is_regular_file())
                    continue;
                string name = entry.path().filename().string();
                if (name.find(prefix) != 0 || entry.path().extension() != ".txt")
                    continue;

                ifstream file(entry.path(), ios::binary);
                string firstLine;
                getline(file, firstLine);
                file.close();

                if (firstLine == marker + "\r" && fs::remove(entry.path()))
                    deleted++;
            }
            cout << "Удалено файлов: " << deleted << "\n";
        }
        else
        {
            cout << "Действие отменено.\n";
        }
    }
    catch (const exception&)
    {
        cout << "Ошибка работы с файлами. Проверьте права доступа к папке.\n";
        return 1;
    }

    cout << "Нажмите Enter для выхода.\n";
    cin.get();
    return 0;
}
