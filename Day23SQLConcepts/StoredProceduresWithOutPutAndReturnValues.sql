--Stored Procedures with OutPut and Return Values

Create Procedure spGetTotalCount1
@TotalCount int out
as 
Begin
	Select @TotalCount = COUNT(Id) from Employees
End

Declare @TotalEmployees int
Execute spGetTotalCount1 @TotalEmployees out
Print @TotalEmployees

Create Procedure spGetTotalCount2
as 
Begin
	return (Select COUNT(Id) from Employees)
End

Declare @TotalEmployees int
Execute @TotalEmployees = spGetTotalCount2
Print @TotalEmployees

Create Procedure spGetNameId1
@Id int,
@Name nvarchar(20) output
as
Begin
	Select @Name = Name from Employees Where Id = @Id
End

Declare @Name nvarchar(20)
Execute spGetNameId1 1, @Name out
Print 'Name=  ' + @Name


Create Procedure spGetNameId2
@Id int
as
Begin
	return (Select Name from Employees Where Id = @Id)
End

Declare @Name nvarchar(20)
Execute @Name = spGetNameId2 1
Print 'Name=  ' + @Name