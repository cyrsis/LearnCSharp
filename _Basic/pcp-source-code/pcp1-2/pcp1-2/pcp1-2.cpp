// Professional C Programmer 
// Lesson 1: Integer Types
// 1.2 Unsigned integers
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

#include <stdio.h>
#include <limits.h>
#include <stdlib.h>

unsigned int unsigned_int_sum(unsigned int i, unsigned int j);
unsigned int unsigned_int_difference(unsigned int i, unsigned int j);

int main(void) {
	unsigned int ui;

	ui = UINT_MAX; // 4,294,967,295 on x86-32;
	ui++;
	printf("ui = %u\n", ui); 

	ui = 0;
	ui --;
	printf("ui = %u\n", ui); 

	// Avoiding wraparound errors when checking against maximum values
	printf("sum = %u\n", unsigned_int_sum(UINT_MAX, 1));

	// Avoiding wraparound errors when checking against the minimum unsigned value 0
	printf("difference = %u\n", unsigned_int_difference(0, 1));

	return EXIT_SUCCESS;
}

#if 0
// unsigned addition (broken)
unsigned int unsigned_int_sum(unsigned int i, unsigned int j) {
	if (i + j > UINT_MAX) {  // cannot happen 
		puts("wrap around occured"); // saturation semantics
		return UINT_MAX;
	}
	else
		return i + j;
}
#endif

#if 1
// unsigned addition (corrected)
unsigned int unsigned_int_sum(unsigned int i, unsigned int j) {
	// test eliminates the possibilty of wraparound
	if (i > UINT_MAX - j) {
		puts("wrap around occured");
		return UINT_MAX; // saturation semantics
	}
	else
		return i + j;
}
#endif

#if 0
// unsigned subtraction (broken)
unsigned int unsigned_int_difference(unsigned int i, unsigned int j) {
	if (i - j < 0) { // cannot happen
		puts("wrap around occured"); 
		return 0; // saturation semantics
	}
	else
		return i - j;
}
#endif

#if 1
// unsigned subtraction (corrected)
unsigned int unsigned_int_difference(unsigned int i, unsigned int j) {
	// test eliminates the possibilty of wraparound
	if (i < j) {
		puts("wrap around occured");
		return 0; // saturation semantics
	}
	else
		return i - j;
}
#endif