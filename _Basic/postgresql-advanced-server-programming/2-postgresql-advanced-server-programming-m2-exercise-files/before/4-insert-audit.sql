-- Retrieve Data
SELECT *
FROM Employee;
-- Retrieve Data
SELECT *
FROM Employee_audit;

-- Insert Values
INSERT INTO Employee (empname, salary)
VALUES('Pinal',500);
INSERT INTO Employee (empname, salary)
VALUES('Troy',1500);
INSERT INTO Employee (empname, salary)
VALUES('Beth',2500);

-- Retrieve Data
SELECT *
FROM Employee;
-- Retrieve Data
SELECT *
FROM Employee_audit;

UPDATE Employee
SET salary = 200
WHERE empname = 'Troy';

-- Retrieve Data
SELECT *
FROM Employee;
-- Retrieve Data
SELECT *
FROM Employee_audit;

DELETE 
FROM Employee
WHERE empname = 'Pinal';

-- Retrieve Data
SELECT *
FROM Employee;
-- Retrieve Data
SELECT *
FROM Employee_audit;






-- Clean up 
DROP TABLE emp;
DROP TABLE emp_audit;
DROP FUNCTION process_emp_audit();


