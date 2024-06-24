--Where and Having Clause Differences

Create table Sales
(
	Product nvarchar(50),
	SaleAmount int	
)
Go

Select * from Sales
INSERT into Sales Values ('iPhone',500)
INSERT into Sales Values ('Laptop',800)
INSERT into Sales Values ('iPhone',1000)
INSERT into Sales Values ('Speakers',400)
INSERT into Sales Values ('Laptop',600)

Select Product, SUM(SaleAmount) as TotalSales
from Sales
Group By Product
Having SUM(SaleAmount) > 1000

Select Product, SUM(SaleAmount) as TotalSales
from Sales
Where Product IN('iPhone','Speakers')
Group By Product

Select Product, SUM(SaleAmount) as TotalSales
from Sales
Group By Product
Having Product IN('iPhone','Speakers')

Select Product, SUM(SaleAmount) as TotalSales
from Sales
Where Product IN('iPhone','Speakers')
Group By Product
Having SUM(SaleAmount) > 1000