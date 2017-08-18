

-- CASE Statements
SELECT * 
FROM Production.Product
ORDER BY ProductNumber

SELECT   ProductNumber , Name, "Price Range" = 
      CASE 
         WHEN ListPrice =  0 THEN 'Not for sale'
         WHEN ListPrice < 50 THEN 'Under $50'
         WHEN ListPrice >= 50 and ListPrice < 250 THEN 'Under $250'
         WHEN ListPrice >= 250 and ListPrice < 1000 THEN 'Under $1000'
         ELSE 'Over $1000'
      END
FROM Production.Product
ORDER BY ProductNumber ;
GO