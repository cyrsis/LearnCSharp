use TestSIS
select Name as �ӫ~�W�� , SUM(Totals) as �`�P���B 
from ShipDetails
Group by Name
Having SUM(Totals) <= 5000
