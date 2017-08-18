-- DELETE Examples

-- Let's start by taking a look at the data in our
-- NewData table
-- See the video 'The INSERT Statement' if you don't
-- have a NewData table in the AdventureWorks2012 database
select * from newdata

-- Here's the basic syntax for the DELETE statement
DELETE FROM NewData
WHERE EID=293

-- You should always make sure the WHERE clause
-- identifies only the row or rows you intend to delete!
DELETE FROM NewData
WHERE LastName='Alberts'


-- If you don't include a WHERE clause
-- all rows will be deleted from the table
DELETE FROM NewData
