USE master;
GO

CREATE DATABASE CorpHub;
GO

USE CorpHub;
GO

/******************************************************************************************
SECTION 1 : TABLE CREATION
******************************************************************************************/

IF OBJECT_ID('Assignments','U') IS NOT NULL DROP TABLE Assignments;
IF OBJECT_ID('Staff','U') IS NOT NULL DROP TABLE Staff;
IF OBJECT_ID('Divisions','U') IS NOT NULL DROP TABLE Divisions;
GO

CREATE TABLE Divisions
(
    DivisionID INT IDENTITY PRIMARY KEY,
    DivisionName VARCHAR(60) NOT NULL UNIQUE
);
GO

CREATE TABLE Staff
(
    StaffID INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(60) NOT NULL,
    EmailAddress VARCHAR(100) UNIQUE,
    Age INT CHECK (Age >= 18),
    MonthlyPay INT CHECK (MonthlyPay > 0),
    DivisionID INT,
    JoinedOn DATETIME DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT FK_Staff_Division
        FOREIGN KEY (DivisionID) REFERENCES Divisions(DivisionID)
);
GO

CREATE TABLE Assignments
(
    TaskID INT,
    StaffID INT,
    TaskTitle VARCHAR(60),
    CONSTRAINT PK_Assignments PRIMARY KEY (TaskID, StaffID)
);
GO

/******************************************************************************************
SECTION 2 : DATA INSERTION
******************************************************************************************/

INSERT INTO Divisions (DivisionName)
VALUES ('Admin'), ('Technology'), ('Accounts');

INSERT INTO Staff (FullName, EmailAddress, Age, MonthlyPay, DivisionID)
VALUES
('Riya Sharma', 'riya@mail.com', 24, 48000, 1),
('Aman Verma', 'aman@mail.com', 29, 62000, 2),
('Neha Singh', 'neha@mail.com', 27, 70000, 2),
('Karan Mehta', 'karan@mail.com', 35, 52000, 3),
('Pooja Iyer', 'pooja@mail.com', 31, 66000, 2);

INSERT INTO Assignments
VALUES
(101, 1, 'Recruitment'),
(102, 2, 'Backend System'),
(103, 2, 'API Development'),
(104, 3, 'Data Reports');
GO

/******************************************************************************************
SECTION 3 : BASIC QUERIES & AGGREGATES
******************************************************************************************/

SELECT * FROM Staff;

SELECT DISTINCT DivisionID FROM Staff;

SELECT DivisionID, COUNT(*) AS StaffCount
FROM Staff
GROUP BY DivisionID
HAVING COUNT(*) > 1;

SELECT
SUM(MonthlyPay) AS TotalPay,
AVG(MonthlyPay) AS AveragePay,
MIN(MonthlyPay) AS LowestPay,
MAX(MonthlyPay) AS HighestPay,
COUNT(*) AS TotalStaff,
STDEV(MonthlyPay) AS PayStdDev,
VAR(MonthlyPay) AS PayVariance
FROM Staff;
GO

/******************************************************************************************
SECTION 4 : JOINS
******************************************************************************************/

SELECT s.FullName, d.DivisionName
FROM Staff s
INNER JOIN Divisions d
ON s.DivisionID = d.DivisionID;

SELECT s.FullName, d.DivisionName
FROM Staff s
LEFT JOIN Divisions d
ON s.DivisionID = d.DivisionID;

SELECT s.FullName, d.DivisionName
FROM Staff s
RIGHT JOIN Divisions d
ON s.DivisionID = d.DivisionID;

SELECT s.FullName, d.DivisionName
FROM Staff s
FULL OUTER JOIN Divisions d
ON s.DivisionID = d.DivisionID;

SELECT s.FullName, d.DivisionName
FROM Staff s
CROSS JOIN Divisions d;

SELECT x.FullName AS StaffA, y.FullName AS StaffB
FROM Staff x
JOIN Staff y
ON x.DivisionID = y.DivisionID
AND x.StaffID < y.StaffID;
GO

/******************************************************************************************
SECTION 5 : SUBQUERIES
******************************************************************************************/

SELECT FullName
FROM Staff
WHERE MonthlyPay =
(
    SELECT MAX(MonthlyPay)
    FROM Staff
);

SELECT FullName
FROM Staff
WHERE DivisionID IN
(
    SELECT DivisionID FROM Divisions
);

SELECT s1.FullName
FROM Staff s1
WHERE MonthlyPay >
(
    SELECT AVG(MonthlyPay)
    FROM Staff s2
    WHERE s1.DivisionID = s2.DivisionID
);

SELECT FullName,
(
    SELECT DivisionName
    FROM Divisions d
    WHERE d.DivisionID = s.DivisionID
) AS Division
FROM Staff s;

SELECT DivisionID, AvgPay
FROM
(
    SELECT DivisionID, AVG(MonthlyPay) AS AvgPay
    FROM Staff
    GROUP BY DivisionID
) AS DivisionAvg
WHERE AvgPay > 55000;
GO

/******************************************************************************************
SECTION 6 : STORED PROCEDURES
******************************************************************************************/

IF OBJECT_ID('ShowAllStaff','P') IS NOT NULL DROP PROCEDURE ShowAllStaff;
GO
CREATE PROCEDURE ShowAllStaff
AS
BEGIN
    SELECT * FROM Staff;
END;
GO
EXEC ShowAllStaff;
GO

IF OBJECT_ID('StaffByDivision','P') IS NOT NULL DROP PROCEDURE StaffByDivision;
GO
CREATE PROCEDURE StaffByDivision
@Division VARCHAR(60)
AS
BEGIN
    SELECT s.FullName, d.DivisionName
    FROM Staff s
    JOIN Divisions d ON s.DivisionID = d.DivisionID
    WHERE d.DivisionName = @Division;
END;
GO
EXEC StaffByDivision 'Technology';
GO

IF OBJECT_ID('DivisionPayTotal','P') IS NOT NULL DROP PROCEDURE DivisionPayTotal;
GO
CREATE PROCEDURE DivisionPayTotal
@Division VARCHAR(60),
@TotalPay INT OUTPUT
AS
BEGIN
    SELECT @TotalPay = SUM(MonthlyPay)
    FROM Staff s
    JOIN Divisions d ON s.DivisionID = d.DivisionID
    WHERE d.DivisionName = @Division;
END;
GO

DECLARE @Result INT;
EXEC DivisionPayTotal 'Admin', @Result OUTPUT;
PRINT @Result;
GO

/******************************************************************************************
SECTION 7 : FUNCTIONS
******************************************************************************************/

IF OBJECT_ID('CalculateBonus','FN') IS NOT NULL DROP FUNCTION CalculateBonus;
GO
CREATE FUNCTION CalculateBonus(@Pay INT)
RETURNS INT
AS
BEGIN
    RETURN @Pay * 0.15;
END;
GO

SELECT FullName, MonthlyPay, dbo.CalculateBonus(MonthlyPay) AS Bonus
FROM Staff;
GO

IF OBJECT_ID('StaffByDivisionID','IF') IS NOT NULL DROP FUNCTION StaffByDivisionID;
GO
CREATE FUNCTION StaffByDivisionID(@DivID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT FullName, MonthlyPay
    FROM Staff
    WHERE DivisionID = @DivID
);
GO

SELECT * FROM dbo.StaffByDivisionID(2);
GO

/******************************************************************************************
SECTION 8 : VIEWS
******************************************************************************************/

IF OBJECT_ID('StaffPayView','V') IS NOT NULL DROP VIEW StaffPayView;
GO
CREATE VIEW StaffPayView
AS
SELECT FullName, MonthlyPay FROM Staff;
GO

IF OBJECT_ID('TechStaffView','V') IS NOT NULL DROP VIEW TechStaffView;
GO
CREATE VIEW TechStaffView
AS
SELECT FullName, MonthlyPay
FROM Staff
WHERE DivisionID = 2;
GO

IF OBJECT_ID('StaffDivisionView','V') IS NOT NULL DROP VIEW StaffDivisionView;
GO
CREATE VIEW StaffDivisionView
AS
SELECT s.FullName, d.DivisionName
FROM Staff s
JOIN Divisions d ON s.DivisionID = d.DivisionID;
GO

IF OBJECT_ID('DivisionAveragePay','V') IS NOT NULL DROP VIEW DivisionAveragePay;
GO
CREATE VIEW DivisionAveragePay
AS
SELECT DivisionID, AVG(MonthlyPay) AS AvgPay
FROM Staff
GROUP BY DivisionID;
GO

/******************************************************************************************
SECTION 9 : CURSOR
******************************************************************************************/

DECLARE @Name VARCHAR(60);

DECLARE StaffCursor CURSOR FOR
SELECT FullName FROM Staff;

OPEN StaffCursor;
FETCH NEXT FROM StaffCursor INTO @Name;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Staff Member: ' + @Name;
    FETCH NEXT FROM StaffCursor INTO @Name;
END;

CLOSE StaffCursor;
DEALLOCATE StaffCursor;
GO

/******************************************************************************************
FINAL CHECK
******************************************************************************************/

SELECT * FROM Staff;
SELECT * FROM Divisions;
SELECT * FROM Assignments;
GO
