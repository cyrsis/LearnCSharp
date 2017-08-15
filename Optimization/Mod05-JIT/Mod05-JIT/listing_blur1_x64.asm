Normal JIT generated code
Mod05_JIT.ImageBlur1.BlurPixel(Int32, Int32)
Begin 00007ffc485f0370, size 13e

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 48:
>>> 00007ffc`485f0370 4157            push    r15
00007ffc`485f0372 4156            push    r14
00007ffc`485f0374 4155            push    r13
00007ffc`485f0376 4154            push    r12
00007ffc`485f0378 57              push    rdi
00007ffc`485f0379 56              push    rsi
00007ffc`485f037a 55              push    rbp
00007ffc`485f037b 53              push    rbx
00007ffc`485f037c 4883ec28        sub     rsp,28h
00007ffc`485f0380 448bca          mov     r9d,edx
00007ffc`485f0383 33c0            xor     eax,eax
00007ffc`485f0385 4533d2          xor     r10d,r10d
00007ffc`485f0388 4533db          xor     r11d,r11d

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 49:
00007ffc`485f038b 418d51ff        lea     edx,[r9-1]
00007ffc`485f038f 418d7101        lea     esi,[r9+1]
00007ffc`485f0393 3bd6            cmp     edx,esi
00007ffc`485f0395 0f8d00010000    jge     00007ffc`485f049b
00007ffc`485f039b 418d78ff        lea     edi,[r8-1]
00007ffc`485f039f 4489842480000000 mov     dword ptr [rsp+80h],r8d
00007ffc`485f03a7 418d5801        lea     ebx,[r8+1]
00007ffc`485f03ab 488b6908        mov     rbp,qword ptr [rcx+8]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 51:
00007ffc`485f03af 448bf7          mov     r14d,edi
00007ffc`485f03b2 443bf3          cmp     r14d,ebx
00007ffc`485f03b5 7d5b            jge     00007ffc`485f0412
00007ffc`485f03b7 448bfa          mov     r15d,edx
00007ffc`485f03ba 440faf791c      imul    r15d,dword ptr [rcx+1Ch]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 53:
00007ffc`485f03bf 4c8be5          mov     r12,rbp
00007ffc`485f03c2 478d2c37        lea     r13d,[r15+r14]
00007ffc`485f03c6 458b442408      mov     r8d,dword ptr [r12+8]
00007ffc`485f03cb 453be8          cmp     r13d,r8d
00007ffc`485f03ce 0f83d4000000    jae     00007ffc`485f04a8
00007ffc`485f03d4 4d63c5          movsxd  r8,r13d
00007ffc`485f03d7 4d6bc003        imul    r8,r8,3
00007ffc`485f03db 4f8d440410      lea     r8,[r12+r8+10h]
00007ffc`485f03e0 450fb620        movzx   r12d,byte ptr [r8]
00007ffc`485f03e4 450fb66801      movzx   r13d,byte ptr [r8+1]
00007ffc`485f03e9 450fb64002      movzx   r8d,byte ptr [r8+2]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 54:
00007ffc`485f03ee 4103c4          add     eax,r12d
00007ffc`485f03f1 25ffff0000      and     eax,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 55:
00007ffc`485f03f6 4503d5          add     r10d,r13d
00007ffc`485f03f9 4181e2ffff0000  and     r10d,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 56:
00007ffc`485f0400 4503d8          add     r11d,r8d
00007ffc`485f0403 4181e3ffff0000  and     r11d,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 51:
00007ffc`485f040a 41ffc6          inc     r14d
00007ffc`485f040d 443bf3          cmp     r14d,ebx
00007ffc`485f0410 7cad            jl      00007ffc`485f03bf

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 49:
00007ffc`485f0412 ffc2            inc     edx
00007ffc`485f0414 3bd6            cmp     edx,esi
00007ffc`485f0416 7c97            jl      00007ffc`485f03af

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 59:
00007ffc`485f0418 ba56555555      mov     edx,55555556h
00007ffc`485f041d f7ea            imul    edx
00007ffc`485f041f 8bc2            mov     eax,edx
00007ffc`485f0421 8bd0            mov     edx,eax
00007ffc`485f0423 c1ea1f          shr     edx,1Fh
00007ffc`485f0426 03c2            add     eax,edx
00007ffc`485f0428 440fb6c0        movzx   r8d,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 61:
00007ffc`485f042c b856555555      mov     eax,55555556h
00007ffc`485f0431 41f7ea          imul    r10d
00007ffc`485f0434 8bc2            mov     eax,edx
00007ffc`485f0436 8bd0            mov     edx,eax
00007ffc`485f0438 c1ea1f          shr     edx,1Fh
00007ffc`485f043b 03c2            add     eax,edx
00007ffc`485f043d 440fb6d0        movzx   r10d,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 62:
00007ffc`485f0441 b856555555      mov     eax,55555556h
00007ffc`485f0446 41f7eb          imul    r11d
00007ffc`485f0449 8bc2            mov     eax,edx
00007ffc`485f044b 8be8            mov     ebp,eax
00007ffc`485f044d 8bc5            mov     eax,ebp
00007ffc`485f044f c1e81f          shr     eax,1Fh
00007ffc`485f0452 03c5            add     eax,ebp
00007ffc`485f0454 25ff000000      and     eax,0FFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 63:
00007ffc`485f0459 488b6908        mov     rbp,qword ptr [rcx+8]
00007ffc`485f045d 418bd1          mov     edx,r9d
00007ffc`485f0460 0faf511c        imul    edx,dword ptr [rcx+1Ch]
00007ffc`485f0464 8b8c2480000000  mov     ecx,dword ptr [rsp+80h]
00007ffc`485f046b 03d1            add     edx,ecx
00007ffc`485f046d 8b4d08          mov     ecx,dword ptr [rbp+8]
00007ffc`485f0470 3bd1            cmp     edx,ecx
00007ffc`485f0472 7334            jae     00007ffc`485f04a8
00007ffc`485f0474 4863d2          movsxd  rdx,edx
00007ffc`485f0477 486bd203        imul    rdx,rdx,3
00007ffc`485f047b 488d541510      lea     rdx,[rbp+rdx+10h]
00007ffc`485f0480 448802          mov     byte ptr [rdx],r8b
00007ffc`485f0483 44885201        mov     byte ptr [rdx+1],r10b
00007ffc`485f0487 884202          mov     byte ptr [rdx+2],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 64:
00007ffc`485f048a 4883c428        add     rsp,28h
00007ffc`485f048e 5b              pop     rbx
00007ffc`485f048f 5d              pop     rbp
00007ffc`485f0490 5e              pop     rsi
00007ffc`485f0491 5f              pop     rdi
00007ffc`485f0492 415c            pop     r12
00007ffc`485f0494 415d            pop     r13
00007ffc`485f0496 415e            pop     r14
00007ffc`485f0498 415f            pop     r15
00007ffc`485f049a c3              ret

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 48:
00007ffc`485f049b 4489842480000000 mov     dword ptr [rsp+80h],r8d
00007ffc`485f04a3 e970ffffff      jmp     00007ffc`485f0418
00007ffc`485f04a8 e8e360b35f      call    clr!JIT_RngChkFail (00007ffc`a8126590)
00007ffc`485f04ad cc              int     3
