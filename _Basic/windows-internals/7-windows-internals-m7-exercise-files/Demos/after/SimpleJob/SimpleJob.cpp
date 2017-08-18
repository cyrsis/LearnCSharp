// SimpleJob.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

int _tmain(int argc, _TCHAR* argv[]) {
	STARTUPINFO si = { sizeof(si) };
	PROCESS_INFORMATION pi;
	TCHAR name[] = _T("notepad");

	HANDLE hJob = CreateJobObject(nullptr, nullptr);

	for(int i = 0; i < 5; i++) {
		BOOL success = CreateProcess(nullptr, name, nullptr, nullptr, FALSE, 0, nullptr, nullptr, &si, &pi);
		if(success) {
			AssignProcessToJobObject(hJob, pi.hProcess);
			CloseHandle(pi.hProcess);
		}
	}

	cout << "Press any key to terminate all those notepads..." << endl;
	cin.get();

	TerminateJobObject(hJob, 1);
	cout << "Done!" << endl;

	CloseHandle(hJob);

	return 0;
}

