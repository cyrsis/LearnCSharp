-- TSQL Variables

USE AdventureWorks2012
-- Create a variable and set it to the value of 50
-- as part of the variable declaration and print
-- the value of the variable
DECLARE @MyCounter int=50;
PRINT @MyCounter

-- We'll get an error if we try to concatenate text
-- to the variable in the PRINT statement
PRINT 'The value of @MyCounter is: ' + @MyCounter

-- We'll have to CAST the variable to a text datatype
PRINT 'The value of @MyCounter is: ' + CAST(@MyCounter as varchar(5))

-- We can SET the variable
DECLARE @TestVar int;
SET @TestVar=45;
PRINT @TestVar

-- We can also use SELECT to set the variable
DECLARE @TestSelect int;
SELECT @TestSelect=COUNT(LineTotal) FROM Sales.SalesOrderDetail
PRINT @TestSelect;

-- Run this select to verify the value that was assigned
-- to the variable @TestSelect
select COUNT(LineTotal) FROM Sales.SalesOrderDetail