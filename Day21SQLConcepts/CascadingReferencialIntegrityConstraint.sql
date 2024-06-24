--Cascading Referencial Integrity Constraint

Select * From tblGender
Select * From tblPerson

ALTER TABLE tblPerson
ADD CONSTRAINT DF_tblPerson_GenderId
DEFAULT 3 FOR GENDERID

DELETE from tblGender Where ID = 3