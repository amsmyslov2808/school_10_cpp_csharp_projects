#include <iostream>
#include <Windows.h>

using namespace std;

int main()
{
	srand(time(0));

	int width = GetSystemMetrics(SM_CXSCREEN);
	int height = GetSystemMetrics(SM_CYSCREEN);

	while (true)
	{
		int x = rand() % width;
		int y = rand() % height;
		
		SetCursorPos(x, y);

		Sleep(1000);
	}


    
	return 0;
}
