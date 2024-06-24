Select * from Employees

CREATE PROCEDURE spGetEmployees
As
BEGIN
	Select Name,Gender from Employees
END

spGetEmployees

Exec spGetEmployees

Execute spGetEmployees

CREATE PROC spGetEmployeesBYGenderAndDepartment
@Gender nvarchar(20),
@DepartmentId int
As
Begin
	Select Name,Gender,DepartmentId from Employees Where Gender = @Gender
	And DepartmentId = @DepartmentId
End

spGetEmployeesBYGenderAndDepartment 'Male', 1

sp_helpText spGetEmployees

sp_helpText spGetEmployeesBYGenderAndDepartment

Alter PROCEDURE spGetEmployees  
As  
BEGIN  
 Select Name,Gender from Employees  Order By Name
END  

Drop PROCEDURE spGetEmployees 