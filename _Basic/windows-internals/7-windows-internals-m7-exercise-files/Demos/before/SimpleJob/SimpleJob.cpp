// SimpleJob.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

int _tmain(int argc, _TCHAR* argv[]) {
	STARTUPINFO si = { sizeof(si) };
	PROCESS_INFORMATION pi;
	TCHAR name[] = _T("notepad");

	BOOL success = CreateProcess(nullptr, name, nullptr, nullptr, FALSE, 0, nullptr, nullptr, &si, &pi);

	cout << "Press any key to terminate all those notepads..." << endl;
	cin.get();

	return 0;
}

