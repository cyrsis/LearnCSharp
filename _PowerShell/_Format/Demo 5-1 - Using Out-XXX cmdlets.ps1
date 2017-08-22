#
#
#    Demo 5-1
#
#
#
#  Using Out-File/Out-Printer
GPS | out-file c:\foo\gps.txt
cat c:\foo\gps.txt
#
# Now print it
# Use default printer
get-contents c:\foo\gps.txt | out-printer   
##
#
#
CLS
#
#  Out-Gridview
#
gps Powershell
gps powershell | out-gridview
gps powershell | Select * |out-gridview
#
#
# out-string
$str = gps | out-string 
$str.count
$str.gettype()
$str | gm

#
# Get set of powerShell processes into $procs, and display count
$procs = gps powershell* 
"{0} processes in `$procs" -f $procs.count
#
#  Now export to different formats
$procs | export-clixml c:\foo\x1.xml
($procs | ConvertTo-Xml).save("c:\foo\x2.xml")
#
#   Now look at them in an exit window
ls c:\foo\x1.xml,c:\foo\x2.xml 
psedit c:\foo\x1.xml
psedit c:\foo\x2.xml 
#
#
# Look at the CLiXML
# Rehydrate the exported CliXML
$rhdprocs = Import-Clixml c:\foo\x1.xml
#
# Now look at properties of original $procs, then deserialized objects
$procs | GM | select -first 8
$rhdprocs | gm | select -first 8
#
#

