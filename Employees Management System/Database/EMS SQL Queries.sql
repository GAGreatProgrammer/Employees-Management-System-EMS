USE EMS
GO


--1.
CREATE VIEW EmployeeShortInfo
AS
SELECT [ID], CONCAT([Passport_ID], ' ' , [Name], ' ', [Surname]) AS [Employee] FROM Employee
GO


--2.
CREATE VIEW EmployeeInfoForEditing
AS
SELECT CONVERT(NVARCHAR(50), E.[ID]) AS [ID], E.[Passport_ID], E.[Name], E.[Surname], 
E.[Gender], E.[Telephone], E.[Email], D.[Department]
FROM Employee E INNER JOIN Department D ON E.Department = D.ID
GO

SELECT * FROM EmployeeInfoForEditing WHERE [ID] LIKE '%%' AND [Passport_ID] LIKE '%%' AND [Name] LIKE '%%' AND [Surname] LIKE '%%'
GO


--3.
CREATE VIEW EditEmployeeInfoForm
AS
SELECT CONVERT(NVARCHAR(50) ,E.[ID]) AS [ID], E.[Passport_ID], E.[Name], E.[Surname], E.[Birth_Date], 
E.[Marital_Status], E.[Telephone], 
E.[Email], E.[City], E.[Street], E.[Department], E.[Position], E.[Status], e.[Photo]
FROM Employee E --INNER JOIN Department D ON E.Department = D.ID
GO


--4.
CREATE VIEW EmployeeQRCardInfo
AS
SELECT CONVERT(NVARCHAR(50), QR.[EmployeeID]) AS [EmployeeID], E.[Passport_ID], CONCAT(E.[Name], ' ', E.[Surname]) AS [FullName],
QR.[QRCard_ID], IIF(QR.[Permanent_Card] = 1, N'მუდმივი', N'დროებითი') AS [Permanent_Card], QR.[Change_Period], 
IIF(QR.[Blocked] = '0', N'არ არის დაბლოკილი', N'დაბლოკილია') AS [Blocked]
FROM EmployeeQRCard QR INNER JOIN Employee E ON QR.EmployeeID = E.ID
GO


SELECT * FROM EmployeeQRCardInfo WHERE [EmployeeID] LIKE '%%' 
AND [QRCard_ID] LIKE '%%' 
AND [Permanent_Card] LIKE '%%' 
AND [Blocked] LIKE '%%'
GO


--5.
CREATE VIEW EmployeeAccountInfo
AS
SELECT CONVERT(NVARCHAR(50) , E.[ID]) AS [EmployeeID], CONCAT(E.[Name], ' ', E.[Surname]) AS [FullName], 
A.Username, IIF(A.Permanent_Password = 1, N'მუდმივი', N'დროებითი') AS [Permanent_Password], A.Password_Change_Period, A.Access_Level
FROM Employee E INNER JOIN EmployeeAccount A ON E.ID = A.EmployeeID
GO


--6.
CREATE VIEW BlacklistInfo
AS
SELECT CONVERT(NVARCHAR(50) , E.[ID]) AS [EmployeeID], E.[Passport_ID], CONCAT(E.[Name], ' ', E.[Surname]) AS [FullName], 
B.[Effective_Date], B.Reason
FROM Blacklist B INNER JOIN Employee E ON B.EmployeeID = E.ID
GO


--7.
CREATE VIEW EmployeeFullInfoFiltering
AS
SELECT CONVERT(NVARCHAR(50) , E.[ID]) AS [EmployeeID], E.[Passport_ID], E.[Name], E.[Surname], C.[Country], E.[Telephone], E.[Email],
        E.[City], E.[Street], D.[Department], E.[Position], E.[Status], FORMAT(E.[Birth_Date], 'MM-dd') AS [Birth_Date], 
        EQR.[EmployeeID] AS [QRCard], BL.[EmployeeID] AS [Blacklist], TBU.[EmployeeID] AS [BotUser], CAST(ESL.[Salary] AS INT) AS [Salary]
FROM Employee E INNER JOIN Countries C ON E.Country = C.ID
                INNER JOIN Department D ON E.Department = D.ID
                LEFT JOIN EmployeeQRCard EQR ON E.ID = EQR.EmployeeID
                LEFT JOIN Blacklist BL ON E.ID = BL.EmployeeID
                LEFT JOIN TelegramBotUsers TBU ON E.ID = TBU.EmployeeID
                LEFT JOIN EmployeeSalary ESL ON E.ID = ESL.EmployeeID
GO


SELECT *
FROM EmployeeFullInfoFiltering
WHERE
    [EmployeeID] LIKE '%%' AND [Passport_ID] LIKE '%%' AND [Name] LIKE '%%' AND [Surname] LIKE '%%' AND [Country] LIKE '%%'
AND [Telephone] LIKE '%%' AND [Email] LIKE '%%' AND [City] LIKE '%%' AND [Street] LIKE '%%' AND [Department] LIKE '%%' AND [Position] LIKE '%%'
AND [Status] LIKE '%%'
GO

SELECT *
FROM EmployeeFullInfoFiltering
WHERE
    [Birth_Date] LIKE FORMAT(CAST(GETDATE() AS DATE), 'MM-dd')
GO

SELECT * FROM EmployeeFullInfoFiltering
WHERE [QRCard] IS NOT NULL
GO

SELECT * FROM EmployeeFullInfoFiltering
WHERE [Blacklist] IS NOT NULL
GO


SELECT * FROM EmployeeFullInfoFiltering
WHERE [BotUser] IS NOT NULL
GO

SELECT * FROM EmployeeFullInfoFiltering
WHERE [Salary] >= '0' AND [Salary] <= '3700'
GO


--8.
CREATE VIEW EmployeeFullInformation
AS
SELECT E.[ID], E.[Passport_ID], E.[Name], E.[Surname], E.[Father's_Name], E.[Gender], FORMAT(E.[Birth_Date], 'dd/MM/yyyy') AS [Birth_Date], 
C.[Country], E.[City], E.[Street], E.[Marital_Status], E.[Telephone], E.[Email], D.[Department], E.[Position], 
FORMAT(E.[Start_Date], 'dd/MM/yyyy') AS [Start_Date], E.[Status], EC.[Access_Level], EQR.[QRCard_ID], 
TBU.[Bot_User_ID], TBU.[Access_Level] AS [Bot_Access_Level], ES.[Salary], 
IIF(ES.[Pay_Frequency] = 1, N'თვიურად', IIF(ES.[Pay_Frequency] = 2, N'ყოველ კვირას', N'არანორმირებული გრაფიკი')) AS [Pay_Frequency], 
EBA.[Bank_Account_Number], EBA.[Card_Number], E.[Additional_Info], E.[Photo]
FROM Employee E INNER JOIN Countries C ON E.Country = C.ID
                INNER JOIN Department D ON E.Department = D.ID
                INNER JOIN EmployeeAccount EC ON EC.EmployeeID = E.ID
                LEFT JOIN EmployeeQRCard EQR ON E.ID = EQR.EmployeeID
                LEFT JOIN TelegramBotUsers TBU ON E.ID = TBU.EmployeeID
                INNER JOIN EmployeeSalary ES ON ES.EmployeeID = E.ID
                LEFT JOIN EmployeePayHistory EPH ON EPH.EmployeeID = E.ID
                LEFT JOIN EmployeeBankAccount EBA ON EBA.EmployeeID = E.ID
GO


SELECT * FROM EmployeeFullInformation WHERE [ID] = '12e6355c-7236-412a-aa2c-c76de3a1d3e6'
GO


--9.
CREATE VIEW EmployeePayHistoryInfo
AS
SELECT CONVERT(NVARCHAR(50) , E.[ID]) AS [EmployeeID], E.[Passport_ID], E.[Name], E.[Surname], 
       EPH.[Payment_Date], EPH.[From_Date], EPH.[To_Date], EPH.[Payment_Type], ES.[Salary], EPH.[Rate], EPH.[Award], EPH.[Payment_State]
FROM Employee E INNER JOIN EmployeePayHistory EPH ON E.ID = EPH.EmployeeID
                INNER JOIN EmployeeSalary ES ON E.ID = ES.EmployeeID
GO


--10.
SELECT DATENAME(MONTH, Payment_Date) AS [Payment Date], ROUND(AVG(Rate), 1) AS [Average Rate], ROUND(AVG(Award), 1) AS [Average Award] 
FROM EmployeePayHistory 
GROUP BY DATENAME(MONTH, Payment_Date)
GO


--11.
CREATE VIEW EmployeeAverageMonthSalary
AS
SELECT ROUND(AVG(Salary), 3) AS [Salary] 
FROM EmployeeSalary
WHERE [Pay_Frequency] = '1'
GO


--12.
CREATE VIEW EmployeeAverageYearSalary
AS
SELECT ROUND((AVG(Salary)*12), 3) AS [Rate]
FROM EmployeeSalary
GO


--13.
SELECT ROUND(AVG(Rate), 3) AS [Rate]
FROM EmployeePayHistory
WHERE [Payment_Date] BETWEEN DATEADD(YEAR, -1, GETDATE()) AND GETDATE()
GO


--14.
CREATE VIEW EmployeeAverageDepartmentSalary
AS
SELECT D.[Department], ROUND(AVG(ES.[Salary]), 3) AS [AverageSalary]
FROM Employee E INNER JOIN Department D ON E.Department = D.ID
                INNER JOIN EmployeeSalary ES ON E.ID = ES.EmployeeID
GROUP BY D.[Department]
GO


--15.
CREATE VIEW EmployeeAverageSalaryByAge
AS
SELECT DATEDIFF(YEAR, E.[Birth_Date], GETDATE()) AS [Age], ROUND(AVG(ES.[Salary]), 3) AS [AverageSalary]
FROM Employee E INNER JOIN EmployeeSalary ES ON E.ID = ES.EmployeeID
GROUP BY DATEDIFF(YEAR, E.[Birth_Date], GETDATE())
--ORDER BY DATEDIFF(YEAR, E.[Birth_Date], GETDATE()) ASC
GO


--16.
CREATE VIEW EmployeeTotalRateByYear
AS
SELECT YEAR(ESH.[Payment_Date]) AS [Year], SUM(ESH.[Rate]) AS [TotalRate]
FROM EmployeePayHistory ESH
GROUP BY YEAR(ESH.[Payment_Date])
GO


--17.
CREATE VIEW EmployeeTotalAwardByYear
AS
SELECT YEAR(ESH.[Payment_Date]) AS [Year], SUM(ESH.[Award]) AS [TotalAward]
FROM EmployeePayHistory ESH
GROUP BY YEAR(ESH.[Payment_Date])
GO


--18.
SELECT ROUND((AVG(Salary)*12), 3) AS [Rate]
FROM EmployeeSalary
GO


--19.
SELECT COUNT(*) FROM EmployeeQRCard WHERE Blocked = '0'
GO


--20.
SELECT COUNT(*) FROM EmployeeQRCard WHERE Blocked = '1'
GO


--21.
SELECT COUNT(*) FROM EmployeeQRCard WHERE DATEADD(DAY, -30, GETDATE()) >= [Created_Date] AND [Permanent_Card] = '0'
GO


--22.
CREATE VIEW CameEmployees
AS
SELECT COUNT(DISTINCT([EmployeeID])) AS [EmployeeCount]
FROM EmployeeVisits
WHERE [Date] = CAST(GETDATE() AS DATE) AND [Type] = '1'
GO


--23.
SELECT --COUNT(DISTINCT([EmployeeID])) AS [EmployeeCount]
COUNT(*) AS [EmployeeCount]
FROM EmployeeVisits
WHERE [Date] = CAST(GETDATE() AS DATE) AND [Type] = '0'
GO


--24.
CREATE VIEW NotCameEmployees
AS
SELECT COUNT(*) [NotCameEmployees]
FROM Employee
WHERE [ID] NOT IN (SELECT DISTINCT [EmployeeID] FROM EmployeeVisits WHERE [Date] = CAST(GETDATE() AS DATE) AND [Type] = '1')
GO


--25.
CREATE VIEW EmployeeVisitsInfo
AS
SELECT EV.[ID], E.[Passport_ID], CONCAT(E.[Name], ' ', E.[Surname]) AS [FullName], 
       E.[Telephone], E.[Email], D.[Department], E.[Position], e.[Status],
       EV.[Date], EV.[Time], IIF(EV.[Type] = 1, N'მოსვლა', N'წასვლა') AS [Type]
FROM Employee E INNER JOIN Department D ON E.Department = D.ID
                INNER JOIN EmployeeVisits EV ON E.ID = EV.EmployeeID
WHERE EV.[Date] = CAST(GETDATE() AS DATE)
GO


--26.
SELECT MIN([Salary]) AS [MinSalary], MAX([Salary]) AS [MaxSalary]
FROM EmployeeSalary
GO


--26.
CREATE VIEW QRCardInfo
AS
SELECT  EQR.[QRCard_ID], E.[Passport_ID], E.[Name], E.[Surname], E.[Father's_Name], C.[Country], E.[Telephone], E.[Position]
FROM Employee E INNER JOIN EmployeeQRCard EQR ON E.ID = EQR.EmployeeID
                INNER JOIN Countries C ON E.Country = C.ID
GO


--27.
CREATE VIEW EmployeeVisitsFullInfo
AS
SELECT CONVERT(NVARCHAR(50) , E.[ID]) AS [EmployeeID], E.[Passport_ID], CONCAT(E.[Name], ' ', E.[Surname]) AS [FullName], 
       E.[Telephone], E.[Email], D.[Department], E.[Position], e.[Status],
       FORMAT(EV.[Date], 'dd/MM/yyyy') AS [Date], CAST(EV.[Time] AS NVARCHAR) AS [Time], IIF(EV.[Type] = 1, N'მოსვლა', N'წასვლა') AS [Type]
FROM Employee E INNER JOIN Department D ON E.Department = D.ID
                INNER JOIN EmployeeVisits EV ON E.ID = EV.EmployeeID
GO


--28.
SELECT * 
FROM EmployeeVisitsFullInfo
WHERE [EmployeeID] LIKE '%%' 
AND [Passport_ID] LIKE '%%' 
AND [Telephone] LIKE '%%' 
AND [Email] LIKE '%%' 
AND [Department] LIKE '%%' 
AND [Position] LIKE '%%' 
AND [Status] LIKE '%%' 
AND [DATE] LIKE '%%' 
AND [TIME] LIKE '%%' 
AND [Type] LIKE '%%'
GO


--29.
CREATE VIEW EmployeeImage
AS
SELECT EA.[Username], E.[Photo] FROM EmployeeAccount EA
INNER JOIN Employee E ON E.ID = EA.EmployeeID
GO


--30.
CREATE VIEW BOTEmployeeInfo
AS
SELECT CAST(E.[Passport_ID] AS NVARCHAR(50)) AS [Passport_ID], CONCAT(E.[Name], ' ', E.[Surname]) AS [FullName], 
        FORMAT(E.[Birth_Date], 'dd/MM/yyyy') AS [Birth_Date], E.[Telephone], E.[Email], D.[Department],
        E.[Position], E.[Status], FORMAT(E.[Start_Date], 'dd/MM/yyyy') AS [Start_Date], E.[Photo]
FROM Employee E INNER JOIN Department D ON E.Department = D.ID
GO


--31.
SELECT DISTINCT COUNT(*) [Count] FROM EmployeeVisits WHERE [Date] = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE)
GO


--32.
SELECT YEAR([Payment_Date]) AS [Payment_Date], SUM([Rate]) AS [Rate] FROM EmployeePayHistory GROUP BY YEAR([Payment_Date])
GO