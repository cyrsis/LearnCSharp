// WinVer.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	OSVERSIONINFOEX vi = { sizeof(vi) };
	::GetVersionEx((OSVERSIONINFO*)&vi);

	printf("Version: %d.%d\n", vi.dwMajorVersion, vi.dwMinorVersion);
	printf("%ws\n", vi.szCSDVersion);
	printf("Build %d\n", vi.dwBuildNumber);

	return 0;
}

