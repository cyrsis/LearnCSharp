// Professional C Programming
// Lesson 3: Integer Operations
// 3.2 Addition and subtraction
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

int main(void) {
	signed int si1 = 5;
	signed int si2 = 7;

	unsigned int ui1 = 9;
	unsigned int ui2 = 6;

	signed int sresult = si1 + si2;
	unsigned int uresult = ui1 + ui2;

	printf("sresult = %d.\n", sresult);
	printf("uresult = %u.\n", uresult);

	sresult = si1 - si2;
	uresult = ui1 - ui2;

	printf("sresult = %d.\n", sresult);
	printf("uresult = %u.\n", uresult);

	return EXIT_SUCCESS;
}

