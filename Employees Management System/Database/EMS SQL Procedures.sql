USE EMS
GO


--1.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'EmployeeRegistration'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.EmployeeRegistration
GO

CREATE PROCEDURE dbo.EmployeeRegistration
    @PassportID NVARCHAR(11),
    @Name NVARCHAR(100),
    @Surname NVARCHAR(100),
    @FathersName NVARCHAR(100),
    @Gender NVARCHAR(50),
    @Birth_Date DATE,
    @Marital_Status NVARCHAR(50),
    @Telephone NVARCHAR(50),
    @Email NVARCHAR(50),
    @Country INT,
    @City NVARCHAR(150),
    @Street NVARCHAR(250),
    @Department INT,
    @Position NVARCHAR(250),
    @Photo IMAGE,
    @Status NVARCHAR(50), 
    @Start_Date DATE ,
    @Additional_Info NVARCHAR(MAX)


AS
BEGIN
        INSERT INTO Employee ([Passport_ID], [Name], [Surname], [Father's_Name], [Gender], [Birth_Date], [Marital_Status], [Telephone],
        [Email], [Country], [City], [Street], [Department], [Position], [Photo], [Status], [Start_Date], [Additional_Info])

        VALUES 
        (
            @PassportID, @Name, @Surname, @FathersName, @Gender, @Birth_Date, @Marital_Status, @Telephone, @Email, @Country, 
            @City, @Street, @Department, @Position, @Photo, @Status, @Start_Date, @Additional_Info
        )
END
GO


--2.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddDepartment'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddDepartment
GO

CREATE PROCEDURE dbo.AddDepartment
    @Department NVARCHAR(250),
    @Group_Name NVARCHAR(250),
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN

    INSERT INTO Department ([Department], [Group_Name], [Additional_Info]) VALUES 
    (
        @Department, @Group_Name, @Additional_Info
    )
END
GO


--3.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'EmployeeAccountRegistration'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.EmployeeAccountRegistration
GO

CREATE PROCEDURE dbo.EmployeeAccountRegistration
    @EmployeeID UNIQUEIDENTIFIER,
    @Username NVARCHAR(50),
    @Password NVARCHAR(50),
    @Access_Level INT,
    @Permanent_Password BIT,
    @Password_Change_Period INT
AS
BEGIN

    INSERT INTO EmployeeAccount ([EmployeeID], [Username], [Password], [Access_Level], [Permanent_Password], [Password_Change_Period])
    VALUES
    (
        @EmployeeID, @Username, @Password, @Access_Level, @Permanent_Password, @Password_Change_Period
    )
END
GO


--4.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddBlacklist'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddBlacklist
GO

CREATE PROCEDURE dbo.AddBlacklist
    @EmployeeID UNIQUEIDENTIFIER,
    @Effective_Date DATETIME,
    @Reason NVARCHAR(250),
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN

    INSERT INTO Blacklist ([EmployeeID], [Effective_Date], [Reason], [Additional_Info])
    VALUES
    (
        @EmployeeID, @Effective_Date, @Reason, @Additional_Info
    )
END
GO


--5.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'EmployeeQRCardRegistration'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.EmployeeQRCardRegistration
GO

CREATE PROCEDURE dbo.EmployeeQRCardRegistration
    @EmployeeID UNIQUEIDENTIFIER,
    @QRCard_ID NVARCHAR(50),
    @Permanent_Card BIT,
    @Change_Period INT,
    @Blocked BIT,
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO EmployeeQRCard ([EmployeeID], [QRCard_ID], [Permanent_Card], [Change_Period], [Blocked], [Additional_Info])
    VALUES
    (
        @EmployeeID, @QRCard_ID, @Permanent_Card, @Change_Period, @Blocked, @Additional_Info
    )
END
GO


--6.Telegram Bot
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddTelegramBotUser'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddTelegramBotUser
GO

CREATE PROCEDURE dbo.AddTelegramBotUser
    @EmployeeID UNIQUEIDENTIFIER,
    @Bot_User_ID NVARCHAR(20),
    @Access_Level INT,
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO TelegramBotUsers ([EmployeeID], [Bot_User_ID], [Access_Level], [Additional_Info])
    VALUES
    (
        @EmployeeID, @Bot_User_ID, @Access_Level, @Additional_Info
    )
END
GO


--7.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddEmployeeSalary'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddEmployeeSalary
GO

CREATE PROCEDURE dbo.AddEmployeeSalary
    @EmployeeID UNIQUEIDENTIFIER,
    @Salary FLOAT,
    @Pay_Frequency INT,
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO EmployeeSalary ([EmployeeID], [Salary], [Pay_Frequency], [Additional_Info])
    VALUES
    (
        @EmployeeID, @Salary, @Pay_Frequency, @Additional_Info
    )
END
GO


--8.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddEmployeePayHistory'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddEmployeePayHistory
GO

CREATE PROCEDURE dbo.AddEmployeePayHistory
    @EmployeeID UNIQUEIDENTIFIER,
    @Payment_Date DATE,
    @From_Date DATE, 
    @To_Date DATE, 
    @Payment_Type NVARCHAR(30),
    @Rate FLOAT,
    @Award FLOAT,
    @Payment_State NVARCHAR(30),
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO EmployeePayHistory ([EmployeeID], [Payment_Date], [From_Date], [To_Date], [Payment_Type], [Rate],
    [Award], [Payment_State], [Additional_Info])
    VALUES
    (
        @EmployeeID, @Payment_Date, @From_Date, @To_Date, @Payment_Type, @Rate, @Award, @Payment_State, @Additional_Info
    )
END
GO


--9.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddEmployeeBankAccount'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddEmployeeBankAccount
GO

CREATE PROCEDURE dbo.AddEmployeeBankAccount
    @EmployeeID UNIQUEIDENTIFIER,
    @Card_Type NVARCHAR(50), 
    @Card_Number NVARCHAR(25),
    @Exp_Month INT,
    @Exp_Year INT,
    @Bank_Account_Number NVARCHAR(80),
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO EmployeeBankAccount ([EmployeeID], [Card_Type], [Card_Number], [Exp_Month], [Exp_Year], [Bank_Account_Number], [Additional_Info])
    VALUES
    (
        @EmployeeID, @Card_Type, @Card_Number, @Exp_Month, @Exp_Year, @Bank_Account_Number, @Additional_Info
    )
END
GO


--10.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'AddEmployeeVisit'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.AddEmployeeVisit
GO

CREATE PROCEDURE dbo.AddEmployeeVisit
    @EmployeeID NVARCHAR(50),
    @Date DATE,
    @Time TIME,
    @Type BIT
AS
BEGIN
    INSERT INTO EmployeeVisits ([EmployeeID], [Date], [Time], [Type])
    VALUES
    (
        @EmployeeID, @Date, @Time, @Type
    )
END
GO


=======================================================================

--1.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'DeleteEmployee'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.DeleteEmployee
GO

CREATE PROCEDURE dbo.DeleteEmployee
    @EmployeeID UNIQUEIDENTIFIER
AS
BEGIN
    DELETE FROM Employee WHERE [ID] = @EmployeeID
END
GO


--2.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'DeleteEmployeeAccount'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.DeleteEmployeeAccount
GO

CREATE PROCEDURE dbo.DeleteEmployeeAccount
    @EmployeeID NVARCHAR(50)
AS
BEGIN
    DELETE FROM EmployeeAccount WHERE [EmployeeID] = @EmployeeID
END
GO


--3.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'DeleteBlacklist'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.DeleteBlacklist
GO

CREATE PROCEDURE dbo.DeleteBlacklist
    @EmployeeID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Blacklist WHERE [EmployeeID] = @EmployeeID
END
GO


--4.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'DeleteEmployeeQRCard'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.DeleteEmployeeQRCard
GO

CREATE PROCEDURE dbo.DeleteEmployeeQRCard
    @EmployeeID NVARCHAR(50)
AS
BEGIN
    DELETE FROM EmployeeQRCard WHERE [EmployeeID] = @EmployeeID
END
GO


--5.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'DeleteTelegramBotUser'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.DeleteTelegramBotUser
GO

CREATE PROCEDURE dbo.DeleteTelegramBotUser
    @Bot_User_ID NVARCHAR(20)
AS
BEGIN
    DELETE FROM TelegramBotUsers WHERE [Bot_User_ID] = @Bot_User_ID
END
GO


--6.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'DeleteEmployeeBankAccount'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.DeleteEmployeeBankAccount
GO

CREATE PROCEDURE dbo.DeleteEmployeeBankAccount
    @ID INT
AS
BEGIN
    DELETE FROM EmployeeBankAccount WHERE [ID] = @ID
END
GO


=======================================================================


--1.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'EmployeeInfoEditing'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.EmployeeInfoEditing
GO

CREATE PROCEDURE dbo.EmployeeInfoEditing
    @ID NVARCHAR(50),
    @PassportID NVARCHAR(11),
    @Name NVARCHAR(100),
    @Surname NVARCHAR(100),
    @Birth_Date DATE,
    @Marital_Status NVARCHAR(50),
    @Telephone NVARCHAR(50),
    @Email NVARCHAR(50),
    @City NVARCHAR(150),
    @Street NVARCHAR(250),
    @Department INT,
    @Position NVARCHAR(250),
    @Status NVARCHAR(50)

AS
BEGIN
        UPDATE Employee SET
        [Passport_ID] = @PassportID, [Name] = @Name, [Surname] = @Surname, [Birth_Date] = @Birth_Date, 
        [Marital_Status] = @Marital_Status, [Telephone] = @Telephone,
        [Email] = @Email, [City] = @City, [Street] = @Street, [Department] = @Department, 
        [Position] = @Position, [Status] = @Status

        WHERE [ID] = @ID

END
GO


--2.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'EditingEmployeeSalary'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.EditingEmployeeSalary
GO

CREATE PROCEDURE dbo.EditingEmployeeSalary
    @EmployeeID NVARCHAR(50),
    @Salary FLOAT,
    @Pay_Frequency INT,
    @Additional_Info NVARCHAR(MAX)
AS
BEGIN
    UPDATE EmployeeSalary SET [Salary] = @Salary, [Pay_Frequency] = @Pay_Frequency, 
    [Additional_Info] = @Additional_Info
    WHERE [EmployeeID] = @EmployeeID
END
GO
