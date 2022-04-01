--Stored procedure -exe
use Trial
go

create procedure sp_enrolldt
as
select studentID,stuFname,stuLname,Gender,Contact,EmailID
from tbl_enrll
exec sp_enrolldt
go

create proc sp_enDt
@stuid int
as
select studentID,stuFname,stuLname,Gender,Contact,EmailID
from tbl_enrll
where studentID = @stuid
exec sp_enDt 2005

sp_help 'tbl_Fest'
go
 create proc sp_insFst
 @nmae varchar(20)
 as
 insert into tbl_Fest(sFullName)
 values(@nmae)

 sp_insfst 'CR12'
 select * from tbl_Fest
