-- Identity Column

Select * from tblPerson1

Insert into tblPerson1 Values ('Tom')
Insert into tblPerson1 Values ('Mike')
Insert into tblPerson1 Values ('John')


Delete from tblPerson1 Where PersonID = 1

SET IDENTITY_INSERT tblPerson1 ON
Insert into tblPerson1  (PersonId,Name) Values (1,'Tom')
Insert into tblPerson1 Values ('Alex')
SET IDENTITY_INSERT tblPerson1 OFF
Insert into tblPerson1 Values ('Alexander')

Delete from tblPerson1

Insert into tblPerson1 Values ('Tom')
Delete from tblPerson1
DBCC CHECKIDENT(tblPerson1,RESEED,0)
Insert into tblPerson1 Values ('Tom')