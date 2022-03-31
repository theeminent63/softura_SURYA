use Trial
go

create table RegistrationForms
(
RegistrationID int identity(13000,1),
FirstName char(15),
LastName char(15),
EmailID char(20),
DatofBirth varchar(10),
Gender varchar(5),
PhoneNo char(10),
Adress varchar(50),
Pincode varchar(10),
State varchar(10),
District varchar(10)
constraint Ak_reg primary key (RegistrationID)
)

select * from RegistrationForms

insert RegistrationForms values('Cristiano','Ronaldo','Ronaldo12@g.com','2/5/85','M','9876543','NO:15,Olymbia','600055','Portuguese','ssss')

create table sqltask
(
RegistrationID int identity(13000,1),
sqltask char(20)
constraint chk_task check (sqltask in('MorningShift','EveningShift','NightShift')),
Joiningdate date default getdate(),
constraint pk_task primary key (RegistrationID),
constraint FK_key foreign key (RegistrationID) references RegistrationForms(RegistrationID)
)

insert into sqltask(RegistrationID,sqltask)
values(13000,'NightShift')
