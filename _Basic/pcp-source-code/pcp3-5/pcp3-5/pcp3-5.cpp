// Professional C Programming
// Lesson 3: Integer Operations
// 3.5 Shifting
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

int signed_left_shift(int si1, int si2);
int signed_right_shift(int si1, int si2);
unsigned int unsigned_right_shift(unsigned int ui1, unsigned ui2);
unsigned int unsigned_left_shift(unsigned int ui1, unsigned ui2);

int main(void) {
	unsigned int ushift;
	int stringify = INT_MIN;
	char buf[sizeof("256")];

	// signed right shift operator
	int sshift = stringify >> 24;
	sprintf(buf, "%u", sshift);

	// "safe" signed right shift function
	sshift = signed_right_shift(stringify, 24);
	sprintf(buf, "%u", sshift);

	// unsigned right shift
	ushift = unsigned_right_shift(stringify, 24);
	sprintf(buf, "%u", ushift);

	return EXIT_SUCCESS;
}

int signed_left_shift(int si1, int si2) {
	// The CHAR_BIT macro defines the number of bits for smallest object 
	// that is not a bit-field (byte). 
	if ( (si1 < 0) || (si2 < 0) ||  // Left and right operands must be nonnegative
		(si2 >= sizeof(int) * CHAR_BIT) || // Limit # bits shifted
		si1 > (INT_MAX >> si2) ) // Result must be representable
	{
		fprintf(stderr, "UB in signed left shift %d << %d.\n", si1, si2);
	}
	return si1 << si2;
}

int signed_right_shift(int si1, int si2) {
	if ( (si2 < 0) || // Right operand must be nonnegative
		(si2 >= sizeof(int) * CHAR_BIT) )  // Limit # bits shifted
	{
		fprintf(stderr, "UB in signed right shift %d >> %d.\n", si1, si2);
	}
	return si1 >> si2;
}

unsigned int unsigned_right_shift(unsigned int ui1, unsigned ui2) {
	if (ui2 >= sizeof(unsigned int) * CHAR_BIT) { // Limit # bits shifted
		fprintf(stderr, "UB in unsigned right shift %d >> %d.\n", ui1, ui2);
	}
	return ui1 >> ui2;
}

unsigned int unsigned_left_shift(unsigned int ui1, unsigned ui2) {
	if (ui2 >= sizeof(unsigned int) * CHAR_BIT) { // Limit # bits shifted
		fprintf(stderr, "UB in unsigned left shift %d << %d.\n", ui1, ui2);
	}
	return ui1 << ui2;
}