FROM microsoft/mssql-server-windows
#prepare the aspnet db for authentication in the website
CMD MD data
COPY aspnetdb.mdf data/aspnetdb.mdf
COPY aspnetdb_log.ldf data/aspnetdb_log.ldf
#single purpose container, just attach the db so we can connect
CMD powershell .\start -sa_password Password123! -ACCEPT_EULA 'Y' -attach_dbs \"[{'dbName':'aspnetdb','dbFiles':['C:\\data\\aspnetdb.mdf','C:\\data\\aspnetdb_log.ldf']}]\\\" -Verbose