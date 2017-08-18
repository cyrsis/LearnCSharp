
-- Column Aliasing

Use AdventureWorks2012
SELECT BusinessEntityID,OrganizationLevel,JobTitle
FROM HumanResources.Employee

-- Let's use column aliasing
SELECT BusinessEntityID AS Entity,OrganizationLevel AS Level,JobTitle AS 'Job Title'
FROM HumanResources.Employee

-- The AS keyword is optional, so you'll seldom see it in most TSQL code
SELECT BusinessEntityID Entity,OrganizationLevel Level,JobTitle 'Job Title'
FROM HumanResources.Employee

-- You cannot use the alias in the WHERE clause
SELECT BusinessEntityID Entity,OrganizationLevel Level,JobTitle 'Job Title'
FROM HumanResources.Employee
WHERE Entity<3
--WHERE BusinessEntityID<3