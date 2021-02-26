
create table Colors
(
    ColorId int identity(1,1) not null,
    ColorName nvarchar(255) not null,
    CONSTRAINT PK_Colors PRIMARY KEY (ColorId)

)

create table Brands
(
     BrandId int IDENTITY(1,1) NOT NULL,
     BrandName nvarchar(50) NOT NULL,
     CONSTRAINT PK_Brands PRIMARY KEY (BrandId)

)

create table Cars
(
      CarId int identity(1,1) not null,
      BrandId int not null,
      ColorId int not null,
      ModelYear int not null,
      DailyPrice decimal not null,
      Description nvarchar(255) not null,
      primary key(Id),
      CONSTRAINT PK_Cars PRIMARY KEY (CarId),
      FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
      FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
)

create table Users
(
      UserId int identity(1,1) not null,
      FirstName nvarchar(255) not null,
      LastName nvarchar(255) not null,
      Email nvarchar(255) not null,
      Password nvarchar(255) not null,
      CONSTRAINT PK_Users PRIMARY KEY (UserId)
)

create table Customers
(
     CustomerId int identity(1,1) not null,
     UserId int not null,
     CompanyName nvarchar(255) not null,
     CONSTRAINT PK_Customers PRIMARY KEY (CustomerId),
     foreign key(UserId) references Users(UserId)
)

create table Rentals
(
     RentalId int identity(1,1) not null,
     CarId int not null,
     CustomerId int not null,
     RentDate datetime not null,
     ReturnDate datetime,
     CONSTRAINT PK_Rentals PRIMARY KEY (RentalId),
     foreign key(CarId) references Cars(CarId),
     foreign key(CustomerId) references Customers(CustomerId)
)
