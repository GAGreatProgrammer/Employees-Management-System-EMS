using Employees_Management_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Telegram.Bot.Types.InputFiles;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Employees_Management_System.Forms
{
    public partial class TelegramBot : Form
    {
        private static TelegramBotClient EMSBot;

        private static string Client_Message = null;

        private static string DateAndTime = null;


        public TelegramBot()
        {
            InitializeComponent();
        }

        private void TelegramBot_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }

        #region BotStartStop
        private void StartBot()
        {
            EMSBot = new TelegramBotClient(GlobalVariables.EMSBotToken);
            EMSBot.StartReceiving();

            EMSBot.OnMessage += Client_OnMessage;
        }

        private void StopBot()
        {
            try
            {
                EMSBot = new TelegramBotClient(GlobalVariables.EMSBotToken);
                EMSBot.StopReceiving();
            }
            catch
            {

            }
            
        }
        #endregion BotStartStop

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartBot();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopBot();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private static async void BotStart(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var msg = e.Message;

            //BotButtons(sender, e);
        }

        private static async void BotButtons(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var msg = e.Message;
            string Server_Text = "Enter Search Parameter";

            
            try
            {
                if(GlobalVariables.EmployeeAccessLevel >= 1)
                {
                    await EMSBot.SendTextMessageAsync(
                        chatId: msg.Chat.Id,
                        text: Server_Text
                    );
                }
                else if (GlobalVariables.EmployeeAccessLevel == 0)
                {
                    await EMSBot.SendTextMessageAsync(
                        chatId: msg.Chat.Id,
                        text: "Access Denied!!!"
                    );

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private static async void BotInvalidCommand(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var msg = e.Message;
            string Server_Text = "Command not recognized!";

            await EMSBot.SendTextMessageAsync(
                        chatId: msg.Chat.Id,
                        text: Server_Text
                    );

            BotButtons(sender, e);
        }

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

        private static async void Client_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var msg = e.Message;

            Client_Message = msg.Text;

            GlobalVariables.ClientID = msg.Chat.Id.ToString();

            DateAndTime = DateTime.Now.ToString();


            if (msg.Text != null)
            {
                switch (msg.Text)
                {
                    case "/start":
                        //Console.WriteLine($"Server: New client connected. User - {msg.From}, {msg.Chat.Type} ({DateAndTime})");
                        BotStart(sender, e);
                        break;

                    case string a when a.Contains("/employeeid"):
                        TelegramBotAPI.EmployeePassportID = Client_Message.Split(' ').Last();
                        Employees(sender, e);
                        break;

                }
            }

            
        }
    }
}
