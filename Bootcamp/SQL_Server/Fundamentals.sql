USE master

CREATE DATABASE TestDatabase
------------------------------------------------------------------------------------
GO
USE TestDatabase

USE master
DROP DATABASE IF EXISTS TestDatabase
CREATE DATABASE TestDatabase
GO
------------------------------------------------------------------------------------
USE TestDatabase
GO

DROP SCHEMA IF EXISTS Inventory
GO

CREATE SCHEMA Inventory
------------------------------------------------------------------------------------
USE TestDatabase;
GO

DROP TABLE IF EXISTS Inventory.Furniture
GO

CREATE TABLE Inventory.Furniture(
	FurnitureId INT IDENTITY(1,1),
	FurnitureType VARCHAR(50) NULL,
	FurnitureName VARCHAR(50) NOT NULL,
	Price DECIMAL(18,4),
	Quantity INT DEFAULT(0) NOT NULL,
	ReleaseDate DATE,
	CreateDate DATETIME,
	UpdateDate DATETIME
);
GO
------------------------------------------------------------------------------------
INSERT INTO Inventory.Furniture(
	FurnitureType,FurnitureName,
	Price,Quantity,ReleaseDate,
	CreateDate,UpdateDate
)VALUES(
	'Couch','The Super Deluxe',
	1999.99,34,'2023-08-15',
	'2023-08-15 20:00:00',
	'2023-08-15 20:00:00'

);
GO
------------------------------------------------------------------------------------
INSERT INTO Inventory.Furniture(
	FurnitureName,
	Quantity
)VALUES(
	'The Super Deluxe',
	34
);
GO

------------------------------------------------------------------------------------

USE TestDatabase;
GO

SELECT FurnitureName,Price,Quantity 
FROM Inventory.Furniture 
GO

------------------------------------------------------------------------------------

USE TestDatabase;
GO

UPDATE Inventory.Furniture 
SET Price=1399.99
GO

------------------------------------------------------------------------------------

USE TestDatabase;
GO

ALTER TABLE Inventory.Furniture 
ADD SubCategory VARCHAR(50)

ALTER TABLE Inventory.Furniture 
Drop CONSTRAINT [DF__Furniture__Quant__3C69FB99]

ALTER TABLE Inventory.Furniture 
DROP COLUMN SubCategory
