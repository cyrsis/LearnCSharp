-- INSERT SELECT Examples


-- Here's the basic INSERT syntax
INSERT INTO NewData
(EID, LastName, FirstName, Department)
VALUES
(9,'Long','Mark','Sales')

-- INSERT SELECT can be used to add the results of 
-- a select query to a table
-- Just remember that the column names are positional!
INSERT INTO NewData
(EID, FirstName, LastName)
SELECT BusinessEntityID, FirstName, LastName
FROM Person.Person

select * from newdata
