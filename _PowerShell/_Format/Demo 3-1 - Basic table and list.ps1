#
#   Demo 3-1
#   Basic table/list formatting
#
#
###
#
#
#    Default table handling using pre-defined view
# Notepad; notepad; # start instances of notepad
Get-Process -Name Notepad 
#
#    Create list - note different properties listed
Get-Process -Name Notepad | Format-List 
#
#    Look at default table vs list decision
#    Display objects with just 4 properties
Get-Process -Name Notepad | select name,handles,cpu,company
#    Now display same objects but with 5 properties
Get-Process -Name Notepad | select name,handles,cpu,threads,company
#
#  Look at use of -Autosize
Get-Process -Name Notepad | select name,handles,cpu,company | Format-Table
Get-Process -Name Notepad | select name,handles,cpu,company | Format-Table -AutoSize

