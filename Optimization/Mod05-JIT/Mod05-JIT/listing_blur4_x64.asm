Normal JIT generated code
Mod05_JIT.ImageBlur4.BlurPixel(Int32, Int32)
Begin 00007ff8d5700790, size 1b6

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 50:
>>> 00007ff8`d5700790 53              push    rbx
00007ff8`d5700791 55              push    rbp
00007ff8`d5700792 56              push    rsi
00007ff8`d5700793 57              push    rdi
00007ff8`d5700794 4154            push    r12
00007ff8`d5700796 4155            push    r13
00007ff8`d5700798 4156            push    r14
00007ff8`d570079a 4157            push    r15
00007ff8`d570079c 4883ec48        sub     rsp,48h
00007ff8`d57007a0 418be8          mov     ebp,r8d
00007ff8`d57007a3 448bd2          mov     r10d,edx
00007ff8`d57007a6 488bd9          mov     rbx,rcx
00007ff8`d57007a9 48c744242800000000 mov   qword ptr [rsp+28h],0
00007ff8`d57007b2 33c0            xor     eax,eax
00007ff8`d57007b4 6689442420      mov     word ptr [rsp+20h],ax
00007ff8`d57007b9 88442422        mov     byte ptr [rsp+22h],al
00007ff8`d57007bd 664533db        xor     r11w,r11w
00007ff8`d57007c1 66458bfb        mov     r15w,r11w
00007ff8`d57007c5 66458bc3        mov     r8w,r11w

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 51:
00007ff8`d57007c9 418d7aff        lea     edi,[r10-1]
00007ff8`d57007cd 418d7201        lea     esi,[r10+1]
00007ff8`d57007d1 3bfe            cmp     edi,esi
00007ff8`d57007d3 0f8dd2000000    jge     00007ff8`d57008ab

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 54:
00007ff8`d57007d9 488b4b08        mov     rcx,qword ptr [rbx+8]
00007ff8`d57007dd 448b6b1c        mov     r13d,dword ptr [rbx+1Ch]
00007ff8`d57007e1 8bc7            mov     eax,edi
00007ff8`d57007e3 410fafc5        imul    eax,r13d
00007ff8`d57007e7 448d2428        lea     r12d,[rax+rbp]
00007ff8`d57007eb 4c8b7108        mov     r14,qword ptr [rcx+8]
00007ff8`d57007ef 488d5110        lea     rdx,[rcx+10h]
00007ff8`d57007f3 4889542430      mov     qword ptr [rsp+30h],rdx
00007ff8`d57007f8 8bc6            mov     eax,esi
00007ff8`d57007fa 410fafc5        imul    eax,r13d
00007ff8`d57007fe 6690            xchg    ax,ax
00007ff8`d5700800 418d4424ff      lea     eax,[r12-1]
00007ff8`d5700805 4863c8          movsxd  rcx,eax
00007ff8`d5700808 493bce          cmp     rcx,r14
00007ff8`d570080b 0f832f010000    jae     00007ff8`d5700940
00007ff8`d5700811 488d0449        lea     rax,[rcx+rcx*2]
00007ff8`d5700815 488bca          mov     rcx,rdx
00007ff8`d5700818 4803c8          add     rcx,rax
00007ff8`d570081b 48894c2428      mov     qword ptr [rsp+28h],rcx

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 56:
00007ff8`d5700820 4c8b4c2428      mov     r9,qword ptr [rsp+28h]

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 58:
00007ff8`d5700825 410fb7cb        movzx   ecx,r11w
00007ff8`d5700829 410fb601        movzx   eax,byte ptr [r9]
00007ff8`d570082d 03c8            add     ecx,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 59:
00007ff8`d570082f 410fb7d7        movzx   edx,r15w
00007ff8`d5700833 410fb64101      movzx   eax,byte ptr [r9+1]
00007ff8`d5700838 03d0            add     edx,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 60:
00007ff8`d570083a 450fb7c0        movzx   r8d,r8w
00007ff8`d570083e 410fb64102      movzx   eax,byte ptr [r9+2]
00007ff8`d5700843 4403c0          add     r8d,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 61:
00007ff8`d5700846 4983c103        add     r9,3

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 63:
00007ff8`d570084a 0fb7c9          movzx   ecx,cx
00007ff8`d570084d 410fb601        movzx   eax,byte ptr [r9]
00007ff8`d5700851 03c8            add     ecx,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 64:
00007ff8`d5700853 0fb7d2          movzx   edx,dx
00007ff8`d5700856 410fb64101      movzx   eax,byte ptr [r9+1]
00007ff8`d570085b 03d0            add     edx,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 65:
00007ff8`d570085d 450fb7c0        movzx   r8d,r8w
00007ff8`d5700861 410fb64102      movzx   eax,byte ptr [r9+2]
00007ff8`d5700866 4403c0          add     r8d,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 66:
00007ff8`d5700869 4983c103        add     r9,3

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 68:
00007ff8`d570086d 440fb7d9        movzx   r11d,cx
00007ff8`d5700871 410fb601        movzx   eax,byte ptr [r9]
00007ff8`d5700875 4403d8          add     r11d,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 69:
00007ff8`d5700878 440fb7fa        movzx   r15d,dx
00007ff8`d570087c 410fb64101      movzx   eax,byte ptr [r9+1]
00007ff8`d5700881 4403f8          add     r15d,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 70:
00007ff8`d5700884 450fb7c0        movzx   r8d,r8w
00007ff8`d5700888 410fb64102      movzx   eax,byte ptr [r9+2]
00007ff8`d570088d 4403c0          add     r8d,eax

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 51:
00007ff8`d5700890 48c744242800000000 mov   qword ptr [rsp+28h],0
00007ff8`d5700899 ffc7            inc     edi
00007ff8`d570089b 4503e5          add     r12d,r13d
00007ff8`d570089e 3bfe            cmp     edi,esi
00007ff8`d57008a0 488b542430      mov     rdx,qword ptr [rsp+30h]
00007ff8`d57008a5 0f8c55ffffff    jl      00007ff8`d5700800

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 73:
00007ff8`d57008ab 33c0            xor     eax,eax
00007ff8`d57008ad 6689442420      mov     word ptr [rsp+20h],ax
00007ff8`d57008b2 88442422        mov     byte ptr [rsp+22h],al

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 74:
00007ff8`d57008b6 410fb7cb        movzx   ecx,r11w
00007ff8`d57008ba b856555555      mov     eax,55555556h
00007ff8`d57008bf f7e9            imul    ecx
00007ff8`d57008c1 8bc2            mov     eax,edx
00007ff8`d57008c3 c1e81f          shr     eax,1Fh
00007ff8`d57008c6 03d0            add     edx,eax
00007ff8`d57008c8 88542420        mov     byte ptr [rsp+20h],dl

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 75:
00007ff8`d57008cc 410fb7cf        movzx   ecx,r15w
00007ff8`d57008d0 b856555555      mov     eax,55555556h
00007ff8`d57008d5 f7e9            imul    ecx
00007ff8`d57008d7 8bc2            mov     eax,edx
00007ff8`d57008d9 c1e81f          shr     eax,1Fh
00007ff8`d57008dc 03d0            add     edx,eax
00007ff8`d57008de 88542421        mov     byte ptr [rsp+21h],dl

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 76:
00007ff8`d57008e2 410fb7c8        movzx   ecx,r8w
00007ff8`d57008e6 b856555555      mov     eax,55555556h
00007ff8`d57008eb f7e9            imul    ecx
00007ff8`d57008ed 8bc2            mov     eax,edx
00007ff8`d57008ef c1e81f          shr     eax,1Fh
00007ff8`d57008f2 03d0            add     edx,eax
00007ff8`d57008f4 88542422        mov     byte ptr [rsp+22h],dl

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 77:
00007ff8`d57008f8 488b4b08        mov     rcx,qword ptr [rbx+8]
00007ff8`d57008fc 8b431c          mov     eax,dword ptr [rbx+1Ch]
00007ff8`d57008ff 440fafd0        imul    r10d,eax
00007ff8`d5700903 4403d5          add     r10d,ebp
00007ff8`d5700906 4963d2          movsxd  rdx,r10d
00007ff8`d5700909 488b4108        mov     rax,qword ptr [rcx+8]
00007ff8`d570090d 483bd0          cmp     rdx,rax
00007ff8`d5700910 732e            jae     00007ff8`d5700940
00007ff8`d5700912 4803ca          add     rcx,rdx
00007ff8`d5700915 4c8d442420      lea     r8,[rsp+20h]
00007ff8`d570091a 66418b00        mov     ax,word ptr [r8]
00007ff8`d570091e 6689445110      mov     word ptr [rcx+rdx*2+10h],ax
00007ff8`d5700923 418a4002        mov     al,byte ptr [r8+2]
00007ff8`d5700927 88445112        mov     byte ptr [rcx+rdx*2+12h],al
00007ff8`d570092b 4883c448        add     rsp,48h
00007ff8`d570092f 415f            pop     r15
00007ff8`d5700931 415e            pop     r14
00007ff8`d5700933 415d            pop     r13
00007ff8`d5700935 415c            pop     r12
00007ff8`d5700937 5f              pop     rdi
00007ff8`d5700938 5e              pop     rsi
00007ff8`d5700939 5d              pop     rbp
00007ff8`d570093a 5b              pop     rbx
00007ff8`d570093b c3              ret

W:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBLur4.cs @ 50:
00007ff8`d570093c 0f1f4000        nop     dword ptr [rax]
00007ff8`d5700940 e84b5cb05f      call    clr!JIT_RngChkFail (00007ff9`35206590)
00007ff8`d5700945 90              nop
