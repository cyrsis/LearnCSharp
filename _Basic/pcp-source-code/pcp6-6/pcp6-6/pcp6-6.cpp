// Professional C Programming
// Lesson 6: Optimization
// 6.6 Aliasing
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

struct S { int a, b; } s;

// loop invariant bounds
// *pi can be assumed to be loop-invariant, because the type-based 
// aliasing rules don't allow *pd to be an alias for *pi.
void f1(int *pi, double *pd, double d) {
	int i;
	for (i = 0; i < *pi; i++) {
		*pd++ = d;
	}
}

// bounds may be modified
// *pi (having type int) can be modified by an lvalue that has 
// aggregate type including a member of type int such as struct S
void f2(int *pi, struct S *ps, struct S s) {
	int i;
	// *pi must be reloaded for each iteration, and on the tenth iteration, 
	// the value of *pi becomes zero, causing the loop to terminate before 
	// writing past the end of the array.
	for (i = 0; i < *pi; i++) {
		*ps++ = s;
	}
}

int main(int argc, char *argv[]) {
	int i;
	int a;
	double d;
	double darray[10];
	struct S scary_array[10];

	if (argc < 3) return EXIT_FAILURE;
	a = atoi(argv[1]);
	d = atof(argv[2]);

	f1(&a, darray, d);

	// scary array
	s.a = 0;
	s.b = 0;
	
	scary_array[9].b = 1000;

	// Despite the fact that the initial value of *pi in the loop is 
	// too large for the array, this usage is nevertheless safe.
    f2(&scary_array[9].b, scary_array, s);

	for (i = 0; i < a; i++) {
	  printf("darray[%d] = %lf.\n", i, darray[0]);
	}
	puts("");

	for (i = 0; i < a; i++) {
	  printf("scary_array[%d] = %d.\n", i, scary_array[0]);
	}
	puts("");

	return EXIT_SUCCESS;
}










#if 0
	uint32_t swap = atoi(argv[3]);

	printf("swap = %x.\n", swap);
	printf("swap swapped = %x.\n", swap_words(swap));

uint32_t swap_words(uint32_t arg) {
  uint16_t * const sp = (uint16_t *)&arg;
  uint16_t hi = sp[0];
  uint16_t lo = sp[1];
  
  sp[1] = hi;
  sp[0] = lo;
  return (arg);
} 

struct st { 
	char c; int i; long l; double d; 
} t = { 1, 2, 3, 4 };

void effective_types(void) {
	char *p;
	char *p0; 
	void *p1;

	p = malloc(sizeof s); 
	assert(p);  // no type

	p0 = malloc(sizeof s); 
	assert(p0);

	memcpy(p0, &s, sizeof s); // struct st

	p1 = malloc(sizeof s); assert(p1); 
	memcpy(p1, &s, sizeof s); // struct st 
	memcpy(p1, &s.i, sizeof(int)); // int

	f1(p1, &s.d, 8.3);

	memcpy(p1, (float *) &s.i, sizeof(int)); // float

	f2(p1, &s.d, 8.3);
}
#endif