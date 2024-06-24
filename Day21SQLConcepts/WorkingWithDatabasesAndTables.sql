--Working With Database 

Create Database Sample2

Alter DataBase Sample2 Modify Name = Sample3

sp_renameDB 'Sample3', Sample4

Drop Database Sample1

 Alter DataBase Sample1 Set SINGLE_USER with RollBack Immediate

Alter DataBase Sample4 Modify Name = Sample1

-- Working With Tables 

Create Table tblGender
(
ID int NOT NULL Primary Key,
Gender nvarchar(50) NOT NULL
)

Alter table tblPerson add constraint tblPerson_GenderID_FK
Foreign Key (GenderID) references tblGender(ID)