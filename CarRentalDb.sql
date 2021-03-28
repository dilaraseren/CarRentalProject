CREATE TABLE Cars(
Id int primary key identity(1,1),
BrandId int,
ColorId int,
ModelYear int,
DailyPrice int,
_Description nvarchar(50)
)

CREATE TABLE Colors(
ColorId int primary key identity(1,1),
ColorName nvarchar(25)
)

CREATE TABLE Brands(
BrandId int primary key identity(1,1),
BrandName nvarchar(25)
)
CREATE TABLE Customers(
CustomerId int primary key identity(1,1),
UserId int,
CompanyName nvarchar(50)
)

CREATE TABLE Rentals(
Id int primary key identity(1,1),
CarId int,
CustomerId int,
RentDate nvarchar(25), 
ReturnDate nvarchar(25)

)

CREATE TABLE CarDetailDtos(
Id int primary key identity(1,1),
BrandId int,
BrandName nvarchar(50),
ColorId int,
ColorName nvarchar(50),
ModelYear int,
DailyPrice int,
_Description nvarchar(50)

)



CREATE TABLE CarImages(
Id int primary key identity(1,1),
CarId int,
ImagePath text,
Date DateTime,

)

CREATE TABLE CustomerDetailDtos(
Id int primary key identity(1,1),
FirstName nvarchar(100),
LastName nvarchar(100),
CompanyName nvarchar(100),
RentDate date,
ReturnDate date

)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,_Description)
values 

	            (1,1,2015,600,'Dizel Otomatik'),
	            (2,1,2014,125,'Dizel Manuel'),
	            (3,1,2019,400,'Dizel Otomatik'),
	            (4,2,2017,175,'Dizel Manuel'),
                (5,3,2015,200,'Dizel Manuel'),
	            (6,2,2016,350,'Dizel Otomatik'),
	            (7,1,2017,160,'Dizel Otomatik'),
	            (8,1,2020,300,'Benzin Otomatik'),
	            (9,3,2016,400,'Benzin Otomatik'),
	            (10,2,2018,100,'Dizel Manuel')



INSERT INTO Colors(ColorName)
VALUES
('Beyaz'),('Siyah'),('Gri') ,('Bordo')

INSERT INTO Brands (BrandName)
VALUES
('Audi A5'),('Fiat Egea'),('Volkswagen'),('Dacia Sandero'),('Fiat Linea'),('Opel Astra'),('Renault Fluence'),('Kia Picanto'),('BMW 5 Serisi'),('Peugeot 301') 


INSERT INTO CarDetailDtos(BrandId,BrandName,ColorId,ColorName,ModelYear,DailyPrice,_Description)
values 

	            (1,'Audi A5',1,'Beyaz',2015,600,'Dizel Otomatik'),
	            (2,'Fiat Egea',1,'Beyaz',2014,125,'Dizel Manuel'),
	            (3,'Volkswagen',1,'Beyaz',2019,400,'Dizel Otomatik'),
	            (4,'Dacia Sandero',2,'Siyah',2017,175,'Dizel Manuel'),
                (5,'Fiat Linea',3,'Gri',2015,200,'Dizel Manuel'),
	            (6,'Opel Astra',2,'Siyah',2016,350,'Dizel Otomatik'),
	            (7,'Renault Fluence',1,'Beyaz',2017,160,'Dizel Otomatik'),
	            (8,'Kia Picanto',1,'Beyaz',2020,300,'Benzin Otomatik'),
	            (9,'BMW 5 Serisi',3,'Gri',2016,400,'Benzin Otomatik'),
	            (10,'Peugeot 301',2,'Siyah',2018,100,'Dizel Manuel')


	          

