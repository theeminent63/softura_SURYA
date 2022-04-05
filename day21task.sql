use adventureworks2019
go
------------Task1------------------------
---Using Count------------------
select count(firstname)
from Person.Person
---sum---------------------------
select sum(Bonus)Sum_Bonus
from sales.salesperson
---DateDiff----------------------
select DATEDIFF(YEAR,StartDate,EndDate)Experience
from HumanResources.EmployeeDepartmentHistory
---DateAdd-----------------------
select DATEADD(year,2,'2022/02/15')
---Convert-----------------------
select CONVERT(int,45.27)
---Left---------------------------
select LEFT('Surya',8)
---Len----------------------------
select Len('Surya')

---------------Task2--------------------------
create function fn_Rupees1(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'$'+@amount)
end
select BusinessEntityID,dbo.fn_Rupees1(rate) as Rupee
from HumanResources.EmployeePayHistory

----------------Task3----------------------------
create view HR
as
select * from dbo.HR_Dept
insert into HR values('MR','Marketing',4/4/2022)
insert into dbo.HR_Dept values('Acc','Accounting',2022/04/04)
select * from HR

----------------Task4-----------------------------
use Trial
go
create proc sp_insert
@name varchar(20)
as
insert into tbl_fest(sFullName)
values(@name)

 exec sp_insert'Surya'

 
 update  [dbo].[tbl_fest]
 set sFullName='Cristiano' ,sfullname='Ronaldo'
 where sno=104
 go
 select *from [dbo].[tbl_fest]

 delete[dbo].[tbl_fest]
 where sFullName='Surya'

---Task5------------------------------
use AdventureWorks2019
go
select Name,DaysToManufacture
from Production.Product
where DaysToManufacture=(select DaysToManufacture from Production.Product where name='Blade')

---Task6-------------------------------
select max(Weight)Heaviest_Prodcut,ProductModelID
from
Production.Product
group by ProductModelID

---Task7-------------------------------
select FirstName,LastName,name'Territory Name',[Group]'Region'
from sales.SalesTerritory st
join sales.SalesPerson sp
on sp.TerritoryID=st.TerritoryID
join Person.Person per
on per.BusinessEntityID=sp.BusinessEntityID
where st.SalesYTD=(select max(salesytd)from Sales.SalesTerritory)
