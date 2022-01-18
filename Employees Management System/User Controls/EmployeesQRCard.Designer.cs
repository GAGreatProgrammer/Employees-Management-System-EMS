
namespace Employees_Management_System.User_Controls
{
    partial class EmployeesQRCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesQRCard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnQRCardRegistration = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblQRCardCount = new System.Windows.Forms.Label();
            this.lblActiveQRCard = new System.Windows.Forms.Label();
            this.lblOverdueQRCard = new System.Windows.Forms.Label();
            this.lblBlockedQRCard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnReadQR = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCamera = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtQRCardID = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtPosition = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtTelephone = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtCountry = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtFathersName = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtSurname = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtName = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            this.txtPassportID = new Employees_Management_System.Custom_Controls.CustomTextBoxRounded();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Employees_Management_System.Properties.Resources.Employee_QR_Card;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1195, 740);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.AllowAnimations = true;
            this.bunifuButton4.AllowMouseEffects = true;
            this.bunifuButton4.AllowToggling = false;
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.AutoRoundBorders = false;
            this.bunifuButton4.AutoSizeLeftIcon = true;
            this.bunifuButton4.AutoSizeRightIcon = true;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "განსაზღვრა";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges6;
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton4.IconSize = 25;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.IdleBorderRadius = 20;
            this.bunifuButton4.IdleBorderThickness = 1;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = false;
            this.bunifuButton4.Location = new System.Drawing.Point(637, 244);
            this.bunifuButton4.Name = "bunifuButton4";
            this.bunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.OnDisabledState.BorderRadius = 20;
            this.bunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnDisabledState.BorderThickness = 1;
            this.bunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.OnDisabledState.IconLeftImage = null;
            this.bunifuButton4.OnDisabledState.IconRightImage = null;
            this.bunifuButton4.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton4.onHoverState.BorderRadius = 20;
            this.bunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.onHoverState.BorderThickness = 1;
            this.bunifuButton4.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton4.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.onHoverState.IconLeftImage = null;
            this.bunifuButton4.onHoverState.IconRightImage = null;
            this.bunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnIdleState.BorderRadius = 20;
            this.bunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnIdleState.BorderThickness = 1;
            this.bunifuButton4.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnIdleState.IconLeftImage = null;
            this.bunifuButton4.OnIdleState.IconRightImage = null;
            this.bunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.BorderRadius = 20;
            this.bunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnPressedState.BorderThickness = 1;
            this.bunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnPressedState.IconLeftImage = null;
            this.bunifuButton4.OnPressedState.IconRightImage = null;
            this.bunifuButton4.Size = new System.Drawing.Size(200, 39);
            this.bunifuButton4.TabIndex = 6;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            // 
            // btnQRCardRegistration
            // 
            this.btnQRCardRegistration.AllowAnimations = true;
            this.btnQRCardRegistration.AllowMouseEffects = true;
            this.btnQRCardRegistration.AllowToggling = false;
            this.btnQRCardRegistration.AnimationSpeed = 200;
            this.btnQRCardRegistration.AutoGenerateColors = false;
            this.btnQRCardRegistration.AutoRoundBorders = false;
            this.btnQRCardRegistration.AutoSizeLeftIcon = true;
            this.btnQRCardRegistration.AutoSizeRightIcon = true;
            this.btnQRCardRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnQRCardRegistration.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQRCardRegistration.BackgroundImage")));
            this.btnQRCardRegistration.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQRCardRegistration.ButtonText = "გენერაცია";
            this.btnQRCardRegistration.ButtonTextMarginLeft = 0;
            this.btnQRCardRegistration.ColorContrastOnClick = 45;
            this.btnQRCardRegistration.ColorContrastOnHover = 45;
            this.btnQRCardRegistration.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnQRCardRegistration.CustomizableEdges = borderEdges7;
            this.btnQRCardRegistration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQRCardRegistration.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnQRCardRegistration.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnQRCardRegistration.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnQRCardRegistration.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnQRCardRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCardRegistration.ForeColor = System.Drawing.Color.White;
            this.btnQRCardRegistration.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQRCardRegistration.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnQRCardRegistration.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnQRCardRegistration.IconMarginLeft = 11;
            this.btnQRCardRegistration.IconPadding = 10;
            this.btnQRCardRegistration.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQRCardRegistration.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnQRCardRegistration.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnQRCardRegistration.IconSize = 25;
            this.btnQRCardRegistration.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.IdleBorderRadius = 20;
            this.btnQRCardRegistration.IdleBorderThickness = 1;
            this.btnQRCardRegistration.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.IdleIconLeftImage = null;
            this.btnQRCardRegistration.IdleIconRightImage = null;
            this.btnQRCardRegistration.IndicateFocus = false;
            this.btnQRCardRegistration.Location = new System.Drawing.Point(935, 244);
            this.btnQRCardRegistration.Name = "btnQRCardRegistration";
            this.btnQRCardRegistration.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnQRCardRegistration.OnDisabledState.BorderRadius = 20;
            this.btnQRCardRegistration.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQRCardRegistration.OnDisabledState.BorderThickness = 1;
            this.btnQRCardRegistration.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnQRCardRegistration.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnQRCardRegistration.OnDisabledState.IconLeftImage = null;
            this.btnQRCardRegistration.OnDisabledState.IconRightImage = null;
            this.btnQRCardRegistration.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnQRCardRegistration.onHoverState.BorderRadius = 20;
            this.btnQRCardRegistration.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQRCardRegistration.onHoverState.BorderThickness = 1;
            this.btnQRCardRegistration.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnQRCardRegistration.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnQRCardRegistration.onHoverState.IconLeftImage = null;
            this.btnQRCardRegistration.onHoverState.IconRightImage = null;
            this.btnQRCardRegistration.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.OnIdleState.BorderRadius = 20;
            this.btnQRCardRegistration.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQRCardRegistration.OnIdleState.BorderThickness = 1;
            this.btnQRCardRegistration.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnQRCardRegistration.OnIdleState.IconLeftImage = null;
            this.btnQRCardRegistration.OnIdleState.IconRightImage = null;
            this.btnQRCardRegistration.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.OnPressedState.BorderRadius = 20;
            this.btnQRCardRegistration.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQRCardRegistration.OnPressedState.BorderThickness = 1;
            this.btnQRCardRegistration.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnQRCardRegistration.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnQRCardRegistration.OnPressedState.IconLeftImage = null;
            this.btnQRCardRegistration.OnPressedState.IconRightImage = null;
            this.btnQRCardRegistration.Size = new System.Drawing.Size(200, 39);
            this.btnQRCardRegistration.TabIndex = 7;
            this.btnQRCardRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQRCardRegistration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQRCardRegistration.TextMarginLeft = 0;
            this.btnQRCardRegistration.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnQRCardRegistration.UseDefaultRadiusAndThickness = true;
            this.btnQRCardRegistration.Click += new System.EventHandler(this.btnQRCardRegistration_Click);
            // 
            // lblQRCardCount
            // 
            this.lblQRCardCount.AutoSize = true;
            this.lblQRCardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCardCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblQRCardCount.Location = new System.Drawing.Point(42, 97);
            this.lblQRCardCount.Name = "lblQRCardCount";
            this.lblQRCardCount.Size = new System.Drawing.Size(31, 33);
            this.lblQRCardCount.TabIndex = 16;
            this.lblQRCardCount.Text = "0";
            // 
            // lblActiveQRCard
            // 
            this.lblActiveQRCard.AutoSize = true;
            this.lblActiveQRCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveQRCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblActiveQRCard.Location = new System.Drawing.Point(332, 97);
            this.lblActiveQRCard.Name = "lblActiveQRCard";
            this.lblActiveQRCard.Size = new System.Drawing.Size(31, 33);
            this.lblActiveQRCard.TabIndex = 17;
            this.lblActiveQRCard.Text = "0";
            // 
            // lblOverdueQRCard
            // 
            this.lblOverdueQRCard.AutoSize = true;
            this.lblOverdueQRCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueQRCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblOverdueQRCard.Location = new System.Drawing.Point(42, 250);
            this.lblOverdueQRCard.Name = "lblOverdueQRCard";
            this.lblOverdueQRCard.Size = new System.Drawing.Size(31, 33);
            this.lblOverdueQRCard.TabIndex = 18;
            this.lblOverdueQRCard.Text = "0";
            // 
            // lblBlockedQRCard
            // 
            this.lblBlockedQRCard.AutoSize = true;
            this.lblBlockedQRCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockedQRCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblBlockedQRCard.Location = new System.Drawing.Point(332, 250);
            this.lblBlockedQRCard.Name = "lblBlockedQRCard";
            this.lblBlockedQRCard.Size = new System.Drawing.Size(31, 33);
            this.lblBlockedQRCard.TabIndex = 19;
            this.lblBlockedQRCard.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "პირადი ნომერი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "სახელი";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "გვარი";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "მამის სახელი";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "ქვეყანა";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "ტელეფონი";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(44, 627);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 20);
            this.label35.TabIndex = 138;
            this.label35.Text = "პოზიცია";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DashDotDot;
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(505, 323);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 388);
            this.bunifuSeparator1.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 148;
            this.label5.Text = "QR ბარათის ID";
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(561, 371);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(600, 340);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCode.TabIndex = 150;
            this.pbQRCode.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.pbQRCode;
            // 
            // btnReadQR
            // 
            this.btnReadQR.AllowAnimations = true;
            this.btnReadQR.AllowMouseEffects = true;
            this.btnReadQR.AllowToggling = false;
            this.btnReadQR.AnimationSpeed = 200;
            this.btnReadQR.AutoGenerateColors = false;
            this.btnReadQR.AutoRoundBorders = false;
            this.btnReadQR.AutoSizeLeftIcon = true;
            this.btnReadQR.AutoSizeRightIcon = true;
            this.btnReadQR.BackColor = System.Drawing.Color.Transparent;
            this.btnReadQR.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReadQR.BackgroundImage")));
            this.btnReadQR.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadQR.ButtonText = "წაკითხვა";
            this.btnReadQR.ButtonTextMarginLeft = 0;
            this.btnReadQR.ColorContrastOnClick = 45;
            this.btnReadQR.ColorContrastOnHover = 45;
            this.btnReadQR.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnReadQR.CustomizableEdges = borderEdges8;
            this.btnReadQR.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReadQR.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReadQR.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReadQR.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReadQR.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReadQR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadQR.ForeColor = System.Drawing.Color.White;
            this.btnReadQR.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadQR.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReadQR.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReadQR.IconMarginLeft = 11;
            this.btnReadQR.IconPadding = 10;
            this.btnReadQR.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadQR.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReadQR.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReadQR.IconSize = 25;
            this.btnReadQR.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.IdleBorderRadius = 1;
            this.btnReadQR.IdleBorderThickness = 1;
            this.btnReadQR.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.IdleIconLeftImage = null;
            this.btnReadQR.IdleIconRightImage = null;
            this.btnReadQR.IndicateFocus = false;
            this.btnReadQR.Location = new System.Drawing.Point(48, 679);
            this.btnReadQR.Name = "btnReadQR";
            this.btnReadQR.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReadQR.OnDisabledState.BorderRadius = 1;
            this.btnReadQR.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadQR.OnDisabledState.BorderThickness = 1;
            this.btnReadQR.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReadQR.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReadQR.OnDisabledState.IconLeftImage = null;
            this.btnReadQR.OnDisabledState.IconRightImage = null;
            this.btnReadQR.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReadQR.onHoverState.BorderRadius = 1;
            this.btnReadQR.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadQR.onHoverState.BorderThickness = 1;
            this.btnReadQR.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReadQR.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReadQR.onHoverState.IconLeftImage = null;
            this.btnReadQR.onHoverState.IconRightImage = null;
            this.btnReadQR.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.OnIdleState.BorderRadius = 1;
            this.btnReadQR.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadQR.OnIdleState.BorderThickness = 1;
            this.btnReadQR.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReadQR.OnIdleState.IconLeftImage = null;
            this.btnReadQR.OnIdleState.IconRightImage = null;
            this.btnReadQR.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.OnPressedState.BorderRadius = 1;
            this.btnReadQR.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadQR.OnPressedState.BorderThickness = 1;
            this.btnReadQR.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadQR.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReadQR.OnPressedState.IconLeftImage = null;
            this.btnReadQR.OnPressedState.IconRightImage = null;
            this.btnReadQR.Size = new System.Drawing.Size(160, 30);
            this.btnReadQR.TabIndex = 151;
            this.btnReadQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReadQR.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReadQR.TextMarginLeft = 0;
            this.btnReadQR.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReadQR.UseDefaultRadiusAndThickness = true;
            this.btnReadQR.Click += new System.EventHandler(this.btnReadQR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(565, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 152;
            this.label6.Text = "კამერა";
            // 
            // cboCamera
            // 
            this.cboCamera.BackColor = System.Drawing.Color.Transparent;
            this.cboCamera.BackgroundColor = System.Drawing.Color.White;
            this.cboCamera.BorderColor = System.Drawing.Color.Silver;
            this.cboCamera.BorderRadius = 1;
            this.cboCamera.Color = System.Drawing.Color.Silver;
            this.cboCamera.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboCamera.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCamera.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboCamera.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCamera.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboCamera.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCamera.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboCamera.FillDropDown = true;
            this.cboCamera.FillIndicator = false;
            this.cboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCamera.ForeColor = System.Drawing.Color.Black;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Icon = null;
            this.cboCamera.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboCamera.IndicatorColor = System.Drawing.Color.Gray;
            this.cboCamera.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboCamera.ItemBackColor = System.Drawing.Color.White;
            this.cboCamera.ItemBorderColor = System.Drawing.Color.White;
            this.cboCamera.ItemForeColor = System.Drawing.Color.Black;
            this.cboCamera.ItemHeight = 26;
            this.cboCamera.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cboCamera.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboCamera.ItemTopMargin = 3;
            this.cboCamera.Location = new System.Drawing.Point(636, 328);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(461, 32);
            this.cboCamera.TabIndex = 153;
            this.cboCamera.Text = null;
            this.cboCamera.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboCamera.TextLeftMargin = 5;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.btnReadQR;
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "გაუქმება";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges9;
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
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.IdleBorderRadius = 1;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(214, 679);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 1;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.BorderRadius = 1;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnIdleState.BorderRadius = 1;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.BorderRadius = 1;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(160, 30);
            this.btnCancel.TabIndex = 156;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.btnCancel;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnReload.CustomizableEdges = borderEdges10;
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
            this.btnReload.IdleBorderRadius = 1;
            this.btnReload.IdleBorderThickness = 1;
            this.btnReload.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.IdleIconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload.IdleIconRightImage = null;
            this.btnReload.IndicateFocus = false;
            this.btnReload.Location = new System.Drawing.Point(1103, 328);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.OnDisabledState.BorderRadius = 1;
            this.btnReload.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnDisabledState.BorderThickness = 1;
            this.btnReload.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload.OnDisabledState.IconLeftImage = null;
            this.btnReload.OnDisabledState.IconRightImage = null;
            this.btnReload.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload.onHoverState.BorderRadius = 1;
            this.btnReload.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.onHoverState.BorderThickness = 1;
            this.btnReload.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload.onHoverState.IconLeftImage = null;
            this.btnReload.onHoverState.IconRightImage = null;
            this.btnReload.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnIdleState.BorderRadius = 1;
            this.btnReload.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnIdleState.BorderThickness = 1;
            this.btnReload.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnIdleState.IconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload.OnIdleState.IconRightImage = null;
            this.btnReload.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnPressedState.BorderRadius = 1;
            this.btnReload.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnPressedState.BorderThickness = 1;
            this.btnReload.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnPressedState.IconLeftImage = null;
            this.btnReload.OnPressedState.IconRightImage = null;
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 160;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.TextMarginLeft = 0;
            this.btnReload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload.UseDefaultRadiusAndThickness = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtQRCardID
            // 
            this.txtQRCardID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtQRCardID.BorderColor = System.Drawing.Color.White;
            this.txtQRCardID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtQRCardID.BorderRadius = 0;
            this.txtQRCardID.BorderSize = 2;
            this.txtQRCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRCardID.ForeColor = System.Drawing.Color.White;
            this.txtQRCardID.Location = new System.Drawing.Point(205, 323);
            this.txtQRCardID.Multiline = false;
            this.txtQRCardID.Name = "txtQRCardID";
            this.txtQRCardID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQRCardID.PasswordChar = false;
            this.txtQRCardID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQRCardID.PlaceholderText = "";
            this.txtQRCardID.Size = new System.Drawing.Size(250, 35);
            this.txtQRCardID.TabIndex = 149;
            this.txtQRCardID.UnderlinedStyle = true;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtPosition.BorderColor = System.Drawing.Color.White;
            this.txtPosition.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtPosition.BorderRadius = 0;
            this.txtPosition.BorderSize = 2;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.Color.White;
            this.txtPosition.Location = new System.Drawing.Point(205, 612);
            this.txtPosition.Multiline = false;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPosition.PasswordChar = false;
            this.txtPosition.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPosition.PlaceholderText = "";
            this.txtPosition.Size = new System.Drawing.Size(250, 35);
            this.txtPosition.TabIndex = 146;
            this.txtPosition.UnderlinedStyle = true;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtTelephone.BorderColor = System.Drawing.Color.White;
            this.txtTelephone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtTelephone.BorderRadius = 0;
            this.txtTelephone.BorderSize = 2;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.Color.White;
            this.txtTelephone.Location = new System.Drawing.Point(205, 569);
            this.txtTelephone.Multiline = false;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelephone.PasswordChar = false;
            this.txtTelephone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.Size = new System.Drawing.Size(250, 35);
            this.txtTelephone.TabIndex = 144;
            this.txtTelephone.UnderlinedStyle = true;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtCountry.BorderColor = System.Drawing.Color.White;
            this.txtCountry.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtCountry.BorderRadius = 0;
            this.txtCountry.BorderSize = 2;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.Location = new System.Drawing.Point(205, 528);
            this.txtCountry.Multiline = false;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCountry.PasswordChar = false;
            this.txtCountry.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCountry.PlaceholderText = "";
            this.txtCountry.Size = new System.Drawing.Size(250, 35);
            this.txtCountry.TabIndex = 143;
            this.txtCountry.UnderlinedStyle = true;
            // 
            // txtFathersName
            // 
            this.txtFathersName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtFathersName.BorderColor = System.Drawing.Color.White;
            this.txtFathersName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtFathersName.BorderRadius = 0;
            this.txtFathersName.BorderSize = 2;
            this.txtFathersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFathersName.ForeColor = System.Drawing.Color.White;
            this.txtFathersName.Location = new System.Drawing.Point(205, 487);
            this.txtFathersName.Multiline = false;
            this.txtFathersName.Name = "txtFathersName";
            this.txtFathersName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFathersName.PasswordChar = false;
            this.txtFathersName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFathersName.PlaceholderText = "";
            this.txtFathersName.Size = new System.Drawing.Size(250, 35);
            this.txtFathersName.TabIndex = 142;
            this.txtFathersName.UnderlinedStyle = true;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtSurname.BorderColor = System.Drawing.Color.White;
            this.txtSurname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtSurname.BorderRadius = 0;
            this.txtSurname.BorderSize = 2;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(205, 446);
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSurname.PasswordChar = false;
            this.txtSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSurname.PlaceholderText = "";
            this.txtSurname.Size = new System.Drawing.Size(250, 35);
            this.txtSurname.TabIndex = 141;
            this.txtSurname.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(205, 405);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(250, 35);
            this.txtName.TabIndex = 140;
            this.txtName.UnderlinedStyle = true;
            // 
            // txtPassportID
            // 
            this.txtPassportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.txtPassportID.BorderColor = System.Drawing.Color.White;
            this.txtPassportID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtPassportID.BorderRadius = 0;
            this.txtPassportID.BorderSize = 2;
            this.txtPassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportID.ForeColor = System.Drawing.Color.White;
            this.txtPassportID.Location = new System.Drawing.Point(205, 364);
            this.txtPassportID.Multiline = false;
            this.txtPassportID.Name = "txtPassportID";
            this.txtPassportID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassportID.PasswordChar = false;
            this.txtPassportID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassportID.PlaceholderText = "";
            this.txtPassportID.Size = new System.Drawing.Size(250, 35);
            this.txtPassportID.TabIndex = 139;
            this.txtPassportID.UnderlinedStyle = true;
            // 
            // EmployeesQRCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReadQR);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.txtQRCardID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtFathersName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassportID);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBlockedQRCard);
            this.Controls.Add(this.lblOverdueQRCard);
            this.Controls.Add(this.lblActiveQRCard);
            this.Controls.Add(this.lblQRCardCount);
            this.Controls.Add(this.btnQRCardRegistration);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeesQRCard";
            this.Size = new System.Drawing.Size(1195, 740);
            this.Load += new System.EventHandler(this.EmployeesQRCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnQRCardRegistration;
        private System.Windows.Forms.Label lblQRCardCount;
        private System.Windows.Forms.Label lblActiveQRCard;
        private System.Windows.Forms.Label lblOverdueQRCard;
        private System.Windows.Forms.Label lblBlockedQRCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label35;
        private Custom_Controls.CustomTextBoxRounded txtPassportID;
        private Custom_Controls.CustomTextBoxRounded txtName;
        private Custom_Controls.CustomTextBoxRounded txtSurname;
        private Custom_Controls.CustomTextBoxRounded txtFathersName;
        private Custom_Controls.CustomTextBoxRounded txtCountry;
        private Custom_Controls.CustomTextBoxRounded txtTelephone;
        private Custom_Controls.CustomTextBoxRounded txtPosition;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label5;
        private Custom_Controls.CustomTextBoxRounded txtQRCardID;
        private System.Windows.Forms.PictureBox pbQRCode;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReadQR;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown cboCamera;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
    }
}
