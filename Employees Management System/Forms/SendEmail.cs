using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.Class;
using Employees_Management_System.Properties;

namespace Employees_Management_System.Forms
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {

        }

        string Attachment_Path = "";
        public void Email()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(Settings.Default.EmailFrom);
                message.To.Add(new MailAddress(txtTo.Text));

                if (!string.IsNullOrEmpty(txtCC.Text))
                    message.CC.Add(new MailAddress(txtCC.Text));

                if (!string.IsNullOrEmpty(txtBCC.Text))
                    message.Bcc.Add(new MailAddress(txtBCC.Text));

                message.Subject = txtSub.Text;
                message.Body = txtBody.Text;

                if (!string.IsNullOrEmpty(Attachment_Path))
                {
                    message.Attachments.Add(new Attachment(Attachment_Path));
                }

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Settings.Default.EmailFrom, Settings.Default.EmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("შეტყობინება გაგზანვილია!", "შეტყობინების გაგზავნა", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Email());

            txtTo.Text = "";
            txtSub.Text = "";
            txtAttachmentPath.Text = "";
            txtBody.Text = "";
        }

        private void btnPirNomSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ALL files(*.*)|*.*";
            ofd.Title = "Add an Attachment";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Attachment_Path = ofd.FileName;
                txtAttachmentPath.Text = ofd.FileName;
            }
        }
    }
}
