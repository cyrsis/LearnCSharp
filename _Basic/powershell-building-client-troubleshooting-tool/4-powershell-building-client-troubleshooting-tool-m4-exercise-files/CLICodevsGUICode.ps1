#region CLI Code

$VerbosePreference = 'Continue'
$WarningPreference = 'Continue'

Write-Verbose -Message 'This is verbose output'
Write-Warning -Message 'This is warning output'
Write-Error -Message 'This is error output'

function Get-RemoteFile
{
	param (
		[Parameter()]
		[ValidateScript({ Test-connection -ComputerName $_ -Quiet -Count 1 })] ## function parameter validation
		[string]$ComputerName = $env:COMPUTERNAME,
		
		[Parameter(Mandatory)]
		[string]$FilePath
	)
	
	Invoke-Command -ComputerName $ComputerName -ScriptBlock { Get-Content -Path $FilePath }
}

#region Demo setup
new-item \\client1\c$\TestFile.txt -Type File
Add-Content -Path \\client1\c$\TestFile.txt -Value 'test123', 'test1234', 'test12345'
#endregion

## Parameter validation errors don't show up in thh GUI
Get-RemoteFile -ComputerName NONEXISTENTCOMPUTER -FilePath 'C:\TestFile.txt'

## Users can't be prompted for mandatory parameters
Get-RemoteFile -ComputerName CLIENT2

#endregion

#region GUI Code

## Simple form --specific types are required
Add-Type -AssemblyName System.Windows.Forms
$Form = New-Object System.Windows.Forms.Form

## A window, no console here
$Form.ShowDialog()

## Properties on the WinForm object. This will be your "console output"
$Form.Text = 'My Form'
$Form.ShowDialog()

## Every WinForm control is an object with properties
$Label = New-Object System.Windows.Forms.Label
$Label.Text = 'This form is very simple.'
$Label.AutoSize = $True
$Form.Controls.Add($Label)
$Form.ShowDialog()

## You must account for positions on the screen now
$Form.Width = 500
$Form.Height = 200
$Form.ShowDialog()

## You must account for lots of visual elements
$Icon = [system.drawing.icon]::ExtractAssociatedIcon($PSHOME + "\powershell.exe")
$Form.Icon = $Icon

#endregion