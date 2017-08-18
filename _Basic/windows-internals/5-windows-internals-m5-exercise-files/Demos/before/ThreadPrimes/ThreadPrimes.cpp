// ThreadPrimes.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

#pragma comment(lib, "winmm.lib")


DWORD WINAPI CalcPrimes(PVOID p);


int _tmain(int argc, _TCHAR* argv[]) {
	int first = 3, last = 20000000;



	return 0;
}

bool IsPrime(int number) {
	int limit = (int)sqrt((float)number);
	for(int j = 2; j <= limit; j++)
		if(number % j == 0)
			return false;
	return true;
}

DWORD WINAPI CalcPrimes(PVOID p) {

	return 0;
}


