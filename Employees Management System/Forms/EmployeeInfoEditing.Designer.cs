
namespace Employees_Management_System.Forms
{
    partial class EmployeeInfoEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfoEditing));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvEmployees = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFiltering = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.cboEmployeeID = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.employeeShortInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new Employees_Management_System.EMSDataSet();
            this.txtName = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtPassportID = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.employeeShortInfoTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter();
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowCustomTheming = false;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.ColumnHeadersHeight = 40;
            this.dgvEmployees.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEmployees.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployees.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployees.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployees.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployees.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployees.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployees.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployees.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployees.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEmployees.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployees.CurrentTheme.Name = null;
            this.dgvEmployees.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployees.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployees.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployees.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployees.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployees.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEmployees.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEmployees.Location = new System.Drawing.Point(19, 190);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 40;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(966, 548);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            this.dgvEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellDoubleClick);
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
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
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
            this.btnCancel.Location = new System.Drawing.Point(175, 137);
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
            this.btnCancel.TabIndex = 61;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFiltering
            // 
            this.btnFiltering.AllowAnimations = true;
            this.btnFiltering.AllowMouseEffects = true;
            this.btnFiltering.AllowToggling = false;
            this.btnFiltering.AnimationSpeed = 50;
            this.btnFiltering.AutoGenerateColors = false;
            this.btnFiltering.AutoRoundBorders = false;
            this.btnFiltering.AutoSizeLeftIcon = true;
            this.btnFiltering.AutoSizeRightIcon = true;
            this.btnFiltering.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltering.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltering.BackgroundImage")));
            this.btnFiltering.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltering.ButtonText = "ფილტრაცია";
            this.btnFiltering.ButtonTextMarginLeft = 0;
            this.btnFiltering.ColorContrastOnClick = 45;
            this.btnFiltering.ColorContrastOnHover = 45;
            this.btnFiltering.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.btnFiltering.CustomizableEdges = borderEdges2;
            this.btnFiltering.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltering.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFiltering.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFiltering.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFiltering.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFiltering.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltering.ForeColor = System.Drawing.Color.White;
            this.btnFiltering.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltering.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltering.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFiltering.IconMarginLeft = 11;
            this.btnFiltering.IconPadding = 10;
            this.btnFiltering.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltering.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltering.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFiltering.IconSize = 25;
            this.btnFiltering.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.IdleBorderRadius = 10;
            this.btnFiltering.IdleBorderThickness = 1;
            this.btnFiltering.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.IdleIconLeftImage = null;
            this.btnFiltering.IdleIconRightImage = null;
            this.btnFiltering.IndicateFocus = false;
            this.btnFiltering.Location = new System.Drawing.Point(19, 137);
            this.btnFiltering.Name = "btnFiltering";
            this.btnFiltering.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFiltering.OnDisabledState.BorderRadius = 10;
            this.btnFiltering.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltering.OnDisabledState.BorderThickness = 1;
            this.btnFiltering.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFiltering.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFiltering.OnDisabledState.IconLeftImage = null;
            this.btnFiltering.OnDisabledState.IconRightImage = null;
            this.btnFiltering.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFiltering.onHoverState.BorderRadius = 10;
            this.btnFiltering.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltering.onHoverState.BorderThickness = 1;
            this.btnFiltering.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFiltering.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFiltering.onHoverState.IconLeftImage = null;
            this.btnFiltering.onHoverState.IconRightImage = null;
            this.btnFiltering.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.OnIdleState.BorderRadius = 10;
            this.btnFiltering.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltering.OnIdleState.BorderThickness = 1;
            this.btnFiltering.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFiltering.OnIdleState.IconLeftImage = null;
            this.btnFiltering.OnIdleState.IconRightImage = null;
            this.btnFiltering.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.OnPressedState.BorderRadius = 10;
            this.btnFiltering.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiltering.OnPressedState.BorderThickness = 1;
            this.btnFiltering.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnFiltering.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFiltering.OnPressedState.IconLeftImage = null;
            this.btnFiltering.OnPressedState.IconRightImage = null;
            this.btnFiltering.Size = new System.Drawing.Size(150, 35);
            this.btnFiltering.TabIndex = 59;
            this.btnFiltering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltering.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltering.TextMarginLeft = 0;
            this.btnFiltering.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFiltering.UseDefaultRadiusAndThickness = true;
            this.btnFiltering.Click += new System.EventHandler(this.btnFiltering_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(565, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "გვარი";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(565, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "სახელი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "პირადი ნომერი";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "თანამშრომლის ID";
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
            this.txtSurname.Location = new System.Drawing.Point(655, 78);
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSurname.PasswordChar = false;
            this.txtSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSurname.PlaceholderText = "";
            this.txtSurname.Size = new System.Drawing.Size(330, 35);
            this.txtSurname.TabIndex = 8;
            this.txtSurname.UnderlinedStyle = false;
            // 
            // cboEmployeeID
            // 
            this.cboEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboEmployeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmployeeID.BackColor = System.Drawing.Color.White;
            this.cboEmployeeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboEmployeeID.BorderSize = 1;
            this.cboEmployeeID.DataSource = this.employeeShortInfoBindingSource;
            this.cboEmployeeID.DisplayMember = "Employee";
            this.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeeID.DropDownWidth = 198;
            this.cboEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.cboEmployeeID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cboEmployeeID.IntegralHeight = false;
            this.cboEmployeeID.ListBackColor = System.Drawing.Color.White;
            this.cboEmployeeID.ListTextColor = System.Drawing.Color.Black;
            this.cboEmployeeID.Location = new System.Drawing.Point(201, 14);
            this.cboEmployeeID.MaxDropDownItems = 8;
            this.cboEmployeeID.MinimumSize = new System.Drawing.Size(200, 35);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Padding = new System.Windows.Forms.Padding(1);
            this.cboEmployeeID.Size = new System.Drawing.Size(330, 35);
            this.cboEmployeeID.TabIndex = 6;
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
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(655, 14);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(330, 35);
            this.txtName.TabIndex = 7;
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
            this.txtPassportID.Location = new System.Drawing.Point(201, 78);
            this.txtPassportID.Multiline = false;
            this.txtPassportID.Name = "txtPassportID";
            this.txtPassportID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassportID.PasswordChar = false;
            this.txtPassportID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassportID.PlaceholderText = "";
            this.txtPassportID.Size = new System.Drawing.Size(330, 35);
            this.txtPassportID.TabIndex = 1;
            this.txtPassportID.UnderlinedStyle = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dgvEmployees;
            // 
            // employeeShortInfoTableAdapter
            // 
            this.employeeShortInfoTableAdapter.ClearBeforeFill = true;
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
            this.btnReload.Location = new System.Drawing.Point(331, 137);
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
            this.btnReload.TabIndex = 160;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.TextMarginLeft = 0;
            this.btnReload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload.UseDefaultRadiusAndThickness = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // EmployeeInfoEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1001, 750);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnFiltering);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.cboEmployeeID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassportID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeInfoEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "თანამშრომლის ინფორმაციის რედაქტირება";
            this.Load += new System.EventHandler(this.EmployeeInfoEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEmployees;
        private Custom_Controls.CustomTextBoxRounded txtPassportID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom_Controls.CustomTextBoxRounded txtSurname;
        private Custom_Controls.CustomTextBoxRounded txtName;
        private Custom_Controls.CustomComboBox cboEmployeeID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFiltering;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private EMSDataSet eMSDataSet;
        private System.Windows.Forms.BindingSource employeeShortInfoBindingSource;
        private EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter employeeShortInfoTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
    }
}