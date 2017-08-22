#
#    Demo 2-1
#    Composite Format Strings
#
#
###
#
#
#    Simple format string
" {0} {1} {2}"   -f    1, 2, 3
#
#
#    Mix format items into text    
" abc   {0}   def   {1}   jkl {2}, etc."   -f    1, 2, 3
#
#
#    Add in characters to delinate data
$date = get-date
"Date: ({0})  Number [{1}]"  -f $date, 42
#
#
#    Composite formatting formats most things!
" [{0,22}]" -f 1
" [{0,22}]" -f 111.1
" [{0,22}]" -f "A string"
" [{0,22}]" -f $date
cls
#
#    Create a table with 3 columns
#    Format Items specify width and justification
#    Use format string for headers and items
CAT '.\Demo 2-1a.ps1'
& '.\Demo 2-1a.ps1'
cls
#
#    Get decimals to line up, no currency formating
#    and assign the format string in advance
CAT '.\Demo 2-1b.ps1'
& '.\Demo 2-1b.ps1'
cls
#
#     Ensure calls to cmdlet or function are in Parens
#
"`$a has a value of [{0}]" -f Get-Date   # Generates an error
"`$a has a value of [{0}]" -f (Get-Date) # Works OK!
#
# Also note that backtick before a "{" or "}" fails to
# No error generated, just not what you might expect
"`$a has a value of [{0}]! but not `{{0}`}" -f 234.34
# END