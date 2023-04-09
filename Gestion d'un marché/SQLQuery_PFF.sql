create database DB_Marche
go
use DB_Marchet
go 
create table Categorie(catid int primary key, catnom varchar(30), catdes varchar(100));
go
create table Produit(prodid int primary key, prodnom varchar(30), prodprix float, prodqtt int , prodcat varchar(50));
go
create table Vendeur(vid int primary key, vnom varchar(50),vage int, vphone int, vpass varchar(50));
create table Facture(fid int primary key, vnom varchar(50),vdate date,montanttotal int);
select * from Produit;
select * from Categorie;
select * from Vendeur;
drop table Facture

