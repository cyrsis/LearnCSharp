#Requires -version 5.0
get-packageprovider nuget -force -forcebootstrap

get-packageprovider chocolatey -force -forcebootstrap

Register-PackageSource -name 'chocolatey' -provider 'chocolatey' -location 'http://chocolatey.org/api/v2'

install-package conemu -provider chocolatey -force

#Not recommended
#set-packagesource -name 'chocolatey' -trusted -force

#For maintenance
[version](find-packageprovider chocolatey).version -gt [version](get-packageprovider chocolatey).version
