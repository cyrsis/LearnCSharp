use TestSIS
UPDATE ItemsInfo SET Inventory = B.TotalsQuantity 
FROM ItemsInfo AS A
INNER JOIN (
Select N.ItemsID , N.NAME ,SUM(M.Quantity - N.Quantity) as TotalsQuantity 
FROM ShipDetails AS N
INNER JOIN StockDetails AS M ON N.ItemsID = M.ItemsID 
Group By N.ItemsID , N.NAME) AS B ON A.ItemsID = B.ItemsID 


