
net stop squid
rmdir /s/q c:\squid\var\cache
c:\squid\sbin\squid -z
net start squid