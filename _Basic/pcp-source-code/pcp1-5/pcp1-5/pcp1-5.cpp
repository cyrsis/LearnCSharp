// Professional C Programming
// Lesson 1: Integer Types
// 1.5 size_t and ptrdiff_t 
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
#include <string.h>

char *copy(size_t n, const char *str) {
	char *p;
	int i;

	if (n == 0) {
		return NULL; /* Not zero-size allocations */
	}
	p = (char *)malloc(n);
	if (p == NULL) {
		return NULL;
	}
	for (i = 0; i < n; ++i) {
		p[i] = *str++;
	}
	return p;
}

int main(void) { 
	size_t tainted_int = UINT_MAX / 2 + 100;
	char *p;
	char *str = (char *)calloc(1, tainted_int);
	if (str == NULL) {
		return EXIT_FAILURE;
	}
	strcpy(str, "Hello, World!");

	p = copy(tainted_int, str);
	if (p == NULL) {
		return EXIT_FAILURE;
	}
	printf("string copy = %s\n", p);

	return EXIT_SUCCESS;
}
