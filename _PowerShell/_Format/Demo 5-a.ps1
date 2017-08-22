#
#
#    Demo 5-1
#
#
#
#  Using Out-File/Out-Printer
GPS | out-file c:\foo\gps.txt
Get-Content  c:\foo\gps.txt
#
# Now print it
# Use default printer
Get-Content c:\foo\gps.txt | out-printer   
##
#
#
CLS
#
#  Out-Gridview
#
Get-Process Powershell
Get-Process powershell | Out-GridView
Get-Process powershell | Select * | Out-Gridview
#
#
# Out-String
$str = Get-Process | Out-String 
$str.Count
$str.GetType()
$str | Get-Member

#
# Get set of powerShell processes into $procs, and display count
$procs = Get-Process powershell* 
"{0} processes in `$procs" -f $procs.count
#
#  Now export to different formats
$procs | Export-clixml c:\foo\x1.xml
($procs | ConvertTo-Xml).Save("c:\foo\x2.xml")
#
#   Now look at them in an exit window
Get-ChildItem  c:\foo\x1.xml,c:\foo\x2.xml 
psedit c:\foo\x1.xml
psedit c:\foo\x2.xml 
#
#
# Look at the CLiXML
# Rehydrate the exported CliXML
$rhdprocs = Import-Clixml c:\foo\x1.xml
#
# Now look at properties of original $procs, then deserialized objects
$procs | GM | Select-Object    -First 8
$rhdprocs | gm | Select-Object -First 8
# END