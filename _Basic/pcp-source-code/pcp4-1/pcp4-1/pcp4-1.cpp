// Professional C Programming 
// Lesson 4: Characters, Arrays, and Strings
// 4.1 Sizing arrays
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
#include <string.h>
#include <stdio.h>

void func(char *s) {
  size_t num_elem = sizeof(s) / sizeof(s[0]);	
  printf("num_elem = %Iu\n", num_elem); // %Iu is nonstandard; should be %zu
  // Number of elements equals the sizeof(char *)
  return;
}

int main(void) {
  char str[] = "Bring on the dancing horses";
  size_t num_elem = sizeof(str) / sizeof(str[0]);	
  printf("num_elem = %Iu\n", num_elem); // %Iu is nonstandard; should be %zu
  func(str);
  return EXIT_SUCCESS;
}