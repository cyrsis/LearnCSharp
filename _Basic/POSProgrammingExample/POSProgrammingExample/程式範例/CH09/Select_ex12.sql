use TestSIS
select Name as 商品名稱 , SUM(Totals) as 總銷售額 
from ShipDetails
Group by Name
Having SUM(Totals) <= 5000
