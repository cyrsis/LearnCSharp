use TestSIS
SELECT S.ShipID , S.ShipDate , S.TotalAfterTax , C.CNAME 
FROM ShipMaster AS S , CustomerInfo AS C
WHERE S.CustomerID = C.CustomerID 