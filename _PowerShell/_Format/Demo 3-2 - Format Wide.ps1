#
#   Demo 3-2
#   Format Wide
#
#
###
#
#
PUSHD C:\foo
Get-ChildItem |Format-Wide name 
#
# Use Columns parameter
Get-ChildItem |Format-Wide name -Column 3

# Beware of too many columns - no -WRAP parameter
Get-ChildItem |Format-Wide name -Column 5




POPD #We're done