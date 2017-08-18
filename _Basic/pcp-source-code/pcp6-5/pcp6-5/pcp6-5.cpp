// Professional C Programming
// Lesson 6: Optimization
// 6.5  Dead-code removal
// Robert C. Seacord
//
// Copyright © 2013 Pearson Education, Inc. 
// 
// All rights reserved.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, 
// EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#include <stdlib.h>
#include <stdint.h>
#include <stdio.h>
#include <string.h>
#include <Windows.h>

// memset()
int getPassword1(void) {
	char pwd[64];
	char *p;
	if (fgets(pwd, sizeof(pwd), stdin)) {
		p = strchr(pwd, '\n');
		if (p) *p = '\0';
	}
	else {
		return -1;
	}
	// Verify password
	memset(pwd, 0, sizeof(pwd));
	return 0;  // password verified
}

// The ZeroMemory() function is not defined by the C standard but 
// provided by many versions of MSVC.
int getPassword2(void) {
	char pwd[64];
	char *p;
	if (fgets(pwd, sizeof(pwd), stdin)) {
		p = strchr(pwd, '\n');
		if (p) *p = '\0';
	}
	else {
		return -1;
	}
	// Verify password
	ZeroMemory(pwd, sizeof(pwd));
	return 0;  // password verified
}

// The MSVC SecureZeroMemory() function guarantees that the compiler does 
// not optimize out this call when zeroing memory.
int getPassword3(void) {
	char pwd[64];
	char *p;
	if (fgets(pwd, sizeof(pwd), stdin)) {
		p = strchr(pwd, '\n');
		if (p) *p = '\0';
	}
	else {
		return -1;
	}
	// Verify password
	SecureZeroMemory(pwd, sizeof(pwd));
	return 0;  // password verified
}

// The #pragma directives in this example instruct the compiler to avoid 
// optimizing the enclosed code. This #pragma directive is supported on 
// some versions of Microsoft Visual Studio and may be supported on other compilers.
#pragma optimize("", off)
int getPassword4(void) {
	char pwd[64];
	char *p;
	if (fgets(pwd, sizeof(pwd), stdin)) {
		p = strchr(pwd, '\n');
		if (p) *p = '\0';
	}
	else {
		return -1;
	}
	// Verify password
    memset(pwd, 0, sizeof(pwd));
	return 0;  // password verified
}
#pragma optimize("", on)

// This code accesses the buffer after the call to memset(). 
// Some implementations nullify only the first byte and leave the remainder intact.
int getPassword5(void) {
	char pwd[64];
	char *p;
	if (fgets(pwd, sizeof(pwd), stdin)) {
		p = strchr(pwd, '\n');
		if (p) *p = '\0';
	}
	else {
		return -1;
	}
	// Verify password
	memset(pwd, 0, sizeof(pwd));
    *(volatile char*)pwd = *(volatile char*)pwd;
	return 0;  // password verified
}

void *secure_memset(void *v, int c, size_t n) {
  volatile unsigned char *p = v;
  while (n--)
    *p++ = (unsigned char)c;
  return v;
}

// The volatile type qualifier informs the compiler that the memory 
// should be overwritten and that the call to the memset_s() function 
// should not be optimized out. 
int getPassword6(void) {
	char pwd[64];
	char *p;
	if (fgets(pwd, sizeof(pwd), stdin)) {
		p = strchr(pwd, '\n');
		if (p) *p = '\0';
	}
	else {
		return -1;
	}
	// Verify password
	secure_memset(pwd, 0, sizeof(pwd));
	return 0;  // password verified
}

int main(void) {
	if (getPassword1()) {
		puts("Incorrect or missing password.");
		return EXIT_FAILURE;
	}
	puts("Access granted.");

	//--------------------------------------------------------

	if (getPassword2()) {
		puts("Incorrect or missing password.");
		return EXIT_FAILURE;
	}
	puts("Access granted.");

	//--------------------------------------------------------

	if (getPassword3()) {
		puts("Incorrect or missing password.");
		return EXIT_FAILURE;
	}
	puts("Access granted.");

	//--------------------------------------------------------

	if (getPassword4()) {
		puts("Incorrect or missing password.");
		return EXIT_FAILURE;
	}
	puts("Access granted.");

	//--------------------------------------------------------

	if (getPassword5()) {
		puts("Incorrect or missing password.");
		return EXIT_FAILURE;
	}
	puts("Access granted.");

	//--------------------------------------------------------

	if (getPassword6()) {
		puts("Incorrect or missing password.");
		return EXIT_FAILURE;
	}
	puts("Access granted.");

	return EXIT_SUCCESS;
}


















#if 0
typedef struct {
	uint16_t a;
	uint16_t b;
	uint16_t c;
} Sample;

void test(uint32_t *value, Sample *uniform, uint64_t count) {
	uint64_t i;

	for (i = 0; i < count; i++) {
		value[i] += (uint32_t)uniform->b;
	}
}

int main(void) {
	uint32_t value[10];
	Sample sample = { 1, 2, 3 };
	test(value, &sample, 10);
	return 0;
}
#endif
