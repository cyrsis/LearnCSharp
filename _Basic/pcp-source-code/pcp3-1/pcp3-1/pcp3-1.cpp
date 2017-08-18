// Professional C Programming
// Lesson 3: Integer Operations
// 3.1 Assignment 
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
#include <stdio.h>

int  f(void);
void g(void);
void h(void);
void i(void);

int main(void) {
	char c;

	if ((c = f()) == -1){
		// The int value returned by the function is truncated when stored 
		// as char and then converted back to int width before the comparison. 
		printf("c = %d.\n", c);
	}

	// assignment
	g();

	// misinterpreted values
	h();

	// truncation
	i();

	return EXIT_SUCCESS;
}

int f(void) {
	return 255;
}

void g(void) {
	char c;
	int i = 255;
	long l;

	l = (c = i);
	printf("l = %ld.\n", l);
	return;
}

void h(void) {
	int si = -3;

	// Because the new type is unsigned, the value is converted by repeatedly
	// adding or subtracting one more than the maximum value that can be represented
	// in the new type, until the value is in the range of the new type. 
	unsigned int ui = si; 

	// If accessed as an unsigned value, the resulting value will be  
	// misinterpreted as a large, positive value.
	printf("ui = %u\n", ui); 
	return;
}

void i(void) {
	unsigned char sum;
	unsigned char c1 = 200;
	unsigned char c2 = 90;

	sum = c1 + c2;
	printf("sum = %u\n", sum); 
	return;
}