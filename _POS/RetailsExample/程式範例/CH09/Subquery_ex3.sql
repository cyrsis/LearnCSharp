use TestSIS
SELECT *
FROM ShipDetails AS S
WHERE S.Totals > ALL (SELECT AVG(Totals) 
                      FROM ShipDetails S
			          WHERE S.Quantity > 1)
