// ParallelForNative.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <functional>

#pragma comment(lib, "winmm")

using namespace std;

int CountPrimesSerial(int first, int last);
int CountPrimesParallel(int first, int last);
int Measure(std::function<int ()> func, int& result);

int _tmain(int argc, _TCHAR* argv[]) {
	int result;
	int time = Measure([]() { 
		return CountPrimesSerial(3, 10000000); 
	}, result);
	cout << "Serial elapsed: " << time << " msec. result: " << result << endl;

	time = Measure([]() { 
		return CountPrimesParallel(3, 10000000); 
	}, result);
	cout << "Parallel elapsed: " << time << " msec. result: " << result << endl;

	return 0;
}

int Measure(std::function<int ()> func, int& result) {
	auto start = ::timeGetTime();
	result = func();
	return ::timeGetTime() - start;
}

int CountPrimesSerial(int first, int last) {
	int count = 0;
	for(int i = first; i <= last; i++) {
		int limit = (int)::sqrt(i);
		bool prime = true;
		for(int j = 2; j <= limit; j++)
			if(i % j == 0) {
				prime = false;
				break;
			}
			if(prime)
				++count;
	}
	return count;			
}

int CountPrimesParallel(int first, int last) {
	int count = 0;
	return count;			
}
