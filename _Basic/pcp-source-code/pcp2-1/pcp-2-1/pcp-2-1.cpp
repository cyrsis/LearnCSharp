// Professional C Programming
// Lesson 2: Integer Conversions
// 2.1 Conversion rank, promotions, and the usual arithmetic conversions
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

void signed_char_expression(void);
void complement_unsigned_char(void);

int main(void) {
	signed_char_expression();
	complement_unsigned_char();

	return EXIT_SUCCESS;
}

void signed_char_expression(void) {
	signed char c1 = 100; 
	signed char c2 = 3;
	signed char c3 = 4;

	signed char cresult = c1 * c2 / c3;
	//                 = 100 * 3 / 4
	//                 = 300 / 4

	printf("cresult = %d.\n", cresult);

	return;
}

void complement_unsigned_char(void) {
	unsigned char uc = UCHAR_MAX; // 0xFF
	int i = ~uc;

	printf("i = %d.\n", i);
}