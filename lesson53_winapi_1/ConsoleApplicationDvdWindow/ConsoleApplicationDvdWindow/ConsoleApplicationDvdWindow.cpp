
#include <iostream>
#include <Windows.h>

using namespace std;

int main()
{
	SetConsoleOutputCP(CP_UTF8);
	SetConsoleCP(CP_UTF8);

	cout << "Переключись на окно, которое хочешь запустить.\n";
	cout << "У тебя есть 3 секунды...\n";

	Sleep(3000);

	int screenWidth = GetSystemMetrics(SM_CXSCREEN);
	int screenHeight = GetSystemMetrics(SM_CYSCREEN);

	RECT rect;
	HWND activeWindow = GetForegroundWindow();

	GetWindowRect(activeWindow, &rect);

	int activeWindowX = rect.left;
	int activeWindowY = rect.top;

	int activeWindowWidth = rect.right - rect.left;
	int activeWindowHeight = rect.bottom - rect.top;
	
	int dx = 5;
	int dy = 5;

	while (true)
	{
		activeWindowX += dx;
		activeWindowY += dy;

		if (activeWindowX <= 0 || activeWindowX + activeWindowWidth >= screenWidth)
		{
			dx = -dx;
		}

		if (activeWindowY <= 0 || activeWindowY + activeWindowHeight >= screenHeight)
		{
			dy = -dy;
		}

		SetWindowPos(activeWindow, NULL, activeWindowX, activeWindowY, 0, 0, SWP_NOSIZE | SWP_NOZORDER);
		Sleep(10);
	}


	return 0;
}

