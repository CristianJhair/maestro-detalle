CREATE DATABASE DBCOMPRA

USE DBCOMPRA

 create table COMPRA(
 IdCompra int primary key identity(1,1),
 NumeroDocumento varchar(10),
 RazonSocial varchar(60),
 Total decimal(10,2)
 )


 create table DETALLE_COMPRA(
 IdDetalleCompra int primary key identity(1,1),
 IdCompra int,
 Producto varchar(60),
 Precio decimal(10,2),
 Cantidad int,
 Total decimal(10,2),
 CONSTRAINT FK_IdVenta FOREIGN KEY (IdCompra) REFERENCES COMPRA(IdCompra)
 )