-- TSQL Concatenation

USE AdventureWorks2012
SELECT FirstName, LastName 
FROM Person.Person

-- Let's use concatenation to put the names 
-- together in a single column
SELECT FirstName + ' ' + LastName 'Employee Name'
FROM Person.Person
ORDER BY LastName, FirstName

-- How about LastName, FirstName
SELECT LastName + ', ' + FirstName 'Employee Name'
FROM Person.Person
ORDER BY LastName, FirstName