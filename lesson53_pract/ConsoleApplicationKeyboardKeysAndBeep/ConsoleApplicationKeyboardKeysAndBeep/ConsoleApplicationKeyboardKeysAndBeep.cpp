#include <iostream>
#include <conio.h>
#include <Windows.h>

using namespace std;

int main()
{
    SetConsoleOutputCP(CP_UTF8); // Русский текст в консоли.

    cout << "Нажимай стрелки — каждая издаёт свой звук!\n";
    cout << "Для выхода нажми Esc.\n";

    while (true)
    {
        int myKey = _getch(); // Читаем клавишу без нажатия Enter.

        if (myKey == 27) // Esc — выход.
            break;

        // У стрелок два кода: сначала 0 или 224, затем код стрелки.
        if (myKey == 0 || myKey == 224)
        {
            myKey = _getch();

            // Beep(частота звука в герцах, длительность в миллисекундах).
            switch (myKey)
            {
            case 72:
                cout << "Вверх\n";
                Beep(1000, 200);
                break;
            case 80:
                cout << "Вниз\n";
                Beep(400, 200);
                break;
            case 75:
                cout << "Влево\n";
                Beep(600, 200);
                break;
            case 77:
                cout << "Вправо\n";
                Beep(800, 200);
                break;
            }
        }
    }

    return 0;
}

