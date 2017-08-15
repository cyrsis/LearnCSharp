Normal JIT generated code
Mod05_JIT.ImageBlur3.BlurPixel(Int32, Int32)
Begin 00cd0700, size 118

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 50:
>>> 00cd0700 55              push    ebp
00cd0701 8bec            mov     ebp,esp
00cd0703 57              push    edi
00cd0704 56              push    esi
00cd0705 53              push    ebx
00cd0706 83ec24          sub     esp,24h
00cd0709 894dd8          mov     dword ptr [ebp-28h],ecx
00cd070c 8955f0          mov     dword ptr [ebp-10h],edx
00cd070f 33ff            xor     edi,edi
00cd0711 33db            xor     ebx,ebx
00cd0713 895dec          mov     dword ptr [ebp-14h],ebx

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 52:
00cd0716 8b45d8          mov     eax,dword ptr [ebp-28h]
00cd0719 8b4004          mov     eax,dword ptr [eax+4]
00cd071c 8945d4          mov     dword ptr [ebp-2Ch],eax

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 53:
00cd071f 8b45d8          mov     eax,dword ptr [ebp-28h]
00cd0722 8b4010          mov     eax,dword ptr [eax+10h]
00cd0725 8945e8          mov     dword ptr [ebp-18h],eax

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 54:
00cd0728 8b45f0          mov     eax,dword ptr [ebp-10h]
00cd072b 48              dec     eax
00cd072c 8945e4          mov     dword ptr [ebp-1Ch],eax
00cd072f 8b55f0          mov     edx,dword ptr [ebp-10h]
00cd0732 42              inc     edx
00cd0733 3bc2            cmp     eax,edx
00cd0735 7d7a            jge     00cd07b1

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 56:
00cd0737 8b4d08          mov     ecx,dword ptr [ebp+8]
00cd073a 49              dec     ecx
00cd073b 8b4508          mov     eax,dword ptr [ebp+8]
00cd073e 40              inc     eax
00cd073f 3bc8            cmp     ecx,eax
00cd0741 7d60            jge     00cd07a3
00cd0743 8b45d4          mov     eax,dword ptr [ebp-2Ch]
00cd0746 8b7004          mov     esi,dword ptr [eax+4]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 58:
00cd0749 8b45e4          mov     eax,dword ptr [ebp-1Ch]
00cd074c 0faf45e8        imul    eax,dword ptr [ebp-18h]
00cd0750 03c1            add     eax,ecx
00cd0752 8b55d4          mov     edx,dword ptr [ebp-2Ch]
00cd0755 3bc6            cmp     eax,esi
00cd0757 0f83b5000000    jae     00cd0812
00cd075d 8d0440          lea     eax,[eax+eax*2]
00cd0760 8d540208        lea     edx,[edx+eax+8]
00cd0764 0fb602          movzx   eax,byte ptr [edx]
00cd0767 8845e0          mov     byte ptr [ebp-20h],al
00cd076a 0fb64201        movzx   eax,byte ptr [edx+1]
00cd076e 8845dc          mov     byte ptr [ebp-24h],al
00cd0771 0fb65202        movzx   edx,byte ptr [edx+2]

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 59:
00cd0775 0fb645e0        movzx   eax,byte ptr [ebp-20h]
00cd0779 03f8            add     edi,eax
00cd077b 81e7ffff0000    and     edi,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 60:
00cd0781 0fb645dc        movzx   eax,byte ptr [ebp-24h]
00cd0785 03d8            add     ebx,eax
00cd0787 81e3ffff0000    and     ebx,0FFFFh

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 61:
00cd078d 8b45ec          mov     eax,dword ptr [ebp-14h]
00cd0790 03c2            add     eax,edx
00cd0792 25ffff0000      and     eax,0FFFFh
00cd0797 8945ec          mov     dword ptr [ebp-14h],eax

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 56:
00cd079a 41              inc     ecx
00cd079b 8b4508          mov     eax,dword ptr [ebp+8]
00cd079e 40              inc     eax
00cd079f 3bc8            cmp     ecx,eax
00cd07a1 7ca6            jl      00cd0749

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 54:
00cd07a3 ff45e4          inc     dword ptr [ebp-1Ch]
00cd07a6 8b45e4          mov     eax,dword ptr [ebp-1Ch]
00cd07a9 8b55f0          mov     edx,dword ptr [ebp-10h]
00cd07ac 42              inc     edx
00cd07ad 3bc2            cmp     eax,edx
00cd07af 7c86            jl      00cd0737

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 64:
00cd07b1 be03000000      mov     esi,3
00cd07b6 8bc7            mov     eax,edi
00cd07b8 99              cdq
00cd07b9 f7fe            idiv    eax,esi
00cd07bb 0fb6f0          movzx   esi,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 66:
00cd07be b803000000      mov     eax,3
00cd07c3 8945d0          mov     dword ptr [ebp-30h],eax
00cd07c6 8bc3            mov     eax,ebx
00cd07c8 99              cdq
00cd07c9 8b4dd0          mov     ecx,dword ptr [ebp-30h]
00cd07cc f7f9            idiv    eax,ecx
00cd07ce 0fb6d8          movzx   ebx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 67:
00cd07d1 8b45ec          mov     eax,dword ptr [ebp-14h]
00cd07d4 b903000000      mov     ecx,3
00cd07d9 99              cdq
00cd07da f7f9            idiv    eax,ecx
00cd07dc 0fb6c8          movzx   ecx,al

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 68:
00cd07df 8b45d8          mov     eax,dword ptr [ebp-28h]
00cd07e2 8b4004          mov     eax,dword ptr [eax+4]
00cd07e5 8b55d8          mov     edx,dword ptr [ebp-28h]
00cd07e8 8b5210          mov     edx,dword ptr [edx+10h]
00cd07eb 0faf55f0        imul    edx,dword ptr [ebp-10h]
00cd07ef 035508          add     edx,dword ptr [ebp+8]
00cd07f2 3b5004          cmp     edx,dword ptr [eax+4]
00cd07f5 731b            jae     00cd0812
00cd07f7 8d1452          lea     edx,[edx+edx*2]
00cd07fa 8d541008        lea     edx,[eax+edx+8]
00cd07fe 8bc6            mov     eax,esi
00cd0800 8802            mov     byte ptr [edx],al
00cd0802 885a01          mov     byte ptr [edx+1],bl
00cd0805 884a02          mov     byte ptr [edx+2],cl

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 69:
00cd0808 8d65f4          lea     esp,[ebp-0Ch]
00cd080b 5b              pop     ebx
00cd080c 5e              pop     esi
00cd080d 5f              pop     edi
00cd080e 5d              pop     ebp
00cd080f c20400          ret     4

w:\Pluralsight\MakingNetAppsEvenFaster\Code\Mod05-JIT\Mod05-JIT\ImageBlur3.cs @ 50:
00cd0812 e8d8aef673      call    clr!JIT_RngChkFail (74c3b6ef)
00cd0817 cc              int     3
