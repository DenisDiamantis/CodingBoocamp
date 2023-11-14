--USE master

--CREATE DATABASE TestDatabase

--GO
--USE TestDatabase

--USE master
--DROP DATABASE IF EXISTS TestDatabase
--CREATE DATABASE TestDatabase

--GO

--USE TestDatabase
--GO

--DROP SCHEMA IF EXISTS Inventory
--GO

--CREATE SCHEMA Inventory

USE TestDatabase;
GO

DROP TABLE IF EXISTS Inventory,Furniture
GO

CREATE TABLE Inventory.Furniture(
	FurnitureId INT IDENTITY(1,1),
	FurnitureType VARCHAR(50),
	FurnitureName VARCHAR(50),
	Price DECIMAL(18,4),
	Quantity INT,
	ReleaseDate DATE,
	CreateDate DATETIME,
	UpdateDate DATETIME
);
GO