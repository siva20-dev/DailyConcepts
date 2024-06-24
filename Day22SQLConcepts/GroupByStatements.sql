--Group by

Select * from tblEmployee
Insert into tblEmployee Values ('Tom','Male',4000,'London')
Insert into tblEmployee Values ('Pam','Female',3000,'NewYork')
Insert into tblEmployee Values ('John','Male',3500,'London')
Insert into tblEmployee Values ('Sam','Male',4500,'London')
Insert into tblEmployee Values ('Todd','Male',2800,'Sydney')
Insert into tblEmployee Values ('Ben','Male',7000,'NewYork')
Insert into tblEmployee Values ('Sara','Male',4800,'Sydney')
Insert into tblEmployee Values ('Valarie','Male',5500,'NewYork')
Insert into tblEmployee Values ('James','Male',6500,'London')
Insert into tblEmployee Values ('Russell','Male',8800,'London')

UPDATE tblEmployee
SET Gender = 'Female'
WHERE Id IN (7,8)

Select SUM(Salary) from tblEmployee

Select MIN(Salary) from tblEmployee

Select MAX(Salary) from tblEmployee

Select City, SUM(Salary) as TotalSalary
from tblEmployee
Group By City

Select City, Gender, SUM(Salary) as TotalSalary
from tblEmployee
Group By City,Gender
Order By City

Select COUNT(Id) from tblEmployee

Select City, Gender, SUM(Salary) as TotalSalary, COUNT(Id) as [Total Employees]
from tblEmployee
Group By City,Gender
Order By City

Select  Gender,City, SUM(Salary) as TotalSalary, COUNT(Id) as [Total Employees]
from tblEmployee
Where Gender = 'Male'
Group By Gender,City

Select  Gender,City, SUM(Salary) as TotalSalary, COUNT(Id) as [Total Employees]
from tblEmployee
Group By Gender,City
Having Gender = 'Male'