--Stored Procedures with OutPut Parameters
Select * from Employees

Create Proc spGetEmployeeCountByGender
@Gender nvarchar(20),
@EmployeeCount int output
as
Begin
	Select @EmployeeCount = COUNT(Id) from Employees where Gender = @Gender
End

Declare @TotalCount int
Execute spGetEmployeeCountByGender 'Male', @TotalCount OUT
Print @TotalCount

sp_help spGetEmployeeCountByGender
sp_help Employees

sp_depends spGetEmployeeCountByGender