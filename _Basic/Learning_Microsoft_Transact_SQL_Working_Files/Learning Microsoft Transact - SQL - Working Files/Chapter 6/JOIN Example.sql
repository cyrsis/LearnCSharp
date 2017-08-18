-- JOIN Example

SELECT TOP 1 * FROM Person.Person

SELECT TOP 1 * FROM Person.PersonPhone

-- Notice that the Firstname and Lastname of the person is in the 
-- Person.Person table and the phone number is in the Person.PersonPhone table
-- We can use the JOIN clause to retrieve the data from both tables
-- We just need to associate the data using a common column from both tables

SELECT 	FirstName, LastName, PhoneNumber
FROM Person.Person
JOIN Person.PersonPhone
ON Person.Person.BusinessEntityID=Person.PersonPhone.BusinessEntityID 
ORDER BY LastName, FirstName



-- We can alias tables just like we can alias columns
SELECT 	P.FirstName, P.LastName, Ph.PhoneNumber
FROM Person.Person AS P
JOIN Person.PersonPhone AS Ph
ON P.BusinessEntityID=Ph.BusinessEntityID 
ORDER BY Lastname, Firstname