--Check Constraint

Select * from tblPerson
Select * from tblGender

ALTER TABLE tblPerson
ADD Age int NULL;

INSERT into tblGender Values(1,'Male')
INSERT into tblGender Values(2,'Female')
INSERT into tblGender Values(3,'Unknown')


INSERT into tblPerson Values(1,'Alexander','alexander@gmail.com', 1, 25)
DELETE FROM tblPerson Where ID = 1

INSERT into tblPerson Values(9,'Alexander','alexander@gmail.com', 1, NULL)

Alter Table tblPerson
Drop Constraint CK_tblPerson_Age

Alter Table tblPerson
Add Constraint CK_tblPerson_Age CHECK (Age > 0 AND Age < 150)

INSERT into tblPerson Values(11,'Chris','chris@gmail.com', 1, 38)