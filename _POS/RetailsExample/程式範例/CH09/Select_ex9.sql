use TestSIS
select Max(Totals) as 單筆最高銷售額 ,
       Avg(Totals) as 平均銷售額 ,
	   Sum(Totals) as 總銷售額
from ShipDetails