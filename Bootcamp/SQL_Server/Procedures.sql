USE AdventureWorks2019;
GO;
CREATE OR ALTER PROCEDURE HumanResources.spDepartments_Get
AS
BEGIN
	SELECT
		DepartmentID,Name,GroupName,ModifiedDate
	FROM HumanResources.Department AS Department
END
EXEC HumanResources.spDepartments_Get