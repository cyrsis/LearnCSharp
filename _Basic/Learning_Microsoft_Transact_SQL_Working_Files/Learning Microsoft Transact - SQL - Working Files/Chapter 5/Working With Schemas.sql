
-- Understanding Schemas

-- Let's use the AdventureWorks2012 database for these examples

-- My default schema is dbo so this query executes 
USE AdventureWorks2012
SELECT * FROM ErrorLog

-- This query generates and error because the 
-- Address table is in the Person schema
SELECT * FROM Address

-- If I include the Person schema in the query
-- the query executes with no errors
SELECT * FROM Person.Address

-- I can create a new schema in the TestDB database
USE TestDB
-- Now I will create the new schema
CREATE SCHEMA Accounting;


-- I can transfer a table to the new schema
ALTER SCHEMA Accounting
TRANSFER dbo.PKExample

-- Now I can no longer query from PKExample
-- without including the schema name
SELECT * FROM PKExample

SELECT * FROM Accounting.PKExample


