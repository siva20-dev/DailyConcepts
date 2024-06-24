--Joins

Alter table Employees add constraint Employees_DepartmentID_FK
Foreign Key (DepartmentId) references Department(Id)

Select * from Employees
Select * from Department

Insert into Department Values ('IT','London','Rick')
Insert into Department Values ('Payroll','Delhi','Ron')
Insert into Department Values ('HR','Newyork','Christie')
Insert into Department Values ('OtherDepartment','Sydney','Cindrella')

Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values  (1,'Tom','Male',4000,1)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (2,'Pam','Female',3000,3)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (3,'John','Male',3500,1)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (4,'Sam','Male',4500,2)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (5,'Todd','Male',2800,2)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (6,'Ben','Male',7000,1)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (7,'Sara','Female',4800,3)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (8,'Valarie','Female',5500,1)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (9,'James','Male',6500,Null)
Insert into Employees (ID,Name,Gender,Salary,DepartmentId) Values (10,'Russell','Male',8800,Null)


Select Name,Gender,Salary,Departname
from Employees
INNER JOIN Department
ON Employees.DepartmentId = Department.ID

Select Name,Gender,Salary,Departname
from Employees
LEFT OUTER JOIN Department
ON Employees.DepartmentId = Department.ID

Select Name,Gender,Salary,Departname
from Employees
RIGHT OUTER JOIN Department
ON Employees.DepartmentId = Department.ID

Select Name,Gender,Salary,Departname
from Employees
FULL OUTER JOIN Department
ON Employees.DepartmentId = Department.ID

Select Name,Gender,Salary,Departname
from Employees
CROSS JOIN Department