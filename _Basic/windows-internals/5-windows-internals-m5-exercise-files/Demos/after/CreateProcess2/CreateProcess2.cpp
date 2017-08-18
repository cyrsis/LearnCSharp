// CreateProcess2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

int _tmain(int argc, _TCHAR* argv[]) {
	STARTUPINFO si = { sizeof(si) };
	PROCESS_INFORMATION pi;

	TCHAR name[] = _T("calc");
	BOOL success = CreateProcess(nullptr, name, nullptr, nullptr, FALSE, 0, nullptr, nullptr, &si, &pi);
	if(success) {
		cout << "PID: " << pi.dwProcessId << endl;
		cout << "TID: " << pi.dwThreadId << endl;
		cout << "Process handle: " << pi.hProcess << endl;

		WaitForSingleObject(pi.hProcess, INFINITE);
		cout << "Calc terminated." << endl;
		
		CloseHandle(pi.hProcess);
		CloseHandle(pi.hThread);

	}
	else {
		cout << "Creation failed. error=" << GetLastError() << endl;
	}
	return 0;
}

