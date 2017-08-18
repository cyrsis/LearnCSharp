// ThreadSync.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

#define DO_SYNC

int _tmain(int argc, _TCHAR* argv[])
{
	HANDLE hMutex = CreateMutex(0, FALSE, _T("SyncDemoMutex"));

	char text[256];

	cout << "press enter to start (PID=" << GetCurrentProcessId() << ")..." << endl;
	cin.get();

	printf("Running...\n");

	for(int i = 0; i < 1000; i++) {
#ifdef DO_SYNC
		WaitForSingleObject(hMutex, INFINITE);
#endif
		sprintf_s(text, "Text from process %d\r\n", GetCurrentProcessId());

		HANDLE hFile = CreateFile(_T("c:\\temp\\test.txt"), GENERIC_WRITE, 
			FILE_SHARE_READ, 0, OPEN_ALWAYS, 0, 0);
		if(hFile == INVALID_HANDLE_VALUE) {
			DWORD err = ::GetLastError();
			cout << "Error opening file " << GetLastError() << " at index " << i << endl;
			break;
		}

		SetFilePointer(hFile, GetFileSize(hFile, NULL), NULL, FILE_BEGIN);
		DWORD bytes;
		WriteFile(hFile, text, strlen(text), &bytes, NULL);
		CloseHandle(hFile);
#ifdef DO_SYNC
		ReleaseMutex(hMutex);
#endif
	}

	CloseHandle(hMutex);

	cout  << "Done." << endl;

	return 0;
}
