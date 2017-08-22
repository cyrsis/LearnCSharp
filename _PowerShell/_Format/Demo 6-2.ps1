###
#
#
#    Demo 6-2 XML related cmdlets
#
##
#
#    CliXML
#
##
# Start a few calculators
Calc;Calc
Get-Process Calc
#
#    Now convert to CLiXML and look at results
Get-Process Calc | Export-Clixml c:\foo\calc.clixml
#    File is large
Dir c:\foo\calc.clixml
#    Get the file
$I=Import-Clixml C:\foo\calc.clixml
$i.gettype()
$i.count
$i | Gm
$i
$i[0].PsTypeNames
##
#
#  XML
#
$Xml = Get-ChildItem c:\foo | ConvertTo-Xml
$xml.objects.object
$xml.save("c:\foo\dir.xml")
Cat C:\foo\dir.xml | Select -First 20

