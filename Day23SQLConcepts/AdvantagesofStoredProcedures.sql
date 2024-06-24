--Advantages of Stored Procedures

Select * from Employees

Create Procedure spGetNameById
@Id int
as
Begin
	Select Name from Employees where Id = @Id
End

Execute spGetNameById 1
Execute spGetNameById 2