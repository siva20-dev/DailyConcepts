--Advance Joins

Select * from Employees
Select * from Department

Select  Name,Gender,Salary,Departname
from    Employees
LEFT JOIN Department
ON      Employees.DepartmentId = Department.ID
Where Employees.DepartmentId IS NULL

--or

Select  Name,Gender,Salary,Departname
from    Employees
LEFT JOIN Department
ON      Employees.DepartmentId = Department.ID
Where Department.Id IS NULL

Select  Name,Gender,Salary,Departname
from    Employees
RIGHT JOIN Department
ON      Employees.DepartmentId = Department.ID
Where Employees.DepartmentId IS NULL

Select  Name,Gender,Salary,Departname
from    Employees
Full JOIN Department
ON      Employees.DepartmentId = Department.ID
Where Employees.DepartmentId IS NULL
OR Department.Id IS NULL