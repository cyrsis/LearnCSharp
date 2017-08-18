-- With this file open, click on the Execute button in the toolbar
-- to run this script.
--
-- This will create two tables: STUDENT and ADDRESS2 and populate them
--
-- We will use these tables to work with OUTER JOIN examples

USE TestDB
CREATE TABLE STUDENT
(
  SID int CONSTRAINT PK_StudentSID PRIMARY KEY CLUSTERED not null,
  FirstName varchar(25),
  LastName varchar(25),
  Address varchar(50),
  City varchar(25),
  State char(2),
  Zip int
);


CREATE TABLE ADDRESS2
(
  SID int REFERENCES Student(SID),
  Address varchar(50),
  City varchar(25),
  State char(2),
  Zip int
);


INSERT INTO STUDENT
VALUES
(1,'Frank','Jones','4312 Jackson Lane','Nashville','TN','37065'),
(2,'Jennifer','Hayes','821 North Lake Dr','Atlanta','GA','30068'),
(3,'Kristin','Klugh','73 Easton Way','Memphis','TN','32786'),
(4,'Bob','Smith','U.S. Highway 63','Madison','AL','36062'),
(5,'Alice','James','7643 Wysteria Lane','Knoxville','TN','34867')


INSERT INTO ADDRESS2
VALUES
(3,'7776 North Beach Road','Naples','FL', 78687),
(5,'6836 Old Coast Highway','West Palm Beach','FL', 76876)

