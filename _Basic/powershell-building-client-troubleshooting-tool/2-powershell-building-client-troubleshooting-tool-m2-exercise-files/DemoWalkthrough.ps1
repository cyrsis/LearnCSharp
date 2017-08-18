#region Demo prep

$demoFolderPath = 'C:\Dropbox\Business Projects\Courses\Pluralsight\Course Authoring\Active Courses\Building a Client Troubleshooting Tool with PowerShell\powershell-building-client-troubleshooting-tool-m2\Demos'

#endregion

#region One-time setup

## Create a file share on a remote server for the tool to pull UltraVNC binaries from
$ServerName = 'MEMBERSRV1'
$toolSharePath = "\\$ServerName\c$\ToolShare"
mkdir $toolSharePath
Invoke-Command -ComputerName $ServerName -Scriptblock { New-SmbShare -Name ToolShare -Path 'C:\ToolShare' }

## Already created INF file
#& "$demoFolderPath\VNC\VNC_Binaries\UltraVNC_Setup.exe" /saveinf="$demoFolderPath\VNC\VNC_Binaries\UltraVNCSilentInstall.inf"

## Copy the INF, installer and viewer to the file share
copy -Path "$demoFolderPath\VNC\VNC_Binaries" -Destination $toolSharePath -Recurse

## The file share contents
Get-ChildItem -Path "$toolSharePath\VNC_Binaries"

#endregion

## Our Test-VNCInstalledScript
ise "$demoFolderPath\VNC\Test-VNCInstalled.ps1"

## Our VNC deployment script
ise "$demoFolderPath\VNC\Deploy-VNC.ps1"