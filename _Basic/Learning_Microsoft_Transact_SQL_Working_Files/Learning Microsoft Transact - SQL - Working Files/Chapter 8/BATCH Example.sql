-- Batch Example

Use AdventureWorks2012
--GO

CREATE VIEW ML
as
select FirstName from person.person

--GO;

select * from ml

-- Here's and example of GO
-- using variables
Declare @test int=5;
--GO
PRINT @test



