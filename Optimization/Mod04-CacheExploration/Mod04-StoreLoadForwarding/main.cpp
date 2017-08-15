#include <chrono>
#include <iostream>
#include <string>

#include <xmmintrin.h>

template <typename Callable>
void time_call(std::string const& what, Callable&& c)
{
	const int ITERATIONS = 100;
	c(); // warm up
	double timeNS = 0;
	for (int i = 0; i < ITERATIONS; ++i)
	{
		auto start = std::chrono::high_resolution_clock::now();
		c();
		auto end = std::chrono::high_resolution_clock::now();
		auto durationNS = std::chrono::duration_cast<std::chrono::nanoseconds>(end - start);
		timeNS += durationNS.count();
	}
	std::cout << what << "\taverage time per iteration: " << 0.001*timeNS / ITERATIONS << " us" << std::endl;
}

const int REPETITIONS = 10000000;

float get_component(int comp)
{
	return 1.0f*comp;
}

struct point4d
{
	float x;
	float y;
	float z;
	float w;
};

point4d pt;
__m128 avg;

void bad_case()
{
	pt.y = 2.0f;
	pt.z = 4.0f;

	// Four floats initialized to 0
	avg = _mm_set_ps1(0.0f);

	for (int i = 0; i < REPETITIONS; ++i)
	{
		pt.x = get_component(i);
		pt.z = get_component(2);
		// Add the four floats from 'pt' to the four floats currently in 'avg',
		// pointwise (the 'pt.x' to the first float of 'avg', etc.)
		avg = _mm_add_ps(*(__m128*)&pt, avg);
	}
}

void good_case()
{
	pt.y = 2.0f;
	pt.z = 4.0f;

	// Four floats initialized to 0
	avg = _mm_set_ps1(0.0f);

	for (int i = 0; i < REPETITIONS; ++i)
	{
		// Initialize a temporary 'val' with the two new values from get_component
		// and the two constant values 2.0f and 4.0f
		__m128 val = _mm_set_ps(get_component(i), 2.0f, get_component(2), 4.0f);
		// Store the four floats from 'val' into 'pt'
		_mm_store_ps((float*)&pt, val);
		// Add the four floats from 'pt' to the four floats currently in 'avg',
		// pointwise (the 'pt.x' to the first float of 'avg', etc.)
		avg = _mm_add_ps(*(__m128*)&pt, avg);
	}
}

int main()
{
	time_call("BAD", bad_case);
	time_call("GOOD", good_case);

	return 0;
}