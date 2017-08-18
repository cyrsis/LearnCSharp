Nonclustered indexes
A nonclustered index provides a ‘what-if’ view of data within a table
It creates a virtual index that the database engine can use when searching for data
Nonclustered indexes do not affect the physical storage order of the data in a table
There can be up to 999 nonclustered indexes on a table in SQL Server

Too much of a good thing…

Nonclustered indexes require constant updating as data is inserted and modified in the table

Too many nonclustered indexes will slow down table updates
