// Professional C Programming 
// Lesson 5: String Handling
// 5.2 Bounds-checking interfaces
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

#define __STDC_WANT_LIB_EXT1__ 1

#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <crtdbg.h>  // For _CrtSetReportMode

void myInvalidParameterHandler(
	const wchar_t* expression,
	const wchar_t* function, 
	const wchar_t* file, 
	unsigned int line, 
	uintptr_t pReserved) {
		wprintf(L"Invalid parameter detected in function %s.\n"
			L" File: %s Line: %d\n", function, file, line);
		wprintf(L"Expression: %s\n", expression);
}

// This function has implementation defined behavior if more than
// 8 charactes are entered at the prompt.
void get_y_or_n(void) {
	char response[8];
	size_t len = sizeof(response);
	printf("Continue? [y] n: ");
	gets_s(response, len); // Array bounds are checked
	if (response[0] == 'n')
		exit(0);
}

void copy(void) {
  char a[16];
  char b[16];
  char c[24];

  strcpy_s(a, sizeof(a), "0123456789abcdef");  // fails and generates a runtime constraint error.
  strcpy_s(b, sizeof(b), "0123456789abcdef");
  strcpy_s(c, sizeof(c), a);
  strcat_s(c, sizeof(c), b);
}

int main(void) {

	_invalid_parameter_handler oldHandler; 
	oldHandler = _set_invalid_parameter_handler(myInvalidParameterHandler);

	// Disable the message box for assertions.
   _CrtSetReportMode(_CRT_ASSERT, 0);

#if 0
	constraint_handler_t oconstraint = 
		set_constraint_handler_s(ignore_handler_s);
#endif 

	get_y_or_n();

	copy();

	return EXIT_SUCCESS;
}