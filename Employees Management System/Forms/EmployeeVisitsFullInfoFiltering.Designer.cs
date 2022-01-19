
namespace Employees_Management_System.Forms
{
    partial class EmployeeVisitsFullInfoFiltering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeVisitsFullInfoFiltering));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnFilteringPrimary = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cboStatus = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dtpDate = new Employees_Management_System.Custom_Controls.CustomDateTimePicker();
            this.cboType = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.txtTime = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelephone = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassportID = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPosition = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.label35 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDepartment = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new Employees_Management_System.EMSDataSet();
            this.cboEmployeeID = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.employeeShortInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvEmployeeVisitsFullInfo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.employeeShortInfoTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter();
            this.departmentTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.DepartmentTableAdapter();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeVisitsFullInfo)).BeginInit();
            this.SuspendLayout();
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
            this.btnFilteringPrimary.ButtonText = "ფილტრაცია";
            this.btnFilteringPrimary.ButtonTextMarginLeft = 0;
            this.btnFilteringPrimary.ColorContrastOnClick = 45;
            this.btnFilteringPrimary.ColorContrastOnHover = 45;
            this.btnFilteringPrimary.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = false;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = false;
            this.btnFilteringPrimary.CustomizableEdges = borderEdges1;
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
            this.btnFilteringPrimary.Size = new System.Drawing.Size(170, 35);
            this.btnFilteringPrimary.TabIndex = 169;
            this.btnFilteringPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilteringPrimary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilteringPrimary.TextMarginLeft = 0;
            this.btnFilteringPrimary.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFilteringPrimary.UseDefaultRadiusAndThickness = true;
            this.btnFilteringPrimary.Click += new System.EventHandler(this.btnFilteringPrimary_Click);
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
            this.cboStatus.Location = new System.Drawing.Point(665, 68);
            this.cboStatus.MaxDropDownItems = 8;
            this.cboStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cboStatus.Size = new System.Drawing.Size(310, 35);
            this.cboStatus.TabIndex = 163;
            this.cboStatus.OnSelectedIndexChanged += new System.EventHandler(this.cboStatus_OnSelectedIndexChanged);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.bunifuPanel1.BorderRadius = 15;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dtpDate);
            this.bunifuPanel1.Controls.Add(this.cboType);
            this.bunifuPanel1.Controls.Add(this.txtTime);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.txtTelephone);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.cboStatus);
            this.bunifuPanel1.Controls.Add(this.txtPassportID);
            this.bunifuPanel1.Controls.Add(this.label14);
            this.bunifuPanel1.Controls.Add(this.txtPosition);
            this.bunifuPanel1.Controls.Add(this.label35);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.cboDepartment);
            this.bunifuPanel1.Controls.Add(this.cboEmployeeID);
            this.bunifuPanel1.Controls.Add(this.label13);
            this.bunifuPanel1.Controls.Add(this.label8);
            this.bunifuPanel1.Controls.Add(this.label9);
            this.bunifuPanel1.Controls.Add(this.txtEmail);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(996, 287);
            this.bunifuPanel1.TabIndex = 172;
            // 
            // dtpDate
            // 
            this.dtpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.dtpDate.BorderSize = 0;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDate.Location = new System.Drawing.Point(665, 128);
            this.dtpDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(310, 35);
            this.dtpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.dtpDate.TabIndex = 169;
            this.dtpDate.TextColor = System.Drawing.Color.White;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cboType
            // 
            this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboType.BackColor = System.Drawing.Color.White;
            this.cboType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboType.BorderSize = 1;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.DropDownWidth = 198;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.ForeColor = System.Drawing.Color.Black;
            this.cboType.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboType.IntegralHeight = true;
            this.cboType.Items.AddRange(new object[] {
            "მოსვლა",
            "წასვლა"});
            this.cboType.ListBackColor = System.Drawing.Color.White;
            this.cboType.ListTextColor = System.Drawing.Color.Black;
            this.cboType.Location = new System.Drawing.Point(665, 238);
            this.cboType.MaxDropDownItems = 8;
            this.cboType.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboType.Name = "cboType";
            this.cboType.Padding = new System.Windows.Forms.Padding(1);
            this.cboType.Size = new System.Drawing.Size(310, 35);
            this.cboType.TabIndex = 168;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.White;
            this.txtTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtTime.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtTime.BorderRadius = 0;
            this.txtTime.BorderSize = 1;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Black;
            this.txtTime.Location = new System.Drawing.Point(665, 185);
            this.txtTime.Multiline = false;
            this.txtTime.Name = "txtTime";
            this.txtTime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTime.PasswordChar = false;
            this.txtTime.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTime.PlaceholderText = "";
            this.txtTime.Size = new System.Drawing.Size(310, 35);
            this.txtTime.TabIndex = 167;
            this.txtTime.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 166;
            this.label6.Text = "ტიპი";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(533, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 165;
            this.label5.Text = "დრო";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(533, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 164;
            this.label3.Text = "თარიღი";
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
            this.txtTelephone.Location = new System.Drawing.Point(171, 128);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(533, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 162;
            this.label14.Text = "სტატუსი";
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
            this.txtPosition.Location = new System.Drawing.Point(665, 10);
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
            this.label35.Location = new System.Drawing.Point(533, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 20);
            this.label35.TabIndex = 159;
            this.label35.Text = "პოზიცია";
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
            this.cboDepartment.Location = new System.Drawing.Point(171, 238);
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
            // eMSDataSet
            // 
            this.eMSDataSet.DataSetName = "EMSDataSet";
            this.eMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 156;
            this.label13.Text = "დეპარტამენტი";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 144;
            this.label8.Text = "ტელეფონი";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 145;
            this.label9.Text = "ელ.ფოსტა";
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
            this.txtEmail.Location = new System.Drawing.Point(171, 185);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dgvEmployeeVisitsFullInfo;
            // 
            // dgvEmployeeVisitsFullInfo
            // 
            this.dgvEmployeeVisitsFullInfo.AllowCustomTheming = false;
            this.dgvEmployeeVisitsFullInfo.AllowUserToAddRows = false;
            this.dgvEmployeeVisitsFullInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeVisitsFullInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeVisitsFullInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeVisitsFullInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeVisitsFullInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeVisitsFullInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployeeVisitsFullInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeVisitsFullInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeVisitsFullInfo.ColumnHeadersHeight = 40;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.Name = null;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployeeVisitsFullInfo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeVisitsFullInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeVisitsFullInfo.EnableHeadersVisualStyles = false;
            this.dgvEmployeeVisitsFullInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployeeVisitsFullInfo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployeeVisitsFullInfo.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEmployeeVisitsFullInfo.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEmployeeVisitsFullInfo.Location = new System.Drawing.Point(12, 349);
            this.dgvEmployeeVisitsFullInfo.Name = "dgvEmployeeVisitsFullInfo";
            this.dgvEmployeeVisitsFullInfo.ReadOnly = true;
            this.dgvEmployeeVisitsFullInfo.RowHeadersVisible = false;
            this.dgvEmployeeVisitsFullInfo.RowTemplate.Height = 40;
            this.dgvEmployeeVisitsFullInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeVisitsFullInfo.Size = new System.Drawing.Size(996, 568);
            this.dgvEmployeeVisitsFullInfo.TabIndex = 168;
            this.dgvEmployeeVisitsFullInfo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEmployeeVisitsFullInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeVisitsFullInfo_CellClick);
            this.dgvEmployeeVisitsFullInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeVisitsFullInfo_CellDoubleClick);
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
            this.btnCancel.Location = new System.Drawing.Point(188, 305);
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
            this.btnCancel.TabIndex = 170;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnReload.CustomizableEdges = borderEdges3;
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
            this.btnReload.Location = new System.Drawing.Point(344, 305);
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
            this.btnReload.TabIndex = 171;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.TextMarginLeft = 0;
            this.btnReload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload.UseDefaultRadiusAndThickness = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // employeeShortInfoTableAdapter
            // 
            this.employeeShortInfoTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeVisitsFullInfoFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 929);
            this.Controls.Add(this.btnFilteringPrimary);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.dgvEmployeeVisitsFullInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeVisitsFullInfoFiltering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "თანამშრომლის ვიზიტების ფილტრაცია";
            this.Load += new System.EventHandler(this.EmployeeVisitsFullInfoFiltering_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeVisitsFullInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFilteringPrimary;
        private Custom_Controls.CustomComboBox cboStatus;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Custom_Controls.CustomComboBox cboType;
        private Custom_Controls.CustomTextBoxRounded txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Custom_Controls.CustomTextBoxRounded txtTelephone;
        private System.Windows.Forms.Label label1;
        private Custom_Controls.CustomTextBoxRounded txtPassportID;
        private System.Windows.Forms.Label label14;
        private Custom_Controls.CustomTextBoxRounded txtPosition;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label4;
        private Custom_Controls.CustomComboBox cboDepartment;
        private Custom_Controls.CustomComboBox cboEmployeeID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Custom_Controls.CustomTextBoxRounded txtEmail;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEmployeeVisitsFullInfo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
        private Custom_Controls.CustomDateTimePicker dtpDate;
        private EMSDataSet eMSDataSet;
        private System.Windows.Forms.BindingSource employeeShortInfoBindingSource;
        private EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter employeeShortInfoTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private EMSDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
    }
}