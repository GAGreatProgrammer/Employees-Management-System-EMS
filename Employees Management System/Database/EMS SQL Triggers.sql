USE EMS
GO


--1.
CREATE TRIGGER [EditingEmployee]
ON Employee
AFTER UPDATE
AS
UPDATE Employee SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--3.
CREATE TRIGGER [EditingEmployeeAccount]
ON EmployeeAccount
AFTER UPDATE
AS
UPDATE EmployeeAccount SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--4.
CREATE TRIGGER [EditingBlacklist]
ON Blacklist
AFTER UPDATE
AS
UPDATE Blacklist SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--5.
CREATE TRIGGER [EditingEmployeeQRCard]
ON EmployeeQRCard
AFTER UPDATE
AS
UPDATE EmployeeQRCard SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--6.
CREATE TRIGGER [EditingTelegramBotUsers]
ON TelegramBotUsers
AFTER UPDATE
AS
UPDATE TelegramBotUsers SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--7.
CREATE TRIGGER [TEditingEmployeeSalary]
ON EmployeeSalary
AFTER UPDATE
AS
UPDATE EmployeeSalary SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--8.
CREATE TRIGGER [EditingEmployeePayHistory]
ON EmployeePayHistory
AFTER UPDATE
AS
UPDATE EmployeePayHistory SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--9.
CREATE TRIGGER [EditingEmployeeBankAccount]
ON EmployeeBankAccount
AFTER UPDATE
AS
UPDATE EmployeeBankAccount SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO



--10.
CREATE TRIGGER [EditingEmployeeVisits]
ON EmployeeVisits
AFTER UPDATE
AS
UPDATE EmployeeVisits SET [Modified_Date] = GETDATE()
WHERE ID IN (SELECT DISTINCT ID FROM Inserted)
GO
