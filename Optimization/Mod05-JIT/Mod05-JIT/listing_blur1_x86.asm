Normal JIT generated code
Mod05_JIT.ImageBlur1.BlurPixel(Int32, Int32)
Begin 00cd0300, size 10a

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 48:
>>> 00cd0300 55              push    ebp
00cd0301 8bec            mov     ebp,esp
00cd0303 57              push    edi
00cd0304 56              push    esi
00cd0305 53              push    ebx
00cd0306 83ec20          sub     esp,20h
00cd0309 894dd4          mov     dword ptr [ebp-2Ch],ecx
00cd030c 8955f0          mov     dword ptr [ebp-10h],edx
00cd030f 33d2            xor     edx,edx
00cd0311 8955ec          mov     dword ptr [ebp-14h],edx
00cd0314 33db            xor     ebx,ebx
00cd0316 33ff            xor     edi,edi

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 49:
00cd0318 8b45f0          mov     eax,dword ptr [ebp-10h]
00cd031b 48              dec     eax
00cd031c 8945e8          mov     dword ptr [ebp-18h],eax
00cd031f 8b55f0          mov     edx,dword ptr [ebp-10h]
00cd0322 42              inc     edx
00cd0323 3bc2            cmp     eax,edx
00cd0325 0f8d86000000    jge     00cd03b1

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 51:
00cd032b 8b4d08          mov     ecx,dword ptr [ebp+8]
00cd032e 49              dec     ecx
00cd032f 8b4508          mov     eax,dword ptr [ebp+8]
00cd0332 40              inc     eax
00cd0333 3bc8            cmp     ecx,eax
00cd0335 7d68            jge     00cd039f
00cd0337 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd033a 8b7004          mov     esi,dword ptr [eax+4]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 53:
00cd033d 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd0340 8b4010          mov     eax,dword ptr [eax+10h]
00cd0343 0faf45e8        imul    eax,dword ptr [ebp-18h]
00cd0347 03c1            add     eax,ecx
00cd0349 3b4604          cmp     eax,dword ptr [esi+4]
00cd034c 0f83b2000000    jae     00cd0404
00cd0352 8d0440          lea     eax,[eax+eax*2]
00cd0355 8d540608        lea     edx,[esi+eax+8]
00cd0359 0fb602          movzx   eax,byte ptr [edx]
00cd035c 8845e4          mov     byte ptr [ebp-1Ch],al
00cd035f 0fb64201        movzx   eax,byte ptr [edx+1]
00cd0363 8845e0          mov     byte ptr [ebp-20h],al
00cd0366 0fb64202        movzx   eax,byte ptr [edx+2]
00cd036a 8845dc          mov     byte ptr [ebp-24h],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 54:
00cd036d 8b45ec          mov     eax,dword ptr [ebp-14h]
00cd0370 0fb655e4        movzx   edx,byte ptr [ebp-1Ch]
00cd0374 03c2            add     eax,edx
00cd0376 25ffff0000      and     eax,0FFFFh
00cd037b 8945ec          mov     dword ptr [ebp-14h],eax

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 55:
00cd037e 0fb645e0        movzx   eax,byte ptr [ebp-20h]
00cd0382 03d8            add     ebx,eax
00cd0384 81e3ffff0000    and     ebx,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 56:
00cd038a 0fb645dc        movzx   eax,byte ptr [ebp-24h]
00cd038e 03f8            add     edi,eax
00cd0390 81e7ffff0000    and     edi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 51:
00cd0396 41              inc     ecx
00cd0397 8b4508          mov     eax,dword ptr [ebp+8]
00cd039a 40              inc     eax
00cd039b 3bc8            cmp     ecx,eax
00cd039d 7c9e            jl      00cd033d

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 49:
00cd039f ff45e8          inc     dword ptr [ebp-18h]
00cd03a2 8b45e8          mov     eax,dword ptr [ebp-18h]
00cd03a5 8b55f0          mov     edx,dword ptr [ebp-10h]
00cd03a8 42              inc     edx
00cd03a9 3bc2            cmp     eax,edx
00cd03ab 0f8c7affffff    jl      00cd032b

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 59:
00cd03b1 8b45ec          mov     eax,dword ptr [ebp-14h]
00cd03b4 b903000000      mov     ecx,3
00cd03b9 99              cdq
00cd03ba f7f9            idiv    eax,ecx
00cd03bc 8845d8          mov     byte ptr [ebp-28h],al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 61:
00cd03bf 8bc3            mov     eax,ebx
00cd03c1 99              cdq
00cd03c2 f7f9            idiv    eax,ecx
00cd03c4 0fb6d8          movzx   ebx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 62:
00cd03c7 8bc7            mov     eax,edi
00cd03c9 99              cdq
00cd03ca f7f9            idiv    eax,ecx
00cd03cc 0fb6c8          movzx   ecx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 63:
00cd03cf 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd03d2 8b7004          mov     esi,dword ptr [eax+4]
00cd03d5 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd03d8 8b4010          mov     eax,dword ptr [eax+10h]
00cd03db 0faf45f0        imul    eax,dword ptr [ebp-10h]
00cd03df 034508          add     eax,dword ptr [ebp+8]
00cd03e2 3b4604          cmp     eax,dword ptr [esi+4]
00cd03e5 731d            jae     00cd0404
00cd03e7 8d0440          lea     eax,[eax+eax*2]
00cd03ea 8d540608        lea     edx,[esi+eax+8]
00cd03ee 0fb645d8        movzx   eax,byte ptr [ebp-28h]
00cd03f2 8802            mov     byte ptr [edx],al
00cd03f4 885a01          mov     byte ptr [edx+1],bl
00cd03f7 884a02          mov     byte ptr [edx+2],cl

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 64:
00cd03fa 8d65f4          lea     esp,[ebp-0Ch]
00cd03fd 5b              pop     ebx
00cd03fe 5e              pop     esi
00cd03ff 5f              pop     edi
00cd0400 5d              pop     ebp
00cd0401 c20400          ret     4

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur1.cs @ 48:
00cd0404 e8e6b2f673      call    clr!JIT_RngChkFail (74c3b6ef)
00cd0409 cc              int     3
