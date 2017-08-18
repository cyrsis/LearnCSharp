-- ORDER BY

Use AdventureWorks2012

-- Let's see the data in alphabetical order of the
-- JobTitle column
SELECT BusinessEntityID,OrganizationLevel,JobTitle
FROM HumanResources.Employee
ORDER BY JobTitle ASC

-- Let's see the data in order of OrganizationLevel
-- and then with BusinessEntityIDs in ascending order
-- within each OrganizationLevel
SELECT BusinessEntityID,OrganizationLevel,JobTitle
FROM HumanResources.Employee
ORDER BY OrganizationLevel,BusinessEntityID ASC

-- How about order by OrganizationLevel and then JobTitle
SELECT BusinessEntityID,OrganizationLevel,JobTitle
FROM HumanResources.Employee
ORDER BY OrganizationLevel,JobTitle ASC