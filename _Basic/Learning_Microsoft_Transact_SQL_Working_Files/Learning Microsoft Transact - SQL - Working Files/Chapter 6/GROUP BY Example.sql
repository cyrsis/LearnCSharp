-- GROUP BY Examples

-- Let's see what is in the Sales.SalesOrderDetail table
select * from Sales.SalesOrderDetail

-- Let's get the all the LineTotal numbers for
-- ProductID 776
select LineTotal from Sales.SalesOrderDetail
where ProductID=776

-- Let's use an Average (AVG) function to see the average amount of the
-- LineTotals for ProductID 776
select AVG(LineTotal) 'Total LineTotals' from Sales.SalesOrderDetail
where ProductID=776

-- What if we want to see an average LineTotal for each ProductID?
-- We could try this, but it will not run because we are asking for
-- multiple rows of ProductID's and a single row for the LineTotal average
select ProductID, AVG(LineTotal) 'Total LineTotals' from Sales.SalesOrderDetail

-- We can use grouping to get the results we are looking for
-- The GROUP BY clause is how we perform grouping
select ProductID, AVG(LineTotal) 'Total LineTotals' 
from Sales.SalesOrderDetail
GROUP BY ProductID

-- We can add ORDER BY to make the data easier to use
select ProductID, AVG(LineTotal) 'Total LineTotals' 
from Sales.SalesOrderDetail
GROUP BY ProductID
ORDER BY ProductID

-- We can add the COUNT function get see how many orders are included
-- in the averaged LineTotals
select ProductID, COUNT(LineTotal) Orders,AVG(LineTotal) 'Total LineTotals' 
from Sales.SalesOrderDetail
GROUP BY ProductID
ORDER BY ProductID

-- Now we can ORDER BY the number of orders to easily see our least and 
-- most ordered products
-- NOTE that we can use the column alias name of 'Orders' in the ORDER BY clause
select ProductID, COUNT(LineTotal) Orders,AVG(LineTotal) 'Total LineTotals' 
from Sales.SalesOrderDetail
GROUP BY ProductID
ORDER BY Orders




