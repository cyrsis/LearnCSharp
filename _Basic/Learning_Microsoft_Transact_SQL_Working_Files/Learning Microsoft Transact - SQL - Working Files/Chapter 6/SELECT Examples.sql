-- SELECT EXAMPLES

USE AdventureWorks2012

-- The * means return all columns in the table
SELECT * FROM HumanResources.Employee

-- It may be easier to recognize the structure of the query
-- by writing the query in this form
SELECT
	*
FROM
	HumanResources.Employee

-- A comma separated list of column names returns the columns
-- in the order they are listed
SELECT
	BusinessEntityID,
	OrganizationLevel,
	JobTitle
FROM
	HumanResources.Employee

-- The above form is the same query as this one
SELECT BusinessEntityID,OrganizationLevel,JobTitle
FROM HumanResources.Employee

-- Notice this query is returning 290 rows
-- A WHERE clause will limit the number of rows retrieved
-- using WHERE OrganizationLevel=3 only returns 66 rows
SELECT BusinessEntityID,OrganizationLevel,JobTitle
FROM HumanResources.Employee
WHERE OrganizationLevel=3


