	-- The UPDATE Statement

-- Note that in these examples, we'll be working with the NewData
-- table that was created in the video entitled 
-- 'The INSERT Statement'

-- Let's take a look at the data
-- in the NewData table
-- Take a look at the videos 'The INSERT Statement' and 
-- 'INSERT SELECT' to add data to the NewData table
select * from newdata

-- Let's use SELECT INTO to make a copy of our data into a new table
-- You'll see why later in the examples
SELECT *
INTO NewData2
FROM NewData

-- Here's the basic syntax for the UPDATE statement
UPDATE NewData
SET FirstName='Bill'
WHERE FirstName='Alex' AND LastName='Adams'

-- We could have also used the EID column in the WHERE clause
UPDATE NewData
SET FirstName='Bill'
WHERE EID=16724




-- You should ALWAYS include a WHERE clause that limits
-- the update to a specific row or rows!
Update NewData 
SET FirstName='Bill'
WHERE LastName='Adams'

-- What happens if you don't include a WHERE clause?
Update NewData 
SET FirstName='Bill'

-- Now, let's straighten out the mess we've made
-- We'll delete the NewData table with the wrong names
DROP TABLE NewData

-- And we'll use SELECT INTO to take the data from NewData2 
-- to recreate our NewData table
SELECT *
INTO NewData
FROM NewData2

-- Now we have a clean NewData table that we can use on other examples
-- later in the course.




