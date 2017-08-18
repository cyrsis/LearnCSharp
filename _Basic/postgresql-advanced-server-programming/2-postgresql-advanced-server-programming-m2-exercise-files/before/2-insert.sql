

-- Retrieve Data
SELECT *
FROM Employee;

-- Insert Values
INSERT INTO Employee (empname, salary)
VALUES('Pinal',500);

-- Retrieve Data
SELECT *
FROM Employee;

-- Insert Values
INSERT INTO Employee (empname, salary)
VALUES('Pinal Dave',500);

-- Retrieve Data
SELECT *
FROM Employee;

-- No Employee Name
INSERT INTO Employee (salary)
VALUES(100);

-- Retrieve Data
SELECT *
FROM Employee;

-- Null Salary
INSERT INTO Employee (empname, salary)
VALUES('Steve', null);

-- No Salary
INSERT INTO Employee (empname)
VALUES('Steve');

-- Retrieve Data
SELECT *
FROM emp;

-- Null Salary
INSERT INTO Employee (empname, salary)
VALUES('Steve', -100);

-- Retrieve Data
SELECT *
FROM Employee;












-- Clean up 
DROP TABLE emp;
DROP FUNCTION emp_stamp();

