use DemoCRUD1

create table Employee
(
Sr_no int primary key,
Emp_name nvarchar(500),
City nvarchar(500),
STATE nvarchar(500),
Coutry nvarchar(500),
Department nvarchar(500),
flag nvarchar(50)
)
create proc SP_Employee
@Sr_no int,@Emp_name nvarchar(500),
@City nvarchar(500),
@STATE nvarchar(500),
@Country nvarchar(500),
@Department nvarchar(500),
@flag nvarchar(50)
AS Begin
if(@flag='insert')
Begin
Insert into Employee (Emp_name,City,STATE,Coutry,Department) values (@Emp_name,@City,@STATE,@Country,@Department)
END

else if(@flag='delete')
Begin
Delete from Employee where Sr_no=@Sr_no
END

else if(@flag='getid')
Begin
Select * from Employee
where Sr_no=@Sr_no
END
Else if(@flag='get')
Begin
Select* from Employee
END
END