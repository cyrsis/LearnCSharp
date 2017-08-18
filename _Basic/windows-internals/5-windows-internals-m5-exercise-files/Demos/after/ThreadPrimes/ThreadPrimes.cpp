// ThreadPrimes.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

#pragma comment(lib, "winmm.lib")

const int NUM_THREADS = 8;

DWORD WINAPI CalcPrimes(PVOID p);

struct PrimeData {
	int first, last;
	int count;
};

int _tmain(int argc, _TCHAR* argv[]) {
	int first = 3, last = 20000000;

	PrimeData data[NUM_THREADS];
	int delta = (last - first + 1) / NUM_THREADS;
	HANDLE hThread[NUM_THREADS];

	printf("Working... %d\n", ::GetCurrentThreadId());
	DWORD start = timeGetTime();

	DWORD id;
	for(int i = 0; i < NUM_THREADS; i++) {
		data[i].first = first + i * delta;
		data[i].last = i == NUM_THREADS - 1 ? last : first + (i + 1) * delta - 1;
		hThread[i] = CreateThread(nullptr, 0, CalcPrimes, &data[i], 0, &id);
	}

	WaitForMultipleObjects(NUM_THREADS, hThread, TRUE, INFINITE);
	DWORD stop = timeGetTime();

	int total = 0;
	for(int i = 0; i < NUM_THREADS; i++) {
		cout << "thread " << i << " result: " << data[i].count << endl;
		total += data[i].count;
	}
	printf("\nTotal: %d\n", total);

	for(int i = 0; i < NUM_THREADS; i++)
		CloseHandle(hThread[i]);

	printf("\nCalculation time: %d msec\n", stop - start);

	return 0;
}

DWORD WINAPI CalcPrimes(PVOID p) {
	PrimeData* data = (PrimeData*)p;

	int count = 0;

	for(int i = data->first; i <= data->last; i++) {
		int limit = (int)sqrt((float)i), j;
		for(j = 2; j <= limit; j++)
			if(i % j == 0)
				break;
		if(j == limit + 1) {
			count++;
		}
	}

	data->count = count;

	return 0;
}


