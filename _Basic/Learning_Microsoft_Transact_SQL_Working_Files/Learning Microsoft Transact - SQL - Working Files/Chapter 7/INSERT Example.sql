-- INSERT Examples

-- Let's create a simple table for our INSERTS
create table NewData
(
	EID int not null,
	LastName varchar(25),
	FirstName varchar(25),
	Department varchar(25)
)


-- Here's the basic INSERT syntax
INSERT INTO NewData
(EID, LastName, FirstName, Department)
VALUES
(1,'Long','Mark','Sales')


-- Note that the word INTO is optional and 
-- is not required
INSERT NewData
(EID, LastName, FirstName, Department)
VALUES
(4,'Long','Mark','Sales')

-- Input values are positional
-- If you are adding a value to every column
-- you are not required to list the column names
INSERT NewData
VALUES
(2,'Jones','Mike','HR')


-- If you are inputting data in a different column
-- order, you must list the columns and place the 
-- values positionally to match
INSERT NewData
(FirstName, LastName, EID)
VALUES
('Bob','Smith',3)


-- You can INSERT multiple rows by separating
-- the rows with a comma
INSERT NewData
VALUES
(4,'James','Roger','Sales'),
(5,'Harris','Lee','Marketing'),
(6,'Ames','Carol','Accounting'),
(7,'Jeffrey','Marsha','Sales'),
(8,'Hornsby','Alice','HR')

select * from newdata