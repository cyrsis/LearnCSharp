## Save our test client into a variable in case we need to test against something else later
$ComputerName = 'CLIENT2'

#region REQUIREMENT 1 - Allow helpdesk to see all Windows services

Get-Service -ComputerName $ComputerName

Get-CimInstance -ClassName Win32_Service -ComputerName $ComputerName

#endregion

#region REQUIREMENT 2 - Allow helpdesk to only see disabled services

## I don't see any property I can filter on for disabled services.
Get-CimInstance -ClassName Win32_Service -ComputerName $ComputerName

## Let's dive deeper
Get-CimInstance -ClassName Win32_Service -ComputerName $ComputerName | Select -first 1 -Property *

## It looks like StartType is our winner -- I'm selecting name and starttype just to eyeball the results
Get-CimInstance -ClassName Win32_Service -ComputerName $ComputerName | where {$_.StartMode -eq 'Disabled'} | select displayname,startmode

#endregion

#region REQUIREMENT 3 - Allow helpdesk to only see stopped services

Get-Service -ComputerName $ComputerName | where { $_.Status -eq 'Stopped' } | select name, starttype

#endregion

#region REQUIREMENT 4 - Allow helpdesk to enable a service that is disabled

Get-Service -ComputerName $ComputerName -DisplayName $serviceName | Set-Service -StartupType Automatic

#endregion

#region REQUIREMENT 5 - Allow helpdesk to start a service

Get-Service -ComputerName $ComputerName -DisplayName $serviceName | Start-Service

#endregion