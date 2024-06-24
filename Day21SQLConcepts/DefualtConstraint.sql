--Defualt Constraint

Select * From tblGender
Select * From tblPerson

Insert INTO tblGender (ID,Gender) Values (3,'Unknown')

Insert into tblPerson (ID,Name,Email,GenderID) Values (10,'Jim','jim@gmail.com',NULL)

ALTER TABLE tblPerson
DROP CONSTRAINT DF_tblPerson_GenderId

ALTER TABLE tblPerson
ADD CONSTRAINT DF_tblPerson_GenderId
DEFAULT 2 FOR GENDERID
