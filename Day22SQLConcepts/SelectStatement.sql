--Select
Select * from tblPerson

Alter table tblPerson
Add City nvarchar(50)

Insert into tblPerson Values (12,'Tina','tina@gmail.com',2,29,'London')
Insert into tblPerson Values (13,'Josh','josh@gmail.com',1,36,'Newyork')
Insert into tblPerson Values (14,'Kim','kim@gmail.com',1,39,'Sydney')
Insert into tblPerson Values (15,'Elisa','Elisa@gmail.com',2,19,'London')
Insert into tblPerson Values (16,'Sachin','Sachin@gmail.com',1,29,'Mumbai')	

Select DISTINCT City from tblPerson

Select DISTINCT Name, City from tblPerson

Select * from tblPerson Where City = 'London'

Select * from tblPerson Where City <> 'London'

Select * from tblPerson Where Age IN(19,25,36)

Select * from tblPerson Where Age BETWEEN 20 AND 35

Select * from tblPerson Where City LIKE 'L%'

Insert into tblPerson Values (17,'Virat','viratgmail.com',1,34,'Delhi')	

Select * from tblPerson Where Email Not LIKE '%@%'

Select * from tblPerson Where Name LIKE '[^MST]%'

Select * from tblPerson Where Name LIKE '[^MST]%'

Select * from tblPerson Where (City = 'London' OR City = 'Mumbai') AND Age > 25

Select * from tblPerson order by Name

Select * from tblPerson order by Name DESC

Select * from tblPerson order by Name DESC,Age ASC

Select top 10 * from tblPerson 

Select top 10 Name, Age from tblPerson 

Select top 10 Percent * from tblPerson 

Select top 1 * from tblPerson order by Age DESC