# **Employees Management System (EMS)** 
---
![Developed_by](https://img.shields.io/badge/Developed_by-GTU_IMS_108930-green) ![OS](https://img.shields.io/badge/OS-_Windows-blue) ![C#](https://img.shields.io/badge/C%23-_v7.3-yellow) ![.Net](https://img.shields.io/badge/.Net-_v4.7.2-red) ![SQL Server](https://img.shields.io/badge/Database-Microsoft_SQL_Server-white) ![GitHub last commit](https://img.shields.io/github/last-commit/GAGreatProgrammer/Employees-Management-System-EMS) ![GitHub](https://img.shields.io/github/license/GAGreatProgrammer/Employees-Management-System-EMS?color=orange) 

<br/>

EMS is an effective personnel management tool that allows you to easily and quickly administer all types of workplaces. The system includes, on the one hand, elements of registration of employees and their subsequent management, and on the other hand, the possibility of obtaining comprehensive information about current employees. The commercial success of the company and the prospects for its further growth directly depend on the successful and efficient operation of this system.

<n/>
EMS capabilities, like its goals, are not limited to employee management. The purpose of the system is to make the information of any employee available not only from a personal computer or other device, but also from anywhere in the world to receive/process complete information of the personnel. Such requests can be implemented using a special bot that gives any employee with the appropriate access level access to information about employees. The bot is based on Telegram Bot and can establish direct access to the employee management system database.

<br/>

## System Description
---

![EMS Main Form](https://raw.githubusercontent.com/GAGreatProgrammer/Employees-Management-System-EMS/master/Employees%20Management%20System/Assets/MainForm.PNG)

EMS is built on Microsoft SQL Server and Windows Forms. All data in the system is stored on the SQL Server. In case of editing information on it, in order to avoid unauthorized intervention in the system, the time of the last editing is recorded in the corresponding table. 

<n/>

To ensure data integrity, employee information is not removed from the database. Instead, in the event of dismissal, the employee's admission is canceled. Also, such an employee will have their personal QR-card or personal bank account cancelled.

<n/>

To ensure the reliability of the program, any incoming employee is required to log in using a personal QR-card. For authentication, the employee must bring the QR card to a special reader. After that, the employee working with the system will see the employee's personal information in a specially designed form. If an employee is not registered in the system or received a QR-card unauthorized, his data will not be displayed in the form.

<br/>

## System specifications
---

The Employees Management System includes:

* 11 Tables
* 17 SQL Stored Procedures
* 21 SQL Views
* 9 Triggers
* 21 Forms
* 4 C# Classes
* 10 Custom User Controls
* 4 Form Tabs

<n/>



<n/>

All of these elements create a common structure used for data management and full automation.

<br/>

## Installation
---

### From the Start Window
Using Visual Studio 2019, on the `Start Window` select `Clone or check out code`, then click the `GitHub` button to open the clone dialog.

### From the File menu
Go to `File > Open > Open From GitHub`.

<br/>

After building the project, you will be able to run it without installation, or run the installation file, which is located in `Employees Management System\Setup\Release\setup.exe`.

<br/>


## Connect Database
---

To establish a database connection, after building the project in Visual Studio, enter the SQL Server name instead of `myServerAddress` in the `App.config` file.


``` csharp
<connectionStrings>
  <add name="EMSConnectionString" connectionString="Data Source=myServerAddress;Initial Catalog=EMS;Integrated Security=True" providerName="System.Data.SqlClient" />

  <add name="Employees_Management_System.Properties.Settings.EMSConnectionString" connectionString="Data Source=myServerAddress;Initial Catalog=EMS;Integrated Security=True" providerName="System.Data.SqlClient" />
 </connectionStrings>
```

To ensure data integrity and avoid program errors, the database must be named `EMS.`

<br/>


## Mail service
---

To ensure proper work with the mail client, change the fields in the project settings: `EmailFrom` and `EmailPassword` to valid email data.

```csharp
  <userSettings>
    <Employees_Management_System.Properties.Settings>
      <setting name="EmailFrom" serializeAs="String">
        <value>Test@gmail.com</value>
      </setting>
      <setting name="EmailPassword" serializeAs="String">
        <value>Test</value>
      </setting>
    </Employees_Management_System.Properties.Settings>
  </userSettings>
```

<br/>

## Telegram Bot
---

EMS Telegram Bot is based on [.NET Client for Telegram Bot API](https://github.com/TelegramBots/Telegram.Bot).

<n/>

To configure the Telegram Bot, in the `GlobalVariables` class, enter the telegram bot token.


``` csharp
public static readonly string EMSBotToken = "";
```
<br/>

After sending a message to the bot, it checks if the entered employee is in the database. If the entered passport number matches the passport numbers from the database, the bot gives the result. If there is no employee in the database, the bot will display the following message: `No matches in the database!`

```csharp
private static async void Employees(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var msg = e.Message;
            string Server_Text = "No matches in the database!";


            TelegramBotAPI.EmployeeInfo();

            if(TelegramBotAPI.EmployeeCount >=1)
            {
                InputOnlineFile inputOnlineFile = new InputOnlineFile(TelegramBotAPI.EmployeePhoto);
                await EMSBot.SendPhotoAsync(e.Message.Chat.Id, inputOnlineFile,
                    $"*Passport ID:* {TelegramBotAPI.EmployeePassportID} \n" +
                    $"*Full Name:* {TelegramBotAPI.EmployeeFullName} \n" +
                    $"*Birth Date:* {TelegramBotAPI.EmployeeBirth_Date} \n" +
                    $"*Telephone:* {TelegramBotAPI.EmployeeTelephone} \n" +
                    $"*Email:* {TelegramBotAPI.EmployeeEmail} \n" +
                    $"*Department:* {TelegramBotAPI.EmployeeDepartment} \n" +
                    $"*Position:* {TelegramBotAPI.EmployeePosition} \n" +
                    $"*Status:* {TelegramBotAPI.EmployeeStatus} \n" +
                    $"*Start Date:* {TelegramBotAPI.EmployeeStart_Date} \n",
                    ParseMode.Markdown
                );
            }
            else if(TelegramBotAPI.EmployeeCount == 0)
            {
                await EMSBot.SendTextMessageAsync(
                            chatId: msg.Chat.Id,
                            text: Server_Text
                        );

                BotButtons(sender, e);
            }
               
        }
```
<br/>


![EMS BOT](https://raw.githubusercontent.com/GAGreatProgrammer/Employees-Management-System-EMS/master/Employees%20Management%20System/Assets/EMS%20BOT.PNG)

<br/>


## Conclusion
---
The system responds to all the tasks that have arisen at the design stage. All the nuances necessary for the comfortable work of the user are provided, as well as the implementation of the software part, which allows you to add a new block to the system at any time, without completely editing the database.

<n/>

The software part of the system is designed in such a way that, if necessary, the person responsible for the operation of the system can easily control its operation, quickly and easily eliminate errors, and also receive all information without entering the system database. Thus, not only a part of fast and comfortable work is considered, but also a part of the "painless" implementation and maintenance of the system.

<n/>

The system is flexible, fast and customizable. Conforms to all standards taken from similar software products. The system also works on different versions of Windows. To protect the privacy of your employees and the security of their information, when working with EMS, we recommend that all employees working with the system create their own personal account on Microsoft SQL Server with the appropriate access levels and policies. This will protect all employees from unauthorized access to the system and reduce the risk of deleting information from the server.