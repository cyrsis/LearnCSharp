use TestSIS
INSERT INTO AccountsPayable(StockID,ManufacturerID,CNAME,
UnpaidAmount,ReversalAmount,Surplus)
SELECT * From AccountsReceivable