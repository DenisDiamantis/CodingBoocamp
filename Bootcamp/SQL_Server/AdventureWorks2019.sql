USE AdventureWorks2019;
GO
---------------------------------------------------------
SELECT * FROM HumanResources.Department;
---------------------------------------------------------
SELECT --TOP 3
DepartmentID,Name,GroupName,ModifiedDate
FROM 
HumanResources.Department;
---------------------------------------------------------
SELECT
DepartmentID,Name,GroupName,ModifiedDate
FROM 
HumanResources.Department
WHERE DepartmentID > 7;
--WHERE DepartmentID = 7;
--WHERE DepartmentID <> 7;
---------------------------------------------------------
SELECT 
FirstName,LastName,Title
FROM 
Person.Person
WHERE Title IS NOT NULL;
--WHERE Title IS NULL;
---------------------------------------------------------
SELECT
DepartmentID,Name,GroupName,ModifiedDate
FROM 
HumanResources.Department
WHERE DepartmentID IN(7,11);
--WHERE DepartmentID NOT IN(7,11);
--WHERE DepartmentID BETWEEN 7 AND 14;
--WHERE DepartmentID NOT BETWEEN 7 AND 14;
---------------------------------------------------------
SELECT
DepartmentID,Name,GroupName,ModifiedDate
FROM 
HumanResources.Department
WHERE DepartmentID BETWEEN 7 AND 14 
OR GroupName='Manufacturing';
---------------------------------------------------------
SELECT 
DepartmentID,Name,GroupName,ModifiedDate
INTO HumanResources.DepartmentCopy
FROM HumanResources.Department
WHERE DepartmentID > 10;
---------------------------------------------------------
SELECT 
DepartmentID,Name,GroupName,ModifiedDate
FROM HumanResources.Department
ORDER BY Name;
--ORDER BY Name DESC;
---------------------------------------------------------
SELECT 
COUNT(DISTINCT GroupName)
--COUNT(*)
FROM HumanResources.Department
---------------------------------------------------------
SELECT 
GroupName,Name
FROM HumanResources.Department
GROUP BY GroupName,Name
---------------------------------------------------------
SELECT 
GroupName,
MIN(DepartmentID) AS Min,
MAX(DepartmentID) AS Max,
COUNT(*) AS COUNT,
SUM(DepartmentID) AS SUM
FROM HumanResources.Department
GROUP BY GroupName
HAVING SUM(DepartmentID) > 15
---------------------------------------------------------
CREATE TABLE Customers
(
	ID INT PRIMARY KEY,
	CustomerName VARCHAR(50),
	CustomerAge SMALLINT,
	CustomerCountry VARCHAR(50)
)
---------------------------------------------------------
INSERT INTO 
Customers(ID,CustomerName,CustomerAge,CustomerCountry)
VALUES(1,'Salvador',23,'Brazil')
INSERT INTO 
Customers(ID,CustomerName,CustomerAge,CustomerCountry)
VALUES(2,'Lawrence',60,'China')
INSERT INTO 
Customers(ID,CustomerName,CustomerAge,CustomerCountry)
VALUES(3,'Ernest',23,'India')
---------------------------------------------------------
CREATE TABLE CustomerOrders
(
	ID INT PRIMARY KEY,
	OrderDate DATETIME,
	CustomerId INT FOREIGN KEY REFERENCES CUSTOMERS(ID),
	Amount BIGINT
)
---------------------------------------------------------
INSERT INTO 
CustomerOrders(ID,OrderDate,CustomerId,Amount)
VALUES(
1,CAST('29-May-2019' AS DATETIME),2,1968.45
)
INSERT INTO 
CustomerOrders(ID,OrderDate,CustomerId,Amount)
VALUES(
2,CAST('28-Feb-2019' AS DATETIME),3,296.45
)
INSERT INTO 
CustomerOrders(ID,OrderDate,CustomerId,Amount)
VALUES(
3,CAST('29-Jun-2019' AS DATETIME),1,568.66
)
INSERT INTO 
CustomerOrders(ID,OrderDate,CustomerId,Amount)
VALUES(
4,CAST('29-Apr-2019' AS DATETIME),1,968.45
)
---------------------------------------------------------
DROP TABLE CustomerOrders
---------------------------------------------------------
CREATE TABLE CustomerOrders
(
	ID INT PRIMARY KEY,
	OrderDate DATETIME,
	CustomerId INT,
	Amount BIGINT
)
---------------------------------------------------------
ALTER TABLE CustomerOrders
ADD CONSTRAINT FK_CustomerCheck FOREIGN KEY (CustomerID)
REFERENCES Customers(ID)
---------------------------------------------------------
CREATE TABLE CustomerSales
(
	ID INT PRIMARY KEY,
	SaleDate DATETIME,
	CustomerId INT FOREIGN KEY REFERENCES CUSTOMERS(ID)
		ON UPDATE CASCADE ON DELETE CASCADE,
	SaleAmount MONEY
)
---------------------------------------------------------
INSERT INTO 
CustomerSales(ID,SaleDate,CustomerId,SaleAmount)
VALUES(
1,CAST('05-Mar-2019' AS DATETIME),1,726.24)
---------------------------------------------------------
DELETE FROM Customers WHERE ID=1
---------------------------------------------------------