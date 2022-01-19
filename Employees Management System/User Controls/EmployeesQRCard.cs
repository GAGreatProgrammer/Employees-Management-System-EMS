using AForge.Video;
using AForge.Video.DirectShow;
using Employees_Management_System.Class;
using Employees_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Employees_Management_System.User_Controls
{
    public partial class EmployeesQRCard : UserControl
    {
        private SqlConnection sqlConnection = null;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private string QRCodeID = null;

        private static EmployeesQRCard _instance;

        public static EmployeesQRCard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeesQRCard();
                return _instance;
            }
        }
        public EmployeesQRCard()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeesQRCard_Load(object sender, EventArgs e)
        {
            lblQRCardCount.Text = EmployeeGlobalInformation.QRCardCount().ToString();

            lblActiveQRCard.Text = EmployeeGlobalInformation.ActiveQRCardCount().ToString();

            lblOverdueQRCard.Text = EmployeeGlobalInformation.OverdueQRCardCount().ToString();

            lblBlockedQRCard.Text = EmployeeGlobalInformation.BlockedQRCardCount().ToString();

            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cboCamera.Items.Add(filterInfo.Name);
                cboCamera.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Fill()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM QRCardInfo WHERE [QRCard_ID] = '{QRCodeID}'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtQRCardID.Text = dr.GetValue(0).ToString();
                    txtPassportID.Text = dr.GetValue(1).ToString();
                    txtName.Text = dr.GetValue(2).ToString();
                    txtSurname.Text = dr.GetValue(3).ToString();
                    txtFathersName.Text = dr.GetValue(4).ToString();
                    txtCountry.Text = dr.GetValue(5).ToString();
                    txtTelephone.Text = dr.GetValue(6).ToString();
                    txtPosition.Text = dr.GetValue(7).ToString();
                }

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

        private void btnQRCardRegistration_Click(object sender, EventArgs e)
        {
            QRCardGenerateForm qRCardGenerateForm = new QRCardGenerateForm();
            qRCardGenerateForm.Show();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbQRCode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnReadQR_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();

                captureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                captureDevice.NewFrame += FinalFrame_NewFrame;
                captureDevice.Start();
                timer1.Start();
                btnReadQR.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbQRCode.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbQRCode.Image);
                if (result != null)
                {
                    string QRData = result.ToString();
                    var resultDataArray = QRData.Split(new char[] { '\n' });

                    QRCodeID = resultDataArray[0];

                    timer1.Stop();
                    Fill();
                    btnReadQR.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning == true)
                {
                    captureDevice.Stop();
                    pbQRCode.Image = null;
                    pbQRCode.BackColor = Color.White;

                    Clear();
                    btnReadQR.Enabled = true;
                }

                else if (captureDevice.IsRunning == false)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cboCamera.Items.Add(filterInfo.Name);
                cboCamera.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("კამერა ვერ მოიძებნა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clear()
        {
            txtQRCardID.Text = "";
            txtPassportID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtFathersName.Text = "";
            txtCountry.Text = "";
            txtTelephone.Text = "";
            txtPosition.Text = "";
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            EmployeeVisitRegistration employeeVisitRegistration = new EmployeeVisitRegistration();
            employeeVisitRegistration.Show();
        }
    }
}
