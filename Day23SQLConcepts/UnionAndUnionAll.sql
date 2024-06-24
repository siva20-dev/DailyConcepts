--Union AND Union All

INSERT into tblIndiaCustomers Values(1,'Ben','B@B.com')
INSERT into tblIndiaCustomers Values(2,'Sam','S@S.com')

INSERT into tblUKCustomers Values(1,'Raj','R@R.com')
INSERT into tblUKCustomers Values(2,'Sam','S@S.com')

Select *  from tblIndiaCustomers
UNION ALL
Select *  from tblUKCustomers

Select *  from tblIndiaCustomers
UNION
Select *  from tblUKCustomers

Select *  from tblIndiaCustomers
UNION ALL
Select *  from tblUKCustomers
Order By Name