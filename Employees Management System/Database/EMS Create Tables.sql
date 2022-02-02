USE EMS
GO

--1.
IF OBJECT_ID('[dbo].[Employee]', 'U') IS NOT NULL
DROP TABLE [dbo].[Employee]
GO

CREATE TABLE [dbo].[Employee]
(
    [ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [Passport_ID] NVARCHAR(11) NOT NULL UNIQUE,
    [Name] NVARCHAR(100) NOT NULL,
    [Surname] NVARCHAR(100) NOT NULL,
    [Father's_Name] NVARCHAR(100) NOT NULL,
    [Gender] NVARCHAR(50) NOT NULL,
    [Birth_Date] DATE NOT NULL,
    [Marital_Status] NVARCHAR(50) NOT NULL,
    [Telephone] NVARCHAR(50) NOT NULL,
    [Email] NVARCHAR(50) NOT NULL,
    [Country] INT NOT NULL,
    [City] NVARCHAR(150) NOT NULL,
    [Street] NVARCHAR(250) NOT NULL,
    [Department] INT NOT NULL,
    [Position] NVARCHAR(250) NOT NULL,
    [Photo] IMAGE NOT NULL,
    [Status] NVARCHAR(50) NOT NULL,
    [Start_Date] DATE NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO


--2.
IF OBJECT_ID('[dbo].[Department]', 'U') IS NOT NULL
DROP TABLE [dbo].[Department]
GO

CREATE TABLE [dbo].[Department]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Department] NVARCHAR(250) NOT NULL,
    [Group_Name] NVARCHAR(250),
    [Additional_Info] NVARCHAR(MAX)

);
GO


--3.
IF OBJECT_ID('[dbo].[Countries]', 'U') IS NOT NULL
DROP TABLE [dbo].[Countries]
GO

CREATE TABLE [dbo].[Countries]
(
    [ID] INT NOT NULL PRIMARY KEY, 
    [Country] NVARCHAR(255) NOT NULL

);
GO


--4.
IF OBJECT_ID('[dbo].[EmployeeAccount]', 'U') IS NOT NULL
DROP TABLE [dbo].[EmployeeAccount]
GO

CREATE TABLE [dbo].[EmployeeAccount]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [Username] NVARCHAR(50) NOT NULL,
    [Password] NVARCHAR(50) NOT NULL,
    [Access_Level] INT DEFAULT 0 NOT NULL,
    [Permanent_Password] BIT DEFAULT 1 NOT NULL,
    [Password_Change_Period] INT,
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO


--5.
IF OBJECT_ID('[dbo].[Blacklist]', 'U') IS NOT NULL
DROP TABLE [dbo].[Blacklist]
GO

CREATE TABLE [dbo].[Blacklist]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [Effective_Date] DATETIME NOT NULL,
    [Reason] NVARCHAR(250) NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO


--6.
IF OBJECT_ID('[dbo].[EmployeeQRCard]', 'U') IS NOT NULL
DROP TABLE [dbo].[EmployeeQRCard]
GO

CREATE TABLE [dbo].[EmployeeQRCard]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [QRCard_ID] NVARCHAR(50) NOT NULL,
    [Permanent_Card] BIT NOT NULL,
    [Change_Period] INT,
    [Blocked] BIT NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO


--7.
IF OBJECT_ID('[dbo].[TelegramBotUsers]', 'U') IS NOT NULL
DROP TABLE [dbo].[TelegramBotUsers]
GO

CREATE TABLE [dbo].[TelegramBotUsers]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [Bot_User_ID] NVARCHAR(20) NOT NULL,
    [Access_Level] INT NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO



--8.
IF OBJECT_ID('[dbo].[EmployeeSalary]', 'U') IS NOT NULL
DROP TABLE [dbo].[EmployeeSalary]
GO

CREATE TABLE [dbo].[EmployeeSalary]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [Salary] FLOAT NOT NULL,
    [Pay_Frequency] INT NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO


--9.
IF OBJECT_ID('[dbo].[EmployeePayHistory]', 'U') IS NOT NULL
DROP TABLE [dbo].[EmployeePayHistory]
GO

CREATE TABLE [dbo].[EmployeePayHistory]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [Payment_Date] DATE NOT NULL, 
    [From_Date] DATE NOT NULL, 
    [To_Date] DATE NOT NULL, 
    [Payment_Type] NVARCHAR(30) NOT NULL, 
    [Rate] FLOAT NOT NULL, 
    [Award] FLOAT, 
    [Payment_State] NVARCHAR(30) NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO


--10.
IF OBJECT_ID('[dbo].[EmployeeBankAccount]', 'U') IS NOT NULL
DROP TABLE [dbo].[EmployeeBankAccount]
GO

CREATE TABLE [dbo].[EmployeeBankAccount]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL,
    [Card_Type] NVARCHAR(50) NOT NULL, 
    [Card_Number] NVARCHAR(25) NOT NULL,
    [Exp_Month] INT NOT NULL,
    [Exp_Year] INT NOT NULL,
    [Bank_Account_Number] NVARCHAR(80) NOT NULL,
    [Additional_Info] NVARCHAR(MAX),
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO

--11.
IF OBJECT_ID('[dbo].[EmployeeVisits]', 'U') IS NOT NULL
DROP TABLE [dbo].[EmployeeVisits]
GO

CREATE TABLE [dbo].[EmployeeVisits]
(
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [EmployeeID] UNIQUEIDENTIFIER NOT NULL, 
    [Date] DATE NOT NULL,
    [Time] TIME NOT NULL,
    [Type] BIT NOT NULL,
    [Created_Date] DATETIME DEFAULT GETDATE() NOT NULL,
    [Modified_Date] DATETIME

);
GO

