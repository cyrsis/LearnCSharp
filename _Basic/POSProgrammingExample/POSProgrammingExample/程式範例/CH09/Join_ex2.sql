use TestSIS
SELECT S.ShipID , S.ShipDate , S.TotalAfterTax , C.CNAME 
FROM ShipMaster AS S INNER JOIN CustomerInfo AS C
ON S.CustomerID = C.CustomerID 
