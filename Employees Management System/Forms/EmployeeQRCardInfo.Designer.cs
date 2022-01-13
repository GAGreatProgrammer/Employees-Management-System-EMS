
namespace Employees_Management_System.Forms
{
    partial class EmployeeQRCardInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeQRCardInfo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvEmployeeQRCard = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFiltering = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQRCardID = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.tglBlocked = new Employees_Management_System.Custom_Controls.CustomToggleButton();
            this.tglPermanentCard = new Employees_Management_System.Custom_Controls.CustomToggleButton();
            this.cboEmployeeID = new Employees_Management_System.Custom_Controls.CustomComboBox();
            this.employeeShortInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet = new Employees_Management_System.EMSDataSet();
            this.employeeShortInfoTableAdapter = new Employees_Management_System.EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeQRCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeQRCard
            // 
            this.dgvEmployeeQRCard.AllowCustomTheming = false;
            this.dgvEmployeeQRCard.AllowUserToAddRows = false;
            this.dgvEmployeeQRCard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeQRCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeQRCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeQRCard.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeQRCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeQRCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployeeQRCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeQRCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeQRCard.ColumnHeadersHeight = 40;
            this.dgvEmployeeQRCard.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEmployeeQRCard.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeQRCard.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeQRCard.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployeeQRCard.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeQRCard.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeQRCard.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployeeQRCard.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployeeQRCard.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeQRCard.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployeeQRCard.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEmployeeQRCard.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployeeQRCard.CurrentTheme.Name = null;
            this.dgvEmployeeQRCard.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeQRCard.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeQRCard.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeQRCard.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmployeeQRCard.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeQRCard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeQRCard.EnableHeadersVisualStyles = false;
            this.dgvEmployeeQRCard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmployeeQRCard.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmployeeQRCard.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEmployeeQRCard.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEmployeeQRCard.Location = new System.Drawing.Point(12, 188);
            this.dgvEmployeeQRCard.Name = "dgvEmployeeQRCard";
            this.dgvEmployeeQRCard.ReadOnly = true;
            this.dgvEmployeeQRCard.RowHeadersVisible = false;
            this.dgvEmployeeQRCard.RowTemplate.Height = 40;
            this.dgvEmployeeQRCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeQRCard.Size = new System.Drawing.Size(847, 482);
            this.dgvEmployeeQRCard.TabIndex = 0;
            this.dgvEmployeeQRCard.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEmployeeQRCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeQRCard_CellClick);
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
            this.btnReload.Location = new System.Drawing.Point(324, 135);
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
            this.btnReload.TabIndex = 163;
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
            this.btnCancel.Location = new System.Drawing.Point(168, 135);
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
            this.btnCancel.TabIndex = 162;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.btnFiltering.CustomizableEdges = borderEdges3;
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
            this.btnFiltering.Location = new System.Drawing.Point(12, 135);
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
            this.btnFiltering.TabIndex = 161;
            this.btnFiltering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltering.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltering.TextMarginLeft = 0;
            this.btnFiltering.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFiltering.UseDefaultRadiusAndThickness = true;
            this.btnFiltering.Click += new System.EventHandler(this.btnFiltering_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 164;
            this.label1.Text = "თანამშრომლის ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 167;
            this.label2.Text = "QR ბარათის ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(558, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 185;
            this.label3.Text = "მუდმივი QR ბარათი";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(558, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 186;
            this.label4.Text = "დაბლოკილი QR ბარათი";
            // 
            // txtQRCardID
            // 
            this.txtQRCardID.BackColor = System.Drawing.Color.White;
            this.txtQRCardID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.txtQRCardID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtQRCardID.BorderRadius = 0;
            this.txtQRCardID.BorderSize = 1;
            this.txtQRCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRCardID.ForeColor = System.Drawing.Color.Black;
            this.txtQRCardID.Location = new System.Drawing.Point(198, 78);
            this.txtQRCardID.Multiline = false;
            this.txtQRCardID.Name = "txtQRCardID";
            this.txtQRCardID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQRCardID.PasswordChar = false;
            this.txtQRCardID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQRCardID.PlaceholderText = "";
            this.txtQRCardID.Size = new System.Drawing.Size(330, 35);
            this.txtQRCardID.TabIndex = 187;
            this.txtQRCardID.UnderlinedStyle = false;
            // 
            // tglBlocked
            // 
            this.tglBlocked.AutoSize = true;
            this.tglBlocked.Location = new System.Drawing.Point(795, 84);
            this.tglBlocked.MinimumSize = new System.Drawing.Size(50, 22);
            this.tglBlocked.Name = "tglBlocked";
            this.tglBlocked.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tglBlocked.OffToggleColor = System.Drawing.Color.White;
            this.tglBlocked.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.tglBlocked.OnToggleColor = System.Drawing.Color.White;
            this.tglBlocked.Size = new System.Drawing.Size(50, 22);
            this.tglBlocked.TabIndex = 184;
            this.tglBlocked.UseVisualStyleBackColor = true;
            this.tglBlocked.CheckedChanged += new System.EventHandler(this.tglBlocked_CheckedChanged);
            // 
            // tglPermanentCard
            // 
            this.tglPermanentCard.AutoSize = true;
            this.tglPermanentCard.Location = new System.Drawing.Point(795, 18);
            this.tglPermanentCard.MinimumSize = new System.Drawing.Size(50, 22);
            this.tglPermanentCard.Name = "tglPermanentCard";
            this.tglPermanentCard.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tglPermanentCard.OffToggleColor = System.Drawing.Color.White;
            this.tglPermanentCard.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.tglPermanentCard.OnToggleColor = System.Drawing.Color.White;
            this.tglPermanentCard.Size = new System.Drawing.Size(50, 22);
            this.tglPermanentCard.TabIndex = 183;
            this.tglPermanentCard.UseVisualStyleBackColor = true;
            this.tglPermanentCard.CheckedChanged += new System.EventHandler(this.tglPermanentCard_CheckedChanged);
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
            this.cboEmployeeID.Location = new System.Drawing.Point(198, 13);
            this.cboEmployeeID.MaxDropDownItems = 8;
            this.cboEmployeeID.MinimumSize = new System.Drawing.Size(200, 35);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Padding = new System.Windows.Forms.Padding(1);
            this.cboEmployeeID.Size = new System.Drawing.Size(330, 35);
            this.cboEmployeeID.TabIndex = 165;
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
            // employeeShortInfoTableAdapter
            // 
            this.employeeShortInfoTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeQRCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 683);
            this.Controls.Add(this.txtQRCardID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tglBlocked);
            this.Controls.Add(this.tglPermanentCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFiltering);
            this.Controls.Add(this.dgvEmployeeQRCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeQRCardInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "თანამშრომლის QR ბარათი";
            this.Load += new System.EventHandler(this.EmployeeQRCardInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeQRCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeShortInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEmployeeQRCard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFiltering;
        private Custom_Controls.CustomComboBox cboEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Custom_Controls.CustomToggleButton tglPermanentCard;
        private Custom_Controls.CustomToggleButton tglBlocked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Custom_Controls.CustomTextBoxRounded txtQRCardID;
        private EMSDataSet eMSDataSet;
        private System.Windows.Forms.BindingSource employeeShortInfoBindingSource;
        private EMSDataSetTableAdapters.EmployeeShortInfoTableAdapter employeeShortInfoTableAdapter;
    }
}