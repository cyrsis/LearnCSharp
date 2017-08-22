###
#
#
#    Demo 6-1 Out-* cmdlets
#
###
#
#    Out-File
#
##
# Start some notepads
notepad;notepad
# Generat adn compate output
Get-Process Notepad
Get-Process Notepad | Out-File c:\foo\d1out.txt
cat c:\foo\d1out.txt
cls
##
#    Out-Printer
#    
##
ps notepad
ps notepad | out-printer snagit
cls
##
#    Out-String
#
##
$i = Get-Process -Name Notepad | Out-String
$i.GetType()
$i.Length
cls
##
#    Out-Null
#
##
New-PsDrive -name foo1  -PsProvider FileSystem -Root c:\foo
New-PsDrive -name foo2  -PsProvider FileSystem -Root c:\foo | out-null
Get-PSDrive -Name foo?
cls
##
#    Out-Default/Out-Host
Out-Default -?
Get-Process Notepad
Get-Process Notepad | Out-Default
Get-Process Notepad | Out-Host -Paging
cls
#    Out-String
#
Get-Service | Format-Table -Property * 
Get-Service | Format-Table -Property * -auto

Get-Service | 
  Format-Table -Property * -auto |
  Out-String -width 25000 | 
  Out-File c:\foo\foo1.txt
Notepad c:\foo\foo1.txt