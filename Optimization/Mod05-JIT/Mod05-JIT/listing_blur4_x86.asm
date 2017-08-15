Normal JIT generated code
Mod05_JIT.ImageBlur4.BlurPixel(Int32, Int32)
Begin 013504b0, size 13d

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 50:
>>> 013504b0 55              push    ebp
013504b1 8bec            mov     ebp,esp
013504b3 57              push    edi
013504b4 56              push    esi
013504b5 53              push    ebx
013504b6 83ec14          sub     esp,14h
013504b9 33c0            xor     eax,eax
013504bb 8945e8          mov     dword ptr [ebp-18h],eax
013504be 894de0          mov     dword ptr [ebp-20h],ecx
013504c1 8955f0          mov     dword ptr [ebp-10h],edx
013504c4 33db            xor     ebx,ebx
013504c6 33ff            xor     edi,edi
013504c8 33f6            xor     esi,esi

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 51:
013504ca 8b45f0          mov     eax,dword ptr [ebp-10h]
013504cd 48              dec     eax
013504ce 8945ec          mov     dword ptr [ebp-14h],eax
013504d1 8b55f0          mov     edx,dword ptr [ebp-10h]
013504d4 42              inc     edx
013504d5 3bc2            cmp     eax,edx
013504d7 0f8db6000000    jge     01350593
013504dd 8b45e0          mov     eax,dword ptr [ebp-20h]
013504e0 8b4804          mov     ecx,dword ptr [eax+4]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 54:
013504e3 8b45e0          mov     eax,dword ptr [ebp-20h]
013504e6 8b4010          mov     eax,dword ptr [eax+10h]
013504e9 8b55f0          mov     edx,dword ptr [ebp-10h]
013504ec 4a              dec     edx
013504ed 0fafc2          imul    eax,edx
013504f0 8b5508          mov     edx,dword ptr [ebp+8]
013504f3 8d4410ff        lea     eax,[eax+edx-1]
013504f7 3b4104          cmp     eax,dword ptr [ecx+4]
013504fa 0f83e7000000    jae     013505e7
01350500 8d0440          lea     eax,[eax+eax*2]
01350503 8d440108        lea     eax,[ecx+eax+8]
01350507 8945e8          mov     dword ptr [ebp-18h],eax

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 56:
0135050a 8b55e8          mov     edx,dword ptr [ebp-18h]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 58:
0135050d 0fb602          movzx   eax,byte ptr [edx]
01350510 03d8            add     ebx,eax
01350512 81e3ffff0000    and     ebx,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 59:
01350518 0fb64201        movzx   eax,byte ptr [edx+1]
0135051c 03f8            add     edi,eax
0135051e 81e7ffff0000    and     edi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 60:
01350524 0fb64202        movzx   eax,byte ptr [edx+2]
01350528 03f0            add     esi,eax
0135052a 81e6ffff0000    and     esi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 61:
01350530 83c203          add     edx,3

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 63:
01350533 0fb602          movzx   eax,byte ptr [edx]
01350536 03d8            add     ebx,eax
01350538 81e3ffff0000    and     ebx,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 64:
0135053e 0fb64201        movzx   eax,byte ptr [edx+1]
01350542 03f8            add     edi,eax
01350544 81e7ffff0000    and     edi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 65:
0135054a 0fb64202        movzx   eax,byte ptr [edx+2]
0135054e 03f0            add     esi,eax
01350550 81e6ffff0000    and     esi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 66:
01350556 83c203          add     edx,3

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 68:
01350559 0fb602          movzx   eax,byte ptr [edx]
0135055c 03d8            add     ebx,eax
0135055e 81e3ffff0000    and     ebx,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 69:
01350564 0fb64201        movzx   eax,byte ptr [edx+1]
01350568 03f8            add     edi,eax
0135056a 81e7ffff0000    and     edi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 70:
01350570 0fb64202        movzx   eax,byte ptr [edx+2]
01350574 03f0            add     esi,eax
01350576 81e6ffff0000    and     esi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 51:
0135057c 33d2            xor     edx,edx
0135057e 8955e8          mov     dword ptr [ebp-18h],edx
01350581 ff45ec          inc     dword ptr [ebp-14h]
01350584 8b45ec          mov     eax,dword ptr [ebp-14h]
01350587 8b55f0          mov     edx,dword ptr [ebp-10h]
0135058a 42              inc     edx
0135058b 3bc2            cmp     eax,edx
0135058d 0f8c50ffffff    jl      013504e3

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 73:
01350593 b903000000      mov     ecx,3
01350598 8bc3            mov     eax,ebx
0135059a 99              cdq
0135059b f7f9            idiv    eax,ecx
0135059d 8845e4          mov     byte ptr [ebp-1Ch],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 75:
013505a0 8bc7            mov     eax,edi
013505a2 99              cdq
013505a3 f7f9            idiv    eax,ecx
013505a5 0fb6d8          movzx   ebx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 76:
013505a8 8bc6            mov     eax,esi
013505aa 99              cdq
013505ab f7f9            idiv    eax,ecx
013505ad 0fb6f0          movzx   esi,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 77:
013505b0 8b45e0          mov     eax,dword ptr [ebp-20h]
013505b3 8b4804          mov     ecx,dword ptr [eax+4]
013505b6 8b45e0          mov     eax,dword ptr [ebp-20h]
013505b9 8b4010          mov     eax,dword ptr [eax+10h]
013505bc 0faf45f0        imul    eax,dword ptr [ebp-10h]
013505c0 034508          add     eax,dword ptr [ebp+8]
013505c3 3b4104          cmp     eax,dword ptr [ecx+4]
013505c6 731f            jae     013505e7
013505c8 8d0440          lea     eax,[eax+eax*2]
013505cb 8d540108        lea     edx,[ecx+eax+8]
013505cf 0fb645e4        movzx   eax,byte ptr [ebp-1Ch]
013505d3 8802            mov     byte ptr [edx],al
013505d5 885a01          mov     byte ptr [edx+1],bl
013505d8 8bc6            mov     eax,esi
013505da 884202          mov     byte ptr [edx+2],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 78:
013505dd 8d65f4          lea     esp,[ebp-0Ch]
013505e0 5b              pop     ebx
013505e1 5e              pop     esi
013505e2 5f              pop     edi
013505e3 5d              pop     ebp
013505e4 c20400          ret     4

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur4.cs @ 50:
013505e7 e803b11773      call    clr!JIT_RngChkFail (744cb6ef)
013505ec cc              int     3
