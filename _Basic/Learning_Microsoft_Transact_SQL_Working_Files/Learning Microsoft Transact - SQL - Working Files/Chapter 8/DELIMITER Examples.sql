-- Delimiter Examples

-- Single quotes are used to indicate literals
USE AdventureWorks2012
SELECT FirstName 'First Name', LastName 'Last Name'
FROM Person.Person

-- Double quotes or brackets can be used as 
-- identifier delimiters
CREATE TABLE "My Table"
(
	EmpID int not null
)

-- This kind of object naming is not recommended :)
CREATE TABLE [Emp Table]
(
   EmpID int not null,
   [Table] varchar(25)
)