create database saveexcel
Go
use saveexcel

create table Save_Excel(

LaDate nvarchar(max),
Matricule nvarchar(max) not null,
Nom varchar(max) not null,
Prenom varchar(max) not null,
NbrHeure int not null,
Prime int,
HeureDlla int

);

create table Save_Calcule (

LaDate nvarchar(max),
Matricule nvarchar(max) not null,
Nom varchar(max) not null,
Prenom varchar(max) not null,
NbrHeure int not null,
Prime int,
HeureDlla int,
HSupp int not null,
HNormal int not null,
HPrime int not null,
NbrJour float not null,
TPrime int 

);

create table Entrer (

username varchar(50) not null,
password varchar(50) not null

);

insert into Entrer values ('user','pass'),('cibel','cibel');

select distinct  * from Table_Save_Excel 

select * from Entrer
delete from Entrer

select * from Save_Excel 

select * from Save_Calcule

delete from Save_Excel
delete from Save_Calcule



