use TestSIS
SELECT EmployeeID , CNAME , Background
FROM EmployeeInfo 
WHERE Background IN (SELECT Background 
                     FROM EmployeeInfo 
					 WHERE CNAME ='張學油')
