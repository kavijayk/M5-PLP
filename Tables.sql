

-----------------------------------------Users Table---------------------------
create table Project1.Users(
UserName varchar(25) primary key,
Pasword varchar(35) not null,
UserType varchar(15) check (UserType in('Admin', 'Buyer', 'seller'))
)

select * from  Project1.Users
insert into Project1.Users values('Admin','password','Admin')
--------------------------------Seller Table-----------------------------------
drop table project1.Seller
create table project1.Seller(
SellerId int identity primary key,
UserName varchar(25) not null,
FirstName varchar(25) not null,
LastName varchar(25),
DateOfBirth Date not null,
PhoneNumber varchar(10) not null,
Adress varchar(250) not null,
StateId int not null,
CityId int not null,
EmailId varchar(50) not null,
 constraint Fk_Seller_StateId foreign key(StateId) References Project1.States(StateId),
 constraint Fk_Seller_CityId  foreign key(CityId) References Project1.City(CityId)
)

ALTER TABLE project1.Seller
DROP CONSTRAINT Fk_Seller_StateId;

ALTER TABLE project1.Seller
DROP CONSTRAINT Fk_Seller_CityId;


insert into Project1.Seller values('vijay Kumar','vijay','kumar','1997-08-04',9876543210,'Hyderabad',1,1,'vijay@gmail.com')

select * from project1.Seller
sp_help 'project1.Seller'
--------------------------------------------/*Creating Buyer Table*/--------------------------------------------(execute)
create table Project1.Buyer
(
	BuyerId int identity primary key,
	UserName varchar(25) not null,
	FirstName varchar(25) not null,
	LastName varchar(25),
	DateOfBirth Date not null,
	PhoneNumber varchar(10) not null,
	EmailId varchar(50) not null,
	Adress varchar(70) not null
)
insert into Project1.Buyer values('Naveen','Naveen','Kankanala','1997-05-13',9533532199,'Naveen@gmail.com','Hyderabad')
select * from Project1.Buyer
--------------------------------------------CART--------------------------------------------------------------------------------
go
create table Project1.Cart
(
	CartId int identity primary key,
	BuyerId int not null,
	PropertyId int not null
	constraint Fk_Cart_Property foreign key (PropertyId) References Project1.Property(PropertyId)
)

insert into Project1.Cart values(1001,1)
select * from Project1.Cart
-----------------------------------------------SELLER------------------------------------------------------------------------------------
go
create table project1.Seller
(
	SellerId int identity primary key,
	UserName varchar(25) not null,
	FirstName varchar(25) not null,
	LastName varchar(25),
	DateOfBirth Date not null,
	PhoneNumber varchar(10) not null,
	Adress varchar(250) not null,
	StateId int not null,
	CityId int not null,
	EmailId varchar(50) not null,
	constraint Fk_Seller_StateId foreign key(StateId) References Project1.States(StateId),
	constraint Fk_Seller_CityId  foreign key(CityId) References Project1.City(CityId)
)
insert into Project1.Seller values('vijay Kumar','vijay','kumar','1997-08-04',9876543210,'Hyderabad',1,1,'vijay@gmail.com')

select * from project1.Seller
-------------------------------------------------------IMAGES----------------------------------------------
create table Project1.Images
(
	ImageId int identity primary key,
	PropertyId int not null,
	[Image] varchar(50) not null,
	constraint Fk_Image_Property foreign key (PropertyId) References Project1.Property(PropertyId)
)

select * from project1.images
-----------------------------------------------------PROPERTY------------------------------------------------------------------------
create table Project1.Property(
PropertyId int identity primary key,
PropertyName varchar(50) not null,
PropertyType Varchar(15) not null,

Descript varchar(250) ,
Adress varchar(250) not null,
PriceRange Money not null,
InitialDeposit Money not null,
LandMark varchar(25) not null,
IsActive Bit not null,
SellerId int not null,
foreign key(SellerId) References Project1.Seller(SellerId)
)

insert into Project1.Property values('EHS Villas','Gated Community','Well furnished','Vijay Layout',10000000,50000,'Opp Indian Oil',1,1)

select * from Project1.Property
--------------------------------------City Table-----------------------------------

create table Project1.City(
CityId int identity primary key,
CityName varchar(50) not null,
StateId int not null,
constraint Fk_City_StateId foreign key(StateId) References Project1.States(StateId)
)
insert into Project1.City values('Mumbai',3) ,('Pune',3),('Hyderabad',4),('Nizamabad',4),('Visakhapatnam',1),('Vijayawada',1),('Bangalore',2),('Mysore',2)
ALTER TABLE project1.City
DROP CONSTRAINT Fk_City_StateId;

select * from Project1.City
sp_help 'Project1.City'
-------------------------------------States Table----------------------------------

create table Project1.States(
StateId int identity primary key,
StateName varchar(30)
)

insert into Project1.States values ('Andhra Pradesh'),('Karnataka'),('Maharashtra'),('Telangana')

select * from Project1.States