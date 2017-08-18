-- These queries use the STUDENT and ADDRESS2 tables that are created
-- by executing the 'Sample OUTER JOIN Table Creation Script.sql' script
-- file that is located in the Working Files folder

SELECT * FROM STUDENT
SELECT * FROM ADDRESS2


-- First let's do an INNER JOIN
SELECT S.SID, S.Firstname, S.LastName, S.Address, S.City, S.State, S.Zip, A.Address 'SECOND ADDRESS', A.City, A.State, A.Zip
FROM STUDENT S
JOIN
ADDRESS2 A ON S.SID=A.SID


-- A LEFT OUTER JOIN will return all students from the STUDENTS table
-- and the matching records from the ADDRESS2 table
SELECT S.SID, S.Firstname, S.LastName, S.Address, S.City, S.State, S.Zip, A.Address 'SECOND ADDRESS', A.City, A.State, A.Zip
FROM STUDENT S
LEFT JOIN
ADDRESS2 A ON S.SID=A.SID

-- A RIGHT OUTER JOIN will return all students from the ADDRESS2 table
-- and the matching records from the STUDENT table
SELECT S.SID, S.Firstname, S.LastName, S.Address, S.City, S.State, S.Zip, A.Address 'SECOND ADDRESS', A.City, A.State, A.Zip
FROM STUDENT S
RIGHT JOIN
ADDRESS2 A ON S.SID=A.SID

-- A FULL OUTER JOIN will return all records from both tables
-- This will be identical to the LEFT OUTER since there are no rows
-- in the right table (ADDRESS2) that do not have records in the left table
SELECT S.SID, S.Firstname, S.LastName, S.Address, S.City, S.State, S.Zip, A.Address 'SECOND ADDRESS', A.City, A.State, A.Zip
FROM STUDENT S
FULL JOIN
ADDRESS2 A ON S.SID=A.SID


-- A CROSS JOIN produces some interesting, although, useless results
SELECT S.SID, S.Firstname, S.LastName, S.Address, S.City, S.State, S.Zip, A.Address 'SECOND ADDRESS', A.City, A.State, A.Zip
FROM STUDENT S
CROSS JOIN
ADDRESS2 A --ON S.SID=A.SID
