Normal JIT generated code
Mod05_JIT.ImageBlur2.BlurPixel(Int32, Int32)
Begin 00cd0500, size 10a

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 50:
>>> 00cd0500 55              push    ebp
00cd0501 8bec            mov     ebp,esp
00cd0503 57              push    edi
00cd0504 56              push    esi
00cd0505 53              push    ebx
00cd0506 83ec20          sub     esp,20h
00cd0509 894dd4          mov     dword ptr [ebp-2Ch],ecx
00cd050c 8955f0          mov     dword ptr [ebp-10h],edx
00cd050f 33d2            xor     edx,edx
00cd0511 8955ec          mov     dword ptr [ebp-14h],edx
00cd0514 33db            xor     ebx,ebx
00cd0516 33ff            xor     edi,edi

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 51:
00cd0518 8b45f0          mov     eax,dword ptr [ebp-10h]
00cd051b 48              dec     eax
00cd051c 8945e8          mov     dword ptr [ebp-18h],eax
00cd051f 8b55f0          mov     edx,dword ptr [ebp-10h]
00cd0522 42              inc     edx
00cd0523 3bc2            cmp     eax,edx
00cd0525 0f8d86000000    jge     00cd05b1

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 53:
00cd052b 8b4d08          mov     ecx,dword ptr [ebp+8]
00cd052e 49              dec     ecx
00cd052f 8b4508          mov     eax,dword ptr [ebp+8]
00cd0532 40              inc     eax
00cd0533 3bc8            cmp     ecx,eax
00cd0535 7d68            jge     00cd059f
00cd0537 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd053a 8b7004          mov     esi,dword ptr [eax+4]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 55:
00cd053d 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd0540 8b4010          mov     eax,dword ptr [eax+10h]
00cd0543 0faf45e8        imul    eax,dword ptr [ebp-18h]
00cd0547 03c1            add     eax,ecx
00cd0549 3b4604          cmp     eax,dword ptr [esi+4]
00cd054c 0f83b2000000    jae     00cd0604
00cd0552 8d0440          lea     eax,[eax+eax*2]
00cd0555 8d540608        lea     edx,[esi+eax+8]
00cd0559 0fb602          movzx   eax,byte ptr [edx]
00cd055c 8845e4          mov     byte ptr [ebp-1Ch],al
00cd055f 0fb64201        movzx   eax,byte ptr [edx+1]
00cd0563 8845e0          mov     byte ptr [ebp-20h],al
00cd0566 0fb64202        movzx   eax,byte ptr [edx+2]
00cd056a 8845dc          mov     byte ptr [ebp-24h],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 56:
00cd056d 8b45ec          mov     eax,dword ptr [ebp-14h]
00cd0570 0fb655e4        movzx   edx,byte ptr [ebp-1Ch]
00cd0574 03c2            add     eax,edx
00cd0576 25ffff0000      and     eax,0FFFFh
00cd057b 8945ec          mov     dword ptr [ebp-14h],eax

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 57:
00cd057e 0fb645e0        movzx   eax,byte ptr [ebp-20h]
00cd0582 03d8            add     ebx,eax
00cd0584 81e3ffff0000    and     ebx,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 58:
00cd058a 0fb645dc        movzx   eax,byte ptr [ebp-24h]
00cd058e 03f8            add     edi,eax
00cd0590 81e7ffff0000    and     edi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 53:
00cd0596 41              inc     ecx
00cd0597 8b4508          mov     eax,dword ptr [ebp+8]
00cd059a 40              inc     eax
00cd059b 3bc8            cmp     ecx,eax
00cd059d 7c9e            jl      00cd053d

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 51:
00cd059f ff45e8          inc     dword ptr [ebp-18h]
00cd05a2 8b45e8          mov     eax,dword ptr [ebp-18h]
00cd05a5 8b55f0          mov     edx,dword ptr [ebp-10h]
00cd05a8 42              inc     edx
00cd05a9 3bc2            cmp     eax,edx
00cd05ab 0f8c7affffff    jl      00cd052b

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 61:
00cd05b1 8b45ec          mov     eax,dword ptr [ebp-14h]
00cd05b4 b903000000      mov     ecx,3
00cd05b9 99              cdq
00cd05ba f7f9            idiv    eax,ecx
00cd05bc 8845d8          mov     byte ptr [ebp-28h],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 63:
00cd05bf 8bc3            mov     eax,ebx
00cd05c1 99              cdq
00cd05c2 f7f9            idiv    eax,ecx
00cd05c4 0fb6d8          movzx   ebx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 64:
00cd05c7 8bc7            mov     eax,edi
00cd05c9 99              cdq
00cd05ca f7f9            idiv    eax,ecx
00cd05cc 0fb6c8          movzx   ecx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 65:
00cd05cf 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd05d2 8b7004          mov     esi,dword ptr [eax+4]
00cd05d5 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd05d8 8b4010          mov     eax,dword ptr [eax+10h]
00cd05db 0faf45f0        imul    eax,dword ptr [ebp-10h]
00cd05df 034508          add     eax,dword ptr [ebp+8]
00cd05e2 3b4604          cmp     eax,dword ptr [esi+4]
00cd05e5 731d            jae     00cd0604
00cd05e7 8d0440          lea     eax,[eax+eax*2]
00cd05ea 8d540608        lea     edx,[esi+eax+8]
00cd05ee 0fb645d8        movzx   eax,byte ptr [ebp-28h]
00cd05f2 8802            mov     byte ptr [edx],al
00cd05f4 885a01          mov     byte ptr [edx+1],bl
00cd05f7 884a02          mov     byte ptr [edx+2],cl

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 66:
00cd05fa 8d65f4          lea     esp,[ebp-0Ch]
00cd05fd 5b              pop     ebx
00cd05fe 5e              pop     esi
00cd05ff 5f              pop     edi
00cd0600 5d              pop     ebp
00cd0601 c20400          ret     4

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur2.cs @ 50:
00cd0604 e8e6b0f673      call    clr!JIT_RngChkFail (74c3b6ef)
00cd0609 cc              int     3