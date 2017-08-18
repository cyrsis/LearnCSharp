USE TestSIS
Select NAME as 名稱 , Inventory as 庫存量 ,
       TakeStockInventory as 盤點量 , IsTakeStock as 是否盤點
FROM TakeStockDetails  
