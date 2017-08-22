#
#   Demo 1-5
#   Timespan Formatting
#   Note: run from prompt with .NET 4.0 loaded
#
###
#
#
#
# Create two date/time objects
#
# Jery Garcia's birthday, and Boston Tea Party
$djgb = Get-Date  'August 1, 1942 05:00'
$dbtp = get-date  'December 16, 1773 17:00'
#
# New TimeSpan Object
$ts = new-timespan  -start $dbtp  -end $djgb
$ts
#
# now to string
" no parameter"
$ts.tostring()
$ts.tostring('c')
$ts.tostring('g')
$ts.tostring("G")
# culture sensitive
$de = new-object system.globalization.cultureinfo "de-DE"
$ts.tostring("G",$de)
