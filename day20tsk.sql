use AdventureWorks2019
go

---------1-------------------

select Title,FirstName,LastName
from Person.Person
where Title is not null

----------2----------------

select FirstName,LastName
from Person.Person
where FirstName like '%a' and LastName like '%a'

-----------3-----------------

select   CurrencyCode,Name
from Sales.Currency 

------------4---------------

SELECT DepartmentID,Name,GroupName,ModifiedDate INTO HR_dpt
FROM HumanResources.Department 
select * from HR_dpt

-------------5----------------

create table c_tb
(
sno int identity(1,1),
sFullName varchar(20),
sLastName varchar(20),
EmailID varchar(20),
)
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
insert c_tb values('Cristiano','Ronaldo','Ronaldo@gmail.com')
select * from c_tb

------------6---------------------

select BusinessEntityID,AddressTypeID
from HumanResources.Department dpt 
inner join Person.BusinessEntityAddress Badd
on dpt.DepartmentID = Badd.AddressTypeID

-------------7----------------------

select distinct GroupName
from HumanResources.Department

-----------8------------------------

select pp.standardcost,sum(listprice) sum1,sum(pp.standardcost) Sum2
from Production.Product pp
join Production.ProductCostHistory pcst
on pp.ProductID = pcst.ProductID
group by pp.StandardCost

-------------9---------------------

select DATEDIFF(day,StartDate, endDate) AS 'Years On Role'  
from  HumanResources.EmployeeDepartmentHistory

--------------10--------------------

select sum(SalesQuota) SumOfQuota
from Sales.SalesPersonQuotaHistory
where SalesQuota>5000 and salesquota<100000
group by SalesQuota

----------------11---------------

select Max(TaxRate) MaximuTaxRate
from Sales.SalesTaxRate

---------------12---------------------

select dpt.DepartmentID,emp.BusinessEntityID,ShiftId,BirthDate
from HumanResources.Employee emp
join HumanResources.Department dpt
on emp.BusinessEntityID =dpt.DepartmentID
join HumanResources.EmployeeDepartmentHistory ehis
on dpt.DepartmentID = ehis.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
----------------13----------------------

create view VW_new
as
select His.ShiftID,Emp.BirthDate,datediff(YY,emp.BirthDate,Getdate()) as age
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory His
on His.BusinessEntityID=emp.BusinessEntityID
join HumanResources.Department dept
on His.BusinessEntityID =dept.DepartmentID

go
select * from VW_new

-------------------14-------------------------

SELECT count(*) 
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],
[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]

---------------------16------------------------

select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null

----------------------17---------------------------

select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<=350 and LocationID=50

---------------------18---------------------------------

select pl.LocationID,Shelf,Name
from [Production].[ProductInventory] pp
join [Production].[Location] pl
on pp.LocationID=pl.LocationID

--------------------19-----------------------------------

select AddressID,AddressLine1,AddressLine2, pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince psp
join Person.Address pa
on psp.StateProvinceID=pa.StateProvinceID

----------------------20-----------------------------------

select sum([SubTotal]) SubTotal,sum([TaxAmt])TaxAmount
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]