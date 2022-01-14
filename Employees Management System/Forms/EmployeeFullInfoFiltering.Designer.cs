
namespace Employees_Management_System.Forms
{
    partial class EmployeeFullInfoFiltering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFullInfoFiltering));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvEmployeeFullInfo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtSurname = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtName = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtPassportID = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmployeeID = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.employeeShortInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new Employees_Management_System.EMSDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCountry = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtTelephone = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStreet = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtCity = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPosition = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label35 = new System.Windows.Forms.Label();
            this.cboDepartment = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.cboStatus = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFilteringPrimary = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnSalaryFiltering = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sliderSalary = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tglBot = new Employees_Management_System.Custom_Controls.CustomToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tglBlacklist = new Employees_Management_System.Custom_Controls.CustomToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tglBirthday = new Employees_Management_System.Custom_Controls.CustomToggleButton();
            this.tglQRCard = new Employees_Management_System.Custom_Controls.CustomToggleButton();
            this.employeeShortInfoTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter();
            this.countriesTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.CountriesTableAdapter();
            this.departmentTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.DepartmentTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeFullInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeFullInfo
            // 
            this.dgvEmployeeFullInfo.AllowCustomTheming = false;
            this.dgvEmployeeFullInfo.AllowUserToAddRows = false;
            this.dgvEmployeeFullInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeFullInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeFullInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeFullInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeFullInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeFullInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployeeFullInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeFullInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeFullInfo.ColumnHeadersHeight = 40;
            this.dgvEmployeeFullInfo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEmployeeFullInfo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeFullInfo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeFullInfo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployeeFullInfo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeFullInfo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeFullInfo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployeeFullInfo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployeeFullInfo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeFullInfo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployeeFullInfo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEmployeeFullInfo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployeeFullInfo.CurrentTheme.Name = null;
            this.dgvEmployeeFullInfo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeFullInfo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeFullInfo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeFullInfo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployeeFullInfo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeFullInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeFullInfo.EnableHeadersVisualStyles = false;
            this.dgvEmployeeFullInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployeeFullInfo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployeeFullInfo.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEmployeeFullInfo.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEmployeeFullInfo.Location = new System.Drawing.Point(12, 349);
            this.dgvEmployeeFullInfo.Name = "dgvEmployeeFullInfo";
            this.dgvEmployeeFullInfo.ReadOnly = true;
            this.dgvEmployeeFullInfo.RowHeadersVisible = false;
            this.dgvEmployeeFullInfo.RowTemplate.Height = 40;
            this.dgvEmployeeFullInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeFullInfo.Size = new System.Drawing.Size(1460, 600);
            this.dgvEmployeeFullInfo.TabIndex = 0;
            this.dgvEmployeeFullInfo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEmployeeFullInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeFullInfo_CellClick);
            this.dgvEmployeeFullInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeFullInfo_CellDoubleClick);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtSurname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtSurname.BorderRadius = 0;
            this.txtSurname.BorderSize = 1;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(171, 181);
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSurname.PasswordChar = false;
            this.txtSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSurname.PlaceholderText = "";
            this.txtSurname.Size = new System.Drawing.Size(310, 35);
            this.txtSurname.TabIndex = 138;
            this.txtSurname.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(171, 128);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(310, 35);
            this.txtName.TabIndex = 137;
            this.txtName.UnderlinedStyle = false;
            // 
            // txtPassportID
            // 
            this.txtPassportID.BackColor = System.Drawing.Color.White;
            this.txtPassportID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtPassportID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtPassportID.BorderRadius = 0;
            this.txtPassportID.BorderSize = 1;
            this.txtPassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportID.ForeColor = System.Drawing.Color.Black;
            this.txtPassportID.Location = new System.Drawing.Point(171, 68);
            this.txtPassportID.Multiline = false;
            this.txtPassportID.Name = "txtPassportID";
            this.txtPassportID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassportID.PasswordChar = false;
            this.txtPassportID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassportID.PlaceholderText = "";
            this.txtPassportID.Size = new System.Drawing.Size(310, 35);
            this.txtPassportID.TabIndex = 136;
            this.txtPassportID.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 135;
            this.label3.Text = "გვარი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 134;
            this.label2.Text = "სახელი";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "პირადი ნომერი";
            // 
            // cboEmployeeID
            // 
            this.cboEmployeeID.BackColor = System.Drawing.Color.White;
            this.cboEmployeeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboEmployeeID.BorderSize = 1;
            this.cboEmployeeID.DataSource = this.employeeShortInfoBindingSource;
            this.cboEmployeeID.DisplayMember = "Employee";
            this.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboEmployeeID.DropDownWidth = 198;
            this.cboEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.cboEmployeeID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.cboEmployeeID.IntegralHeight = false;
            this.cboEmployeeID.ListBackColor = System.Drawing.Color.White;
            this.cboEmployeeID.ListTextColor = System.Drawing.Color.Black;
            this.cboEmployeeID.Location = new System.Drawing.Point(171, 10);
            this.cboEmployeeID.MaxDropDownItems = 8;
            this.cboEmployeeID.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Padding = new System.Windows.Forms.Padding(1);
            this.cboEmployeeID.Size = new System.Drawing.Size(310, 35);
            this.cboEmployeeID.TabIndex = 140;
            this.cboEmployeeID.ValueMember = "ID";
            // 
            // employeeShortInfoBindingSource
            // 
            this.employeeShortInfoBindingSource.DataMember = "EmployeeShortInfo";
            this.employeeShortInfoBindingSource.DataSource = this.eMSDataSet;
            // 
            // eMSDataSet
            // 
            this.eMSDataSet.DataSetName = "EMSDataSet";
            this.eMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 139;
            this.label4.Text = "თანამშრომელი";
            // 
            // cboCountry
            // 
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.BackColor = System.Drawing.Color.White;
            this.cboCountry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboCountry.BorderSize = 1;
            this.cboCountry.DataSource = this.countriesBindingSource;
            this.cboCountry.DisplayMember = "Country";
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.DropDownWidth = 198;
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.ForeColor = System.Drawing.Color.Black;
            this.cboCountry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboCountry.IntegralHeight = false;
            this.cboCountry.ListBackColor = System.Drawing.Color.White;
            this.cboCountry.ListTextColor = System.Drawing.Color.Black;
            this.cboCountry.Location = new System.Drawing.Point(171, 233);
            this.cboCountry.MaxDropDownItems = 8;
            this.cboCountry.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Padding = new System.Windows.Forms.Padding(1);
            this.cboCountry.Size = new System.Drawing.Size(310, 35);
            this.cboCountry.TabIndex = 142;
            this.cboCountry.ValueMember = "ID";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.eMSDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 141;
            this.label10.Text = "ქვეყანა";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(665, 68);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(310, 35);
            this.txtEmail.TabIndex = 147;
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.White;
            this.txtTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtTelephone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtTelephone.BorderRadius = 0;
            this.txtTelephone.BorderSize = 1;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.Color.Black;
            this.txtTelephone.Location = new System.Drawing.Point(665, 10);
            this.txtTelephone.Multiline = false;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelephone.PasswordChar = false;
            this.txtTelephone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.Size = new System.Drawing.Size(310, 35);
            this.txtTelephone.TabIndex = 146;
            this.txtTelephone.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(524, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 145;
            this.label9.Text = "ელ.ფოსტა";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(524, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 144;
            this.label8.Text = "ტელეფონი";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.White;
            this.txtStreet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtStreet.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtStreet.BorderRadius = 0;
            this.txtStreet.BorderSize = 1;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.Color.Black;
            this.txtStreet.Location = new System.Drawing.Point(665, 181);
            this.txtStreet.Multiline = false;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStreet.PasswordChar = false;
            this.txtStreet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStreet.PlaceholderText = "";
            this.txtStreet.Size = new System.Drawing.Size(310, 35);
            this.txtStreet.TabIndex = 153;
            this.txtStreet.UnderlinedStyle = false;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtCity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtCity.BorderRadius = 0;
            this.txtCity.BorderSize = 1;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(665, 128);
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCity.PasswordChar = false;
            this.txtCity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCity.PlaceholderText = "";
            this.txtCity.Size = new System.Drawing.Size(310, 35);
            this.txtCity.TabIndex = 152;
            this.txtCity.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(524, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 151;
            this.label12.Text = "ქუჩა";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(524, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 150;
            this.label11.Text = "ქალაქი";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtPosition.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtPosition.BorderRadius = 0;
            this.txtPosition.BorderSize = 1;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.Location = new System.Drawing.Point(1135, 10);
            this.txtPosition.Multiline = false;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPosition.PasswordChar = false;
            this.txtPosition.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPosition.PlaceholderText = "";
            this.txtPosition.Size = new System.Drawing.Size(310, 35);
            this.txtPosition.TabIndex = 160;
            this.txtPosition.UnderlinedStyle = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(1003, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 20);
            this.label35.TabIndex = 159;
            this.label35.Text = "პოზიცია";
            // 
            // cboDepartment
            // 
            this.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartment.BackColor = System.Drawing.Color.White;
            this.cboDepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboDepartment.BorderSize = 1;
            this.cboDepartment.DataSource = this.departmentBindingSource;
            this.cboDepartment.DisplayMember = "Department";
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.DropDownWidth = 198;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Black;
            this.cboDepartment.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboDepartment.IntegralHeight = false;
            this.cboDepartment.ListBackColor = System.Drawing.Color.White;
            this.cboDepartment.ListTextColor = System.Drawing.Color.Black;
            this.cboDepartment.Location = new System.Drawing.Point(665, 233);
            this.cboDepartment.MaxDropDownItems = 8;
            this.cboDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.cboDepartment.Size = new System.Drawing.Size(310, 35);
            this.cboDepartment.TabIndex = 157;
            this.cboDepartment.ValueMember = "ID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.eMSDataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(524, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 156;
            this.label13.Text = "დეპარტამენტი";
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.BackColor = System.Drawing.Color.White;
            this.cboStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboStatus.BorderSize = 1;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 198;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Black;
            this.cboStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboStatus.IntegralHeight = true;
            this.cboStatus.Items.AddRange(new object[] {
            "აქტიური",
            "შეჩერებული",
            "გაუქმებული"});
            this.cboStatus.ListBackColor = System.Drawing.Color.White;
            this.cboStatus.ListTextColor = System.Drawing.Color.Black;
            this.cboStatus.Location = new System.Drawing.Point(1135, 68);
            this.cboStatus.MaxDropDownItems = 8;
            this.cboStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cboStatus.Size = new System.Drawing.Size(310, 35);
            this.cboStatus.TabIndex = 163;
            this.cboStatus.OnSelectedIndexChanged += new System.EventHandler(this.cboStatus_OnSelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1003, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 162;
            this.label14.Text = "სტატუსი";
            // 
            // btnReload
            // 
            this.btnReload.AllowAnimations = true;
            this.btnReload.AllowMouseEffects = true;
            this.btnReload.AllowToggling = false;
            this.btnReload.AnimationSpeed = 50;
            this.btnReload.AutoGenerateColors = false;
            this.btnReload.AutoRoundBorders = false;
            this.btnReload.AutoSizeLeftIcon = true;
            this.btnReload.AutoSizeRightIcon = true;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.ButtonText = "";
            this.btnReload.ButtonTextMarginLeft = 0;
            this.btnReload.ColorContrastOnClick = 45;
            this.btnReload.ColorContrastOnHover = 45;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReload.CustomizableEdges = borderEdges1;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnReload.IconMarginLeft = 11;
            this.btnReload.IconPadding = 5;
            this.btnReload.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnReload.IconSize = 25;
            this.btnReload.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.IdleBorderRadius = 10;
            this.btnReload.IdleBorderThickness = 1;
            this.btnReload.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.IdleIconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload.IdleIconRightImage = null;
            this.btnReload.IndicateFocus = false;
            this.btnReload.Location = new System.Drawing.Point(449, 305);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.OnDisabledState.BorderRadius = 10;
            this.btnReload.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnDisabledState.BorderThickness = 1;
            this.btnReload.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload.OnDisabledState.IconLeftImage = null;
            this.btnReload.OnDisabledState.IconRightImage = null;
            this.btnReload.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload.onHoverState.BorderRadius = 10;
            this.btnReload.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.onHoverState.BorderThickness = 1;
            this.btnReload.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload.onHoverState.IconLeftImage = null;
            this.btnReload.onHoverState.IconRightImage = null;
            this.btnReload.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnIdleState.BorderRadius = 10;
            this.btnReload.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnIdleState.BorderThickness = 1;
            this.btnReload.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnIdleState.IconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload.OnIdleState.IconRightImage = null;
            this.btnReload.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnPressedState.BorderRadius = 10;
            this.btnReload.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnPressedState.BorderThickness = 1;
            this.btnReload.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnPressedState.IconLeftImage = null;
            this.btnReload.OnPressedState.IconRightImage = null;
            this.btnReload.Size = new System.Drawing.Size(35, 35);
            this.btnReload.TabIndex = 166;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.TextMarginLeft = 0;
            this.btnReload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload.UseDefaultRadiusAndThickness = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 50;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "გაუქმება";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = false;
            borderEdges2.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges2;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.IdleBorderRadius = 10;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(293, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 10;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.onHoverState.BorderRadius = 10;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.OnIdleState.BorderRadius = 10;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.OnPressedState.BorderRadius = 10;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(150, 35);
            this.btnCancel.TabIndex = 165;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilteringPrimary
            // 
            this.btnFilteringPrimary.AllowAnimations = true;
            this.btnFilteringPrimary.AllowMouseEffects = true;
            this.btnFilteringPrimary.AllowToggling = false;
            this.btnFilteringPrimary.AnimationSpeed = 50;
            this.btnFilteringPrimary.AutoGenerateColors = false;
            this.btnFilteringPrimary.AutoRoundBorders = false;
            this.btnFilteringPrimary.AutoSizeLeftIcon = true;
            this.btnFilteringPrimary.AutoSizeRightIcon = true;
            this.btnFilteringPrimary.BackColor = System.Drawing.Color.Transparent;
            this.btnFilteringPrimary.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilteringPrimary.BackgroundImage")));
            this.btnFilteringPrimary.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilteringPrimary.ButtonText = "ფილტრაცია(პირველადი)";
            this.btnFilteringPrimary.ButtonTextMarginLeft = 0;
            this.btnFilteringPrimary.ColorContrastOnClick = 45;
            this.btnFilteringPrimary.ColorContrastOnHover = 45;
            this.btnFilteringPrimary.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.btnFilteringPrimary.CustomizableEdges = borderEdges3;
            this.btnFilteringPrimary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilteringPrimary.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFilteringPrimary.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFilteringPrimary.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFilteringPrimary.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFilteringPrimary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilteringPrimary.ForeColor = System.Drawing.Color.White;
            this.btnFilteringPrimary.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilteringPrimary.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFilteringPrimary.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFilteringPrimary.IconMarginLeft = 11;
            this.btnFilteringPrimary.IconPadding = 10;
            this.btnFilteringPrimary.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilteringPrimary.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFilteringPrimary.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFilteringPrimary.IconSize = 25;
            this.btnFilteringPrimary.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.IdleBorderRadius = 10;
            this.btnFilteringPrimary.IdleBorderThickness = 1;
            this.btnFilteringPrimary.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.IdleIconLeftImage = null;
            this.btnFilteringPrimary.IdleIconRightImage = null;
            this.btnFilteringPrimary.IndicateFocus = false;
            this.btnFilteringPrimary.Location = new System.Drawing.Point(12, 305);
            this.btnFilteringPrimary.Name = "btnFilteringPrimary";
            this.btnFilteringPrimary.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFilteringPrimary.OnDisabledState.BorderRadius = 10;
            this.btnFilteringPrimary.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilteringPrimary.OnDisabledState.BorderThickness = 1;
            this.btnFilteringPrimary.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFilteringPrimary.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFilteringPrimary.OnDisabledState.IconLeftImage = null;
            this.btnFilteringPrimary.OnDisabledState.IconRightImage = null;
            this.btnFilteringPrimary.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFilteringPrimary.onHoverState.BorderRadius = 10;
            this.btnFilteringPrimary.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilteringPrimary.onHoverState.BorderThickness = 1;
            this.btnFilteringPrimary.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFilteringPrimary.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFilteringPrimary.onHoverState.IconLeftImage = null;
            this.btnFilteringPrimary.onHoverState.IconRightImage = null;
            this.btnFilteringPrimary.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.OnIdleState.BorderRadius = 10;
            this.btnFilteringPrimary.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilteringPrimary.OnIdleState.BorderThickness = 1;
            this.btnFilteringPrimary.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFilteringPrimary.OnIdleState.IconLeftImage = null;
            this.btnFilteringPrimary.OnIdleState.IconRightImage = null;
            this.btnFilteringPrimary.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.OnPressedState.BorderRadius = 10;
            this.btnFilteringPrimary.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilteringPrimary.OnPressedState.BorderThickness = 1;
            this.btnFilteringPrimary.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFilteringPrimary.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFilteringPrimary.OnPressedState.IconLeftImage = null;
            this.btnFilteringPrimary.OnPressedState.IconRightImage = null;
            this.btnFilteringPrimary.Size = new System.Drawing.Size(275, 35);
            this.btnFilteringPrimary.TabIndex = 164;
            this.btnFilteringPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilteringPrimary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilteringPrimary.TextMarginLeft = 0;
            this.btnFilteringPrimary.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFilteringPrimary.UseDefaultRadiusAndThickness = true;
            this.btnFilteringPrimary.Click += new System.EventHandler(this.btnFilteringPrimary_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.bunifuPanel1.BorderRadius = 15;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Controls.Add(this.txtTelephone);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.cboStatus);
            this.bunifuPanel1.Controls.Add(this.txtPassportID);
            this.bunifuPanel1.Controls.Add(this.label14);
            this.bunifuPanel1.Controls.Add(this.txtName);
            this.bunifuPanel1.Controls.Add(this.txtPosition);
            this.bunifuPanel1.Controls.Add(this.txtSurname);
            this.bunifuPanel1.Controls.Add(this.label35);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.cboDepartment);
            this.bunifuPanel1.Controls.Add(this.cboEmployeeID);
            this.bunifuPanel1.Controls.Add(this.label13);
            this.bunifuPanel1.Controls.Add(this.label10);
            this.bunifuPanel1.Controls.Add(this.txtStreet);
            this.bunifuPanel1.Controls.Add(this.cboCountry);
            this.bunifuPanel1.Controls.Add(this.txtCity);
            this.bunifuPanel1.Controls.Add(this.label8);
            this.bunifuPanel1.Controls.Add(this.label12);
            this.bunifuPanel1.Controls.Add(this.label9);
            this.bunifuPanel1.Controls.Add(this.label11);
            this.bunifuPanel1.Controls.Add(this.txtEmail);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1460, 287);
            this.bunifuPanel1.TabIndex = 167;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.bunifuPanel2.BorderRadius = 10;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnSalaryFiltering);
            this.bunifuPanel2.Controls.Add(this.sliderSalary);
            this.bunifuPanel2.Controls.Add(this.lblSalary);
            this.bunifuPanel2.Controls.Add(this.label16);
            this.bunifuPanel2.Controls.Add(this.label15);
            this.bunifuPanel2.Controls.Add(this.tglBot);
            this.bunifuPanel2.Controls.Add(this.label5);
            this.bunifuPanel2.Controls.Add(this.label6);
            this.bunifuPanel2.Controls.Add(this.tglBlacklist);
            this.bunifuPanel2.Controls.Add(this.label7);
            this.bunifuPanel2.Controls.Add(this.tglBirthday);
            this.bunifuPanel2.Controls.Add(this.tglQRCard);
            this.bunifuPanel2.Location = new System.Drawing.Point(1007, 128);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(438, 140);
            this.bunifuPanel2.TabIndex = 189;
            // 
            // btnSalaryFiltering
            // 
            this.btnSalaryFiltering.AllowAnimations = true;
            this.btnSalaryFiltering.AllowMouseEffects = true;
            this.btnSalaryFiltering.AllowToggling = false;
            this.btnSalaryFiltering.AnimationSpeed = 50;
            this.btnSalaryFiltering.AutoGenerateColors = false;
            this.btnSalaryFiltering.AutoRoundBorders = false;
            this.btnSalaryFiltering.AutoSizeLeftIcon = true;
            this.btnSalaryFiltering.AutoSizeRightIcon = true;
            this.btnSalaryFiltering.BackColor = System.Drawing.Color.Transparent;
            this.btnSalaryFiltering.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalaryFiltering.BackgroundImage")));
            this.btnSalaryFiltering.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalaryFiltering.ButtonText = "";
            this.btnSalaryFiltering.ButtonTextMarginLeft = 0;
            this.btnSalaryFiltering.ColorContrastOnClick = 45;
            this.btnSalaryFiltering.ColorContrastOnHover = 45;
            this.btnSalaryFiltering.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnSalaryFiltering.CustomizableEdges = borderEdges4;
            this.btnSalaryFiltering.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalaryFiltering.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSalaryFiltering.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalaryFiltering.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSalaryFiltering.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSalaryFiltering.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryFiltering.ForeColor = System.Drawing.Color.White;
            this.btnSalaryFiltering.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalaryFiltering.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSalaryFiltering.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnSalaryFiltering.IconMarginLeft = 11;
            this.btnSalaryFiltering.IconPadding = 5;
            this.btnSalaryFiltering.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalaryFiltering.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSalaryFiltering.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnSalaryFiltering.IconSize = 25;
            this.btnSalaryFiltering.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.IdleBorderRadius = 10;
            this.btnSalaryFiltering.IdleBorderThickness = 1;
            this.btnSalaryFiltering.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.IdleIconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnSalaryFiltering.IdleIconRightImage = null;
            this.btnSalaryFiltering.IndicateFocus = false;
            this.btnSalaryFiltering.Location = new System.Drawing.Point(403, 105);
            this.btnSalaryFiltering.Name = "btnSalaryFiltering";
            this.btnSalaryFiltering.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSalaryFiltering.OnDisabledState.BorderRadius = 10;
            this.btnSalaryFiltering.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalaryFiltering.OnDisabledState.BorderThickness = 1;
            this.btnSalaryFiltering.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalaryFiltering.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSalaryFiltering.OnDisabledState.IconLeftImage = null;
            this.btnSalaryFiltering.OnDisabledState.IconRightImage = null;
            this.btnSalaryFiltering.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSalaryFiltering.onHoverState.BorderRadius = 10;
            this.btnSalaryFiltering.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalaryFiltering.onHoverState.BorderThickness = 1;
            this.btnSalaryFiltering.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSalaryFiltering.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSalaryFiltering.onHoverState.IconLeftImage = null;
            this.btnSalaryFiltering.onHoverState.IconRightImage = null;
            this.btnSalaryFiltering.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.OnIdleState.BorderRadius = 10;
            this.btnSalaryFiltering.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalaryFiltering.OnIdleState.BorderThickness = 1;
            this.btnSalaryFiltering.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSalaryFiltering.OnIdleState.IconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnSalaryFiltering.OnIdleState.IconRightImage = null;
            this.btnSalaryFiltering.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.OnPressedState.BorderRadius = 10;
            this.btnSalaryFiltering.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalaryFiltering.OnPressedState.BorderThickness = 1;
            this.btnSalaryFiltering.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnSalaryFiltering.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSalaryFiltering.OnPressedState.IconLeftImage = null;
            this.btnSalaryFiltering.OnPressedState.IconRightImage = null;
            this.btnSalaryFiltering.Size = new System.Drawing.Size(30, 30);
            this.btnSalaryFiltering.TabIndex = 190;
            this.btnSalaryFiltering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalaryFiltering.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalaryFiltering.TextMarginLeft = 0;
            this.btnSalaryFiltering.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSalaryFiltering.UseDefaultRadiusAndThickness = true;
            this.btnSalaryFiltering.Click += new System.EventHandler(this.btnSalaryFiltering_Click);
            // 
            // sliderSalary
            // 
            this.sliderSalary.AllowCursorChanges = true;
            this.sliderSalary.AllowHomeEndKeysDetection = false;
            this.sliderSalary.AllowIncrementalClickMoves = true;
            this.sliderSalary.AllowMouseDownEffects = false;
            this.sliderSalary.AllowMouseHoverEffects = false;
            this.sliderSalary.AllowScrollingAnimations = true;
            this.sliderSalary.AllowScrollKeysDetection = true;
            this.sliderSalary.AllowScrollOptionsMenu = true;
            this.sliderSalary.AllowShrinkingOnFocusLost = false;
            this.sliderSalary.BackColor = System.Drawing.Color.Transparent;
            this.sliderSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderSalary.BackgroundImage")));
            this.sliderSalary.BindingContainer = null;
            this.sliderSalary.BorderRadius = 2;
            this.sliderSalary.BorderThickness = 1;
            this.sliderSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderSalary.DrawThickBorder = false;
            this.sliderSalary.DurationBeforeShrink = 2000;
            this.sliderSalary.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.sliderSalary.LargeChange = 10;
            this.sliderSalary.Location = new System.Drawing.Point(13, 108);
            this.sliderSalary.Maximum = 100;
            this.sliderSalary.Minimum = 0;
            this.sliderSalary.MinimumSize = new System.Drawing.Size(0, 31);
            this.sliderSalary.MinimumThumbLength = 18;
            this.sliderSalary.Name = "sliderSalary";
            this.sliderSalary.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderSalary.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderSalary.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderSalary.ScrollBarBorderColor = System.Drawing.Color.White;
            this.sliderSalary.ScrollBarColor = System.Drawing.Color.White;
            this.sliderSalary.ShrinkSizeLimit = 3;
            this.sliderSalary.Size = new System.Drawing.Size(380, 31);
            this.sliderSalary.SliderColor = System.Drawing.Color.White;
            this.sliderSalary.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sliderSalary.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderSalary.SmallChange = 1;
            this.sliderSalary.TabIndex = 169;
            this.sliderSalary.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.sliderSalary.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.sliderSalary.ThumbLength = 37;
            this.sliderSalary.ThumbMargin = 1;
            this.sliderSalary.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.sliderSalary.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.sliderSalary.Value = 50;
            this.sliderSalary.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.sliderSalary_Scroll);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Black;
            this.lblSalary.Location = new System.Drawing.Point(210, 82);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 20);
            this.lblSalary.TabIndex = 189;
            this.lblSalary.Text = "Salary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(10, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 16);
            this.label16.TabIndex = 188;
            this.label16.Text = "მაქსიმალური ხელფასი:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(211, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 186;
            this.label15.Text = "EMS Bot";
            // 
            // tglBot
            // 
            this.tglBot.AutoSize = true;
            this.tglBot.Location = new System.Drawing.Point(316, 48);
            this.tglBot.MinimumSize = new System.Drawing.Size(50, 22);
            this.tglBot.Name = "tglBot";
            this.tglBot.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tglBot.OffToggleColor = System.Drawing.Color.White;
            this.tglBot.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.tglBot.OnToggleColor = System.Drawing.Color.White;
            this.tglBot.Size = new System.Drawing.Size(50, 22);
            this.tglBot.TabIndex = 187;
            this.tglBot.UseVisualStyleBackColor = true;
            this.tglBot.CheckedChanged += new System.EventHandler(this.tglBot_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(211, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 164;
            this.label5.Text = "QR ბარათი";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 165;
            this.label6.Text = "დაბადების დღე";
            // 
            // tglBlacklist
            // 
            this.tglBlacklist.AutoSize = true;
            this.tglBlacklist.Location = new System.Drawing.Point(138, 48);
            this.tglBlacklist.MinimumSize = new System.Drawing.Size(50, 22);
            this.tglBlacklist.Name = "tglBlacklist";
            this.tglBlacklist.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tglBlacklist.OffToggleColor = System.Drawing.Color.White;
            this.tglBlacklist.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.tglBlacklist.OnToggleColor = System.Drawing.Color.White;
            this.tglBlacklist.Size = new System.Drawing.Size(50, 22);
            this.tglBlacklist.TabIndex = 185;
            this.tglBlacklist.UseVisualStyleBackColor = true;
            this.tglBlacklist.CheckedChanged += new System.EventHandler(this.tglBlacklist_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 166;
            this.label7.Text = "შავი სია";
            // 
            // tglBirthday
            // 
            this.tglBirthday.AutoSize = true;
            this.tglBirthday.Location = new System.Drawing.Point(138, 13);
            this.tglBirthday.MinimumSize = new System.Drawing.Size(50, 22);
            this.tglBirthday.Name = "tglBirthday";
            this.tglBirthday.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tglBirthday.OffToggleColor = System.Drawing.Color.White;
            this.tglBirthday.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.tglBirthday.OnToggleColor = System.Drawing.Color.White;
            this.tglBirthday.Size = new System.Drawing.Size(50, 22);
            this.tglBirthday.TabIndex = 184;
            this.tglBirthday.UseVisualStyleBackColor = true;
            this.tglBirthday.CheckedChanged += new System.EventHandler(this.tglBirthday_CheckedChanged);
            // 
            // tglQRCard
            // 
            this.tglQRCard.AutoSize = true;
            this.tglQRCard.Location = new System.Drawing.Point(316, 13);
            this.tglQRCard.MinimumSize = new System.Drawing.Size(50, 22);
            this.tglQRCard.Name = "tglQRCard";
            this.tglQRCard.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tglQRCard.OffToggleColor = System.Drawing.Color.White;
            this.tglQRCard.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.tglQRCard.OnToggleColor = System.Drawing.Color.White;
            this.tglQRCard.Size = new System.Drawing.Size(50, 22);
            this.tglQRCard.TabIndex = 183;
            this.tglQRCard.UseVisualStyleBackColor = true;
            this.tglQRCard.CheckedChanged += new System.EventHandler(this.tglQRCard_CheckedChanged);
            // 
            // employeeShortInfoTableAdapter
            // 
            this.employeeShortInfoTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dgvEmployeeFullInfo;
            // 
            // EmployeeFullInfoFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFilteringPrimary);
            this.Controls.Add(this.dgvEmployeeFullInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeFullInfoFiltering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeFullInfo";
            this.Load += new System.EventHandler(this.EmployeeFullInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeFullInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEmployeeFullInfo;
        private Custom_Controls.CustomTextBoxRounded txtSurname;
        private Custom_Controls.CustomTextBoxRounded txtName;
        private Custom_Controls.CustomTextBoxRounded txtPassportID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom_Controls.CustomComboBox cboEmployeeID;
        private System.Windows.Forms.Label label4;
        private Custom_Controls.CustomComboBox cboCountry;
        private System.Windows.Forms.Label label10;
        private Custom_Controls.CustomTextBoxRounded txtEmail;
        private Custom_Controls.CustomTextBoxRounded txtTelephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Custom_Controls.CustomTextBoxRounded txtStreet;
        private Custom_Controls.CustomTextBoxRounded txtCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Custom_Controls.CustomTextBoxRounded txtPosition;
        private System.Windows.Forms.Label label35;
        private Custom_Controls.CustomComboBox cboDepartment;
        private System.Windows.Forms.Label label13;
        private Custom_Controls.CustomComboBox cboStatus;
        private System.Windows.Forms.Label label14;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFilteringPrimary;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private EMSDataSet eMSDataSet;
        private System.Windows.Forms.BindingSource employeeShortInfoBindingSource;
        private EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter employeeShortInfoTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private EMSDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private EMSDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Custom_Controls.CustomToggleButton tglBlacklist;
        private Custom_Controls.CustomToggleButton tglBirthday;
        private Custom_Controls.CustomToggleButton tglQRCard;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuHSlider sliderSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Custom_Controls.CustomToggleButton tglBot;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSalaryFiltering;
    }
}