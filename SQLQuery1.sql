create database BookRentalManagements;
go
use BookRentalManagements;

go
create table Books(
BookId int primary key Identity (1,1),
Title nvarchar (50),
Author nvarchar (50),
RentalPrice decimal (10,2))


