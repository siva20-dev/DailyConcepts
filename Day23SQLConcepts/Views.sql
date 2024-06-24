--Views

Select * from Employees
Select * from Department

Create View vWEmployeesByDepartment
as
Select Employees.ID,Name,Salary,Gender,Departname
from Employees
join Department
on Employees.DepartmentId = Department.Id

Select * from vWEmployeesByDepartment

Create View vWITEmployees
as
Select Employees.ID,Name,Salary,Gender,Departname
from Employees
join Department
on Employees.DepartmentId = Department.Id
Where Departname = 'IT'

Select * from vWITEmployees

CREATE VIEW vWNonConfidentialData
as
Select Employees.ID,Name,Gender,Departname
from Employees
join Department
on Employees.DepartmentId = Department.Id

Select * from vWNonConfidentialData

Create View vWSummarizedData
as
Select Departname, COUNT(Employees.ID) as TotalEmployees
from Employees
join Department
on Employees.DepartmentId = Department.Id
Group by DepartName

Select * from vWSummarizedData