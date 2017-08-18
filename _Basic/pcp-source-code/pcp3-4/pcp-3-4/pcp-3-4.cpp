// Professional C Programming
// Lesson 3: Integer Operations
// 3.4 Division/remainder
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

int main(int argc, char *argv[]) {
	signed int si1 = 5;
	signed int si2 = 7;
	unsigned int ui1 = 9;
	unsigned int ui2 = 6;

	signed int squotient = si1 / si2;
	unsigned int uquotient = ui1 / ui2;

	printf("squotient = %d.\n", squotient);
	printf("uquotient = %u.\n", uquotient);

	if (argc < 2) return EXIT_FAILURE;

	si1 = INT_MIN;
	si2 = atoi(argv[1]);
	squotient = si1 % si2 ;

	printf("squotient = %d.\n", squotient);

	return EXIT_SUCCESS;
}

