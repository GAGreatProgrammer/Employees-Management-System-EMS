using Employees_Management_System.Class;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace Employees_Management_System.Forms
{
    public partial class QRCardGenerateForm : Form
    {
        private SqlConnection sqlConnection = null;
        BarcodeWriter barcodeWriter = new BarcodeWriter();

        private int PermanentCard = 1;
        private int Blocked = 0;
        

        public QRCardGenerateForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void QRCodeGenerateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);
        }

        
        
        private void Registration()
        {
            if (cboEmployeeID.Text == "" || txtQRCard_ID.Text == "" || txtChange_Period.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("EmployeeQRCardRegistration", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@QRCard_ID", SqlDbType.NVarChar).Value = txtQRCard_ID.Text;
                sqlCommand.Parameters.Add("@Permanent_Card", SqlDbType.Bit).Value = PermanentCard;
                sqlCommand.Parameters.Add("@Change_Period", SqlDbType.Int).Value = txtChange_Period.Text;
                sqlCommand.Parameters.Add("@Blocked", SqlDbType.Bit).Value = Blocked;
                sqlCommand.Parameters.Add("@Additional_Info", SqlDbType.NVarChar).Value = txtAdditionalInfo.Text;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"QR ბარათი წარმატებით დარეგისტრირდა", "QR ბარათი", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void ClearData()
        {
            cboEmployeeID.Text = "";
            txtQRCard_ID.Text = "";
            cboCardType.SelectedItem = null;
            cboCardType.Text = "";
            cboEmployeeID.SelectedItem = null;
            cboStatus.SelectedItem = null;
            cboStatus.Text = "";
            txtChange_Period.Text = "";
            txtAdditionalInfo.Text = "";
            pbQRCode.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Registration();
            ClearData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cboCardType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCardType.SelectedIndex == 0)
            {
                PermanentCard = 1;
            }
            else if (cboCardType.SelectedIndex == 1)
            {
                PermanentCard = 0;
            }
        }

        private void cboStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.SelectedIndex == 0)
            {
                Blocked = 1;
            }
            else if (cboStatus.SelectedIndex == 1)
            {
                Blocked = 0;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var Charsarr = new char[7];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);

            txtQRCard_ID.Text = resultString;
        }

        private void GenerateQR()
        {
            var QRCode_Text = txtQRCard_ID.Text + "\n" + 
                              DateTime.Now;

            EncodingOptions encodingOptions = new EncodingOptions() { Width = 400, Height = 400, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(QRCode_Text);
            Graphics g = Graphics.FromImage(bitmap);
            pbQRCode.Image = bitmap;
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            GenerateQR();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                    }
                    pbQRCode.Image.Save(sfd.FileName, format);
                    MessageBox.Show("გამოსახულება შენახულია", "შენახვა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Delete()
        {
            if (cboEmployeeID.Text == "" )
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeQRCard", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.NVarChar).Value = cboEmployeeID.SelectedValue.ToString();

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"QR ბარათი წარმატებით წაიშალა", "QR ბარათის წაშლა", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cboEmployeeID_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
