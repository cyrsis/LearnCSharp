-- Before creating a synonym for Accounting.PKExample
USE AdventureWorks2012
SELECT * FROM HumanResources.EmployeeDepartmentHistory

-- Create a synonym for HumanResources.EmployeeDepartmentHistory
CREATE SYNONYM EDH
FOR HumanResources.EmployeeDepartmentHistory

-- Using the PKEx synonym
SELECT * FROM EDH

-- NOTE: If we change the name of the HumanResources.EmployeeDepartmentHistory
-- table, we can change the EDH synonym to point to the new table name
-- and the 'SELECT * FROM EDH' query will pull data from the new table

-- We can also drop (delete) a synonym
DROP SYNONYM EDH

-- Now we will get an error...
SELECT * FROM EDH
