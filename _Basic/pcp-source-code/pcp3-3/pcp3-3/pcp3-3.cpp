// Professional C Programming
// Lesson 3: Integer Operations
// 3.3 Multiplication and upcasting
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

void * AllocBlocksIncorrect(size_t cBlocks);
void * AllocBlocksCorrect(size_t cBlocks);
void * AllocBlocksPortable(size_t cBlocks);
 
int main(void) {
	void *p = AllocBlocksIncorrect(UINT_MAX / 3 + 100); 
	if (p == NULL) puts("AllocBlocksIncorrect detected wraparound.");

	p = AllocBlocksCorrect(UINT_MAX / 3 + 100); 
	if (p == NULL) puts("AllocBlocksCorrect detected wraparound.");

	p = AllocBlocksPortable(UINT_MAX / 3 + 100); 
	if (p == NULL) puts("AllocBlocksPortable detected wraparound.");

	return EXIT_SUCCESS;
}

// incorrect solution
void * AllocBlocksIncorrect(size_t cBlocks) {
	// Upcast the result to a 64-bit integer  
	// and check against 32-bit SIZE_MAX   
	// to make sure there's no overflow
	unsigned long long alloc = cBlocks * 3;
	return (alloc < SIZE_MAX) ? malloc(cBlocks * 3): NULL;
}

// correct solution
void * AllocBlocksCorrect(size_t cBlocks) {
	// Upcast the result to a 64-bit integer  
	// and check against 32-bit SIZE_MAX   
	// to make sure there's no overflow
	unsigned long long alloc = (unsigned long long)cBlocks * 3;
	return (alloc < SIZE_MAX) ? malloc(cBlocks * 3): NULL;
}

// correct and portable solution
void * AllocBlocksPortable(size_t cBlocks) {
  return (cBlocks < SIZE_MAX / 3) ? malloc(cBlocks * 3) : NULL;
}



