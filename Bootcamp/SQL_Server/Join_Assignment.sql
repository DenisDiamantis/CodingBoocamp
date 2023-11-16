USE AdventureWorks2019
GO
-------------------------------------------------------------
SELECT
PersonType,
FirstName,
ISNULL(MiddleName,'No Middle Name'),
COALESCE(MiddleName,Lastname,'No Middle Name'),
LastName
FROM Person.Person
-------------------------------------------------------------
SELECT
EDH.BusinessEntityID,
Person.FirstName,
Person.LastName,
EDH.DepartmentID,
EDH.StartDate,
EDH.EndDate
FROM HumanResources.EmployeeDepartmentHistory AS EDH
JOIN Person.Person
ON Person.BusinessEntityID=EDH.BusinessEntityID
-------------------------ASSIGNMENT----------------------------
CREATE TABLE states 
(
	state_code INT PRIMARY KEY,
	home_state VARCHAR(50)
)
CREATE TABLE jobs 
(
	job_code VARCHAR(50) PRIMARY KEY,
	job VARCHAR(50),
)
CREATE TABLE employees 
(
	employee_id VARCHAR(50) PRIMARY KEY,
	name VARCHAR(50),
	state_code INT FOREIGN KEY REFERENCES states(state_code)
)
CREATE TABLE employee_roles 
(
	employee_id VARCHAR(50),
	job_code VARCHAR(50),
	PRIMARY KEY (employee_id,job_code),
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
	FOREIGN KEY (job_code) REFERENCES jobs(job_code)
)
---------------------------------------------------------------
INSERT INTO 
states(state_code,home_state)
VALUES(26,'Michigan')
INSERT INTO 
states(state_code,home_state)
VALUES(56,'Wyoming')
---------------------------------------------------------------
INSERT INTO 
jobs(job_code,job)
VALUES('J01','Chef')
INSERT INTO 
jobs(job_code,job)
VALUES('J02','Waiter')
INSERT INTO 
jobs(job_code,job)
VALUES('J03','Bartender')
---------------------------------------------------------------
INSERT INTO 
employee_roles(employee_id,job_code)
VALUES('E001','J01')
INSERT INTO 
employee_roles(employee_id,job_code)
VALUES('E001','J02')
INSERT INTO 
employee_roles(employee_id,job_code)
VALUES('E002','J02')
INSERT INTO 
employee_roles(employee_id,job_code)
VALUES('E002','J03')
INSERT INTO 
employee_roles(employee_id,job_code)
VALUES('E003','J01')
---------------------------------------------------------------
INSERT INTO 
employees(employee_id,name,state_code)
VALUES('E001','Alice',26)
INSERT INTO 
employees(employee_id,name,state_code)
VALUES('E002','Bob',56)
INSERT INTO 
employees(employee_id,name,state_code)
VALUES('E003','Alice',56)
---------------------------------------------------------------
SELECT
employees.employee_id,employees.name,jobs.job,states.home_state
FROM employees
JOIN employee_roles ON
employees.employee_id=employee_roles.employee_id
JOIN jobs ON 
employee_roles.job_code=jobs.job_code
JOIN states ON 
employees.state_code=states.state_code
---------------------------------------------------------------