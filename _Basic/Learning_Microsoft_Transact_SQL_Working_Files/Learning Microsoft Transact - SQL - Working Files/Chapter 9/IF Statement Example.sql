-- IF Statements


-- Let's create a variable @InStock
DECLARE @InStock int;

-- Load the @InStock variable with the result of a query
SELECT @InStock=SUM(OrderQty) FROM Sales.SalesOrderDetail 
	            WHERE ProductID=776

-- Check to see if the order qualifies for a 10% discount
IF @InStock>700
	PRINT 'Qualifies for a 10% discount'
ELSE
	PRINT 'No discount'


-- Note that we can use BEGIN...END to execute
-- multiple SQL statements in the IF statement
/*

IF @InStock>600
	BEGIN
		PRINT 'Qualifies for a 10% discount'
		PRINT 'Add code to calculate what the savings could be'
	End
ELSE
	BEGIN
		PRINT 'No discount'
		PRINT 'You should have bought more...'
	END

*/