-- Aggregate Functions Examples

-- Let's see what is in the Sales.SalesOrderDetail table
select * from Sales.SalesOrderDetail

-- Let's get the all the LineTotal numbers for
-- ProductID 776
select LineTotal from Sales.SalesOrderDetail
where ProductID=776

-- Let's use a SUM function to see a total of the
-- LineTotals for ProductID 776
select SUM(LineTotal) 'Total LineTotals' from Sales.SalesOrderDetail
where ProductID=776

-- Let's use an Average (AVG) function to see the average amount of the
-- LineTotals for ProductID 776
select AVG(LineTotal) 'Total LineTotals' from Sales.SalesOrderDetail
where ProductID=776

-- Let's use a COUNT function to see how many instances there are for
-- LineTotals for ProductID 776
select COUNT(LineTotal) 'Total LineTotals' from Sales.SalesOrderDetail
where ProductID=776

-- Let's put them all together
select COUNT(LineTotal) Number, AVG(LineTotal) Average, SUM(LineTotal) Total
from Sales.SalesOrderDetail
where ProductID=776
