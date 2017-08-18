-- SELECT then DELETE

-- Instead of writing a DELETE statement and executing it
-- Write it first as a SELECT statement

-- Instead of executing this
DELETE FROM NewData
WHERE LastName='Alberts'

-- Write it as a SELECT * and execute it
SELECT * FROM NewData2
WHERE LastName='Alberts'

-- Now you can see if you need to make the WHERE
-- clause more or less specific
SELECT * FROM NewData2
WHERE EID=287

-- Now change to a DELETE statement and execute it
DELETE FROM NewData2
WHERE EID=287
