// Unicode.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	HANDLE hFile = ::CreateFile(L"c:\\temp\\sample.txt", GENERIC_WRITE, 0, nullptr, CREATE_ALWAYS, 0, 0);

	::CloseHandle(hFile);

	return 0;
}

