
namespace Employees_Management_System.Forms
{
    partial class AverageSalaryByAgeChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AverageSalaryByAgeChartForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuChartCanvas2 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuChartCanvas3 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuLineChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.bunifuPieChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.btnReload1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnReload2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnReload3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPolarAreaChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuPolarAreaChart(this.components);
            this.SuspendLayout();
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas1.Labels = null;
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.Black;
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(12, 12);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(1124, 567);
            this.bunifuChartCanvas1.TabIndex = 0;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // bunifuChartCanvas2
            // 
            this.bunifuChartCanvas2.AnimationDuration = 1000;
            this.bunifuChartCanvas2.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas2.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas2.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas2.Labels = new string[0];
            this.bunifuChartCanvas2.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas2.LegendDisplay = true;
            this.bunifuChartCanvas2.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas2.LegendForeColor = System.Drawing.Color.Black;
            this.bunifuChartCanvas2.LegendFullWidth = true;
            this.bunifuChartCanvas2.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.bunifuChartCanvas2.LegendRevese = false;
            this.bunifuChartCanvas2.LegendRTL = false;
            this.bunifuChartCanvas2.Location = new System.Drawing.Point(1142, 12);
            this.bunifuChartCanvas2.Name = "bunifuChartCanvas2";
            this.bunifuChartCanvas2.ShowXAxis = false;
            this.bunifuChartCanvas2.ShowYAxis = false;
            this.bunifuChartCanvas2.Size = new System.Drawing.Size(439, 270);
            this.bunifuChartCanvas2.TabIndex = 1;
            this.bunifuChartCanvas2.Title = "ჯამური ხელფასი წლების მიხედვით";
            this.bunifuChartCanvas2.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas2.TitlePadding = 8;
            this.bunifuChartCanvas2.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas2.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas2.TooltipsEnabled = true;
            this.bunifuChartCanvas2.XAxesBeginAtZero = true;
            this.bunifuChartCanvas2.XAxesDrawTicks = true;
            this.bunifuChartCanvas2.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.XAxesGridLines = false;
            this.bunifuChartCanvas2.XAxesLabel = "";
            this.bunifuChartCanvas2.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.XAxesLineWidth = 1;
            this.bunifuChartCanvas2.XAxesStacked = false;
            this.bunifuChartCanvas2.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas2.YAxesBeginAtZero = true;
            this.bunifuChartCanvas2.YAxesDrawTicks = true;
            this.bunifuChartCanvas2.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.YAxesGridLines = false;
            this.bunifuChartCanvas2.YAxesLabel = "";
            this.bunifuChartCanvas2.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.YAxesLineWidth = 1;
            this.bunifuChartCanvas2.YAxesStacked = false;
            this.bunifuChartCanvas2.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.YAxesZeroLineWidth = 1;
            // 
            // bunifuChartCanvas3
            // 
            this.bunifuChartCanvas3.AnimationDuration = 1000;
            this.bunifuChartCanvas3.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas3.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas3.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas3.Labels = null;
            this.bunifuChartCanvas3.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas3.LegendDisplay = true;
            this.bunifuChartCanvas3.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas3.LegendForeColor = System.Drawing.Color.Black;
            this.bunifuChartCanvas3.LegendFullWidth = true;
            this.bunifuChartCanvas3.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
            this.bunifuChartCanvas3.LegendRevese = false;
            this.bunifuChartCanvas3.LegendRTL = false;
            this.bunifuChartCanvas3.Location = new System.Drawing.Point(1142, 309);
            this.bunifuChartCanvas3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuChartCanvas3.Name = "bunifuChartCanvas3";
            this.bunifuChartCanvas3.ShowXAxis = false;
            this.bunifuChartCanvas3.ShowYAxis = false;
            this.bunifuChartCanvas3.Size = new System.Drawing.Size(439, 270);
            this.bunifuChartCanvas3.TabIndex = 2;
            this.bunifuChartCanvas3.Title = "ჯამური პრემია წლების მიხედვით";
            this.bunifuChartCanvas3.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas3.TitlePadding = 10;
            this.bunifuChartCanvas3.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas3.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas3.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas3.TooltipsEnabled = true;
            this.bunifuChartCanvas3.XAxesBeginAtZero = true;
            this.bunifuChartCanvas3.XAxesDrawTicks = true;
            this.bunifuChartCanvas3.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.XAxesGridLines = false;
            this.bunifuChartCanvas3.XAxesLabel = "";
            this.bunifuChartCanvas3.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.XAxesLineWidth = 1;
            this.bunifuChartCanvas3.XAxesStacked = false;
            this.bunifuChartCanvas3.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas3.YAxesBeginAtZero = true;
            this.bunifuChartCanvas3.YAxesDrawTicks = true;
            this.bunifuChartCanvas3.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.YAxesGridLines = false;
            this.bunifuChartCanvas3.YAxesLabel = "";
            this.bunifuChartCanvas3.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.YAxesLineWidth = 1;
            this.bunifuChartCanvas3.YAxesStacked = false;
            this.bunifuChartCanvas3.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.YAxesZeroLineWidth = 1;
            // 
            // bunifuLineChart1
            // 
            this.bunifuLineChart1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuLineChart1.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.bunifuLineChart1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.bunifuLineChart1.BorderDash = null;
            this.bunifuLineChart1.BorderDashOffset = 0D;
            this.bunifuLineChart1.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.bunifuLineChart1.BorderWidth = 3;
            this.bunifuLineChart1.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.bunifuLineChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuLineChart1.Data")));
            this.bunifuLineChart1.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.bunifuLineChart1.Label = "საშუალო ხელფასი ასაკის მიხედვით";
            this.bunifuLineChart1.LineTension = 0.4D;
            this.bunifuLineChart1.Order = 0;
            this.bunifuLineChart1.PointBackgroundColor = System.Drawing.Color.White;
            this.bunifuLineChart1.PointBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.bunifuLineChart1.PointBorderWidth = 2;
            this.bunifuLineChart1.PointHitRadius = 5;
            this.bunifuLineChart1.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderWidth = 4;
            this.bunifuLineChart1.PointHoverRadius = 7;
            this.bunifuLineChart1.PointRadius = 5;
            this.bunifuLineChart1.PointRotation = 0;
            this.bunifuLineChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.bunifuLineChart1.ShowLine = true;
            this.bunifuLineChart1.SpanGaps = false;
            this.bunifuLineChart1.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.bunifuLineChart1.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuPieChart1
            // 
            this.bunifuPieChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPieChart1.BackgroundColor")));
            this.bunifuPieChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPieChart1.BorderColor")));
            this.bunifuPieChart1.BorderWidth = 0;
            this.bunifuPieChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuPieChart1.Data")));
            this.bunifuPieChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuPieChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuPieChart1.HoverBorderWidth = 0;
            this.bunifuPieChart1.Label = "ხელფასის ჯამი წელიწადის მიხენდით";
            this.bunifuPieChart1.TargetCanvas = this.bunifuChartCanvas2;
            // 
            // btnReload1
            // 
            this.btnReload1.AllowAnimations = true;
            this.btnReload1.AllowMouseEffects = true;
            this.btnReload1.AllowToggling = false;
            this.btnReload1.AnimationSpeed = 50;
            this.btnReload1.AutoGenerateColors = false;
            this.btnReload1.AutoRoundBorders = false;
            this.btnReload1.AutoSizeLeftIcon = true;
            this.btnReload1.AutoSizeRightIcon = true;
            this.btnReload1.BackColor = System.Drawing.Color.Transparent;
            this.btnReload1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload1.BackgroundImage")));
            this.btnReload1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload1.ButtonText = "";
            this.btnReload1.ButtonTextMarginLeft = 0;
            this.btnReload1.ColorContrastOnClick = 45;
            this.btnReload1.ColorContrastOnHover = 45;
            this.btnReload1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.btnReload1.CustomizableEdges = borderEdges16;
            this.btnReload1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReload1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload1.ForeColor = System.Drawing.Color.White;
            this.btnReload1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload1.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnReload1.IconMarginLeft = 11;
            this.btnReload1.IconPadding = 5;
            this.btnReload1.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload1.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnReload1.IconSize = 25;
            this.btnReload1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.IdleBorderRadius = 10;
            this.btnReload1.IdleBorderThickness = 1;
            this.btnReload1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.IdleIconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload1.IdleIconRightImage = null;
            this.btnReload1.IndicateFocus = false;
            this.btnReload1.Location = new System.Drawing.Point(1096, 17);
            this.btnReload1.Name = "btnReload1";
            this.btnReload1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload1.OnDisabledState.BorderRadius = 10;
            this.btnReload1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload1.OnDisabledState.BorderThickness = 1;
            this.btnReload1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload1.OnDisabledState.IconLeftImage = null;
            this.btnReload1.OnDisabledState.IconRightImage = null;
            this.btnReload1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload1.onHoverState.BorderRadius = 10;
            this.btnReload1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload1.onHoverState.BorderThickness = 1;
            this.btnReload1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload1.onHoverState.IconLeftImage = null;
            this.btnReload1.onHoverState.IconRightImage = null;
            this.btnReload1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.OnIdleState.BorderRadius = 10;
            this.btnReload1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload1.OnIdleState.BorderThickness = 1;
            this.btnReload1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload1.OnIdleState.IconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload1.OnIdleState.IconRightImage = null;
            this.btnReload1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.OnPressedState.BorderRadius = 10;
            this.btnReload1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload1.OnPressedState.BorderThickness = 1;
            this.btnReload1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload1.OnPressedState.IconLeftImage = null;
            this.btnReload1.OnPressedState.IconRightImage = null;
            this.btnReload1.Size = new System.Drawing.Size(35, 35);
            this.btnReload1.TabIndex = 160;
            this.btnReload1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload1.TextMarginLeft = 0;
            this.btnReload1.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload1.UseDefaultRadiusAndThickness = true;
            this.btnReload1.Click += new System.EventHandler(this.btnReload1_Click);
            // 
            // btnReload2
            // 
            this.btnReload2.AllowAnimations = true;
            this.btnReload2.AllowMouseEffects = true;
            this.btnReload2.AllowToggling = false;
            this.btnReload2.AnimationSpeed = 50;
            this.btnReload2.AutoGenerateColors = false;
            this.btnReload2.AutoRoundBorders = false;
            this.btnReload2.AutoSizeLeftIcon = true;
            this.btnReload2.AutoSizeRightIcon = true;
            this.btnReload2.BackColor = System.Drawing.Color.Transparent;
            this.btnReload2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload2.BackgroundImage")));
            this.btnReload2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload2.ButtonText = "";
            this.btnReload2.ButtonTextMarginLeft = 0;
            this.btnReload2.ColorContrastOnClick = 45;
            this.btnReload2.ColorContrastOnHover = 45;
            this.btnReload2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges17.BottomLeft = true;
            borderEdges17.BottomRight = true;
            borderEdges17.TopLeft = true;
            borderEdges17.TopRight = true;
            this.btnReload2.CustomizableEdges = borderEdges17;
            this.btnReload2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReload2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload2.ForeColor = System.Drawing.Color.White;
            this.btnReload2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload2.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnReload2.IconMarginLeft = 11;
            this.btnReload2.IconPadding = 5;
            this.btnReload2.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload2.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnReload2.IconSize = 25;
            this.btnReload2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.IdleBorderRadius = 10;
            this.btnReload2.IdleBorderThickness = 1;
            this.btnReload2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.IdleIconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload2.IdleIconRightImage = null;
            this.btnReload2.IndicateFocus = false;
            this.btnReload2.Location = new System.Drawing.Point(1541, 17);
            this.btnReload2.Name = "btnReload2";
            this.btnReload2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload2.OnDisabledState.BorderRadius = 10;
            this.btnReload2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload2.OnDisabledState.BorderThickness = 1;
            this.btnReload2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload2.OnDisabledState.IconLeftImage = null;
            this.btnReload2.OnDisabledState.IconRightImage = null;
            this.btnReload2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload2.onHoverState.BorderRadius = 10;
            this.btnReload2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload2.onHoverState.BorderThickness = 1;
            this.btnReload2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload2.onHoverState.IconLeftImage = null;
            this.btnReload2.onHoverState.IconRightImage = null;
            this.btnReload2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.OnIdleState.BorderRadius = 10;
            this.btnReload2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload2.OnIdleState.BorderThickness = 1;
            this.btnReload2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload2.OnIdleState.IconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload2.OnIdleState.IconRightImage = null;
            this.btnReload2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.OnPressedState.BorderRadius = 10;
            this.btnReload2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload2.OnPressedState.BorderThickness = 1;
            this.btnReload2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload2.OnPressedState.IconLeftImage = null;
            this.btnReload2.OnPressedState.IconRightImage = null;
            this.btnReload2.Size = new System.Drawing.Size(35, 35);
            this.btnReload2.TabIndex = 161;
            this.btnReload2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload2.TextMarginLeft = 0;
            this.btnReload2.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload2.UseDefaultRadiusAndThickness = true;
            this.btnReload2.Click += new System.EventHandler(this.btnReload2_Click);
            // 
            // btnReload3
            // 
            this.btnReload3.AllowAnimations = true;
            this.btnReload3.AllowMouseEffects = true;
            this.btnReload3.AllowToggling = false;
            this.btnReload3.AnimationSpeed = 50;
            this.btnReload3.AutoGenerateColors = false;
            this.btnReload3.AutoRoundBorders = false;
            this.btnReload3.AutoSizeLeftIcon = true;
            this.btnReload3.AutoSizeRightIcon = true;
            this.btnReload3.BackColor = System.Drawing.Color.Transparent;
            this.btnReload3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload3.BackgroundImage")));
            this.btnReload3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload3.ButtonText = "";
            this.btnReload3.ButtonTextMarginLeft = 0;
            this.btnReload3.ColorContrastOnClick = 45;
            this.btnReload3.ColorContrastOnHover = 45;
            this.btnReload3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.btnReload3.CustomizableEdges = borderEdges18;
            this.btnReload3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReload3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload3.ForeColor = System.Drawing.Color.White;
            this.btnReload3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload3.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.btnReload3.IconMarginLeft = 11;
            this.btnReload3.IconPadding = 5;
            this.btnReload3.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload3.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnReload3.IconSize = 25;
            this.btnReload3.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.IdleBorderRadius = 10;
            this.btnReload3.IdleBorderThickness = 1;
            this.btnReload3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.IdleIconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload3.IdleIconRightImage = null;
            this.btnReload3.IndicateFocus = false;
            this.btnReload3.Location = new System.Drawing.Point(1541, 314);
            this.btnReload3.Name = "btnReload3";
            this.btnReload3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload3.OnDisabledState.BorderRadius = 10;
            this.btnReload3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload3.OnDisabledState.BorderThickness = 1;
            this.btnReload3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload3.OnDisabledState.IconLeftImage = null;
            this.btnReload3.OnDisabledState.IconRightImage = null;
            this.btnReload3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload3.onHoverState.BorderRadius = 10;
            this.btnReload3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload3.onHoverState.BorderThickness = 1;
            this.btnReload3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReload3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload3.onHoverState.IconLeftImage = null;
            this.btnReload3.onHoverState.IconRightImage = null;
            this.btnReload3.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.OnIdleState.BorderRadius = 10;
            this.btnReload3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload3.OnIdleState.BorderThickness = 1;
            this.btnReload3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload3.OnIdleState.IconLeftImage = global::Employees_Management_System.Properties.Resources.synchronize_24px;
            this.btnReload3.OnIdleState.IconRightImage = null;
            this.btnReload3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.OnPressedState.BorderRadius = 10;
            this.btnReload3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload3.OnPressedState.BorderThickness = 1;
            this.btnReload3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.btnReload3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload3.OnPressedState.IconLeftImage = null;
            this.btnReload3.OnPressedState.IconRightImage = null;
            this.btnReload3.Size = new System.Drawing.Size(35, 35);
            this.btnReload3.TabIndex = 162;
            this.btnReload3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload3.TextMarginLeft = 0;
            this.btnReload3.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload3.UseDefaultRadiusAndThickness = true;
            this.btnReload3.Click += new System.EventHandler(this.btnReload3_Click);
            // 
            // bunifuPolarAreaChart1
            // 
            this.bunifuPolarAreaChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPolarAreaChart1.BackgroundColor")));
            this.bunifuPolarAreaChart1.BorderAlign = Bunifu.Charts.WinForms.ChartTypes.BunifuPolarAreaChart.BorderAlignmentOptions.Centre;
            this.bunifuPolarAreaChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPolarAreaChart1.BorderColor")));
            this.bunifuPolarAreaChart1.BorderWidth = 0;
            this.bunifuPolarAreaChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuPolarAreaChart1.Data")));
            this.bunifuPolarAreaChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuPolarAreaChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuPolarAreaChart1.HoverBorderWidth = 0;
            this.bunifuPolarAreaChart1.Label = "Label here";
            this.bunifuPolarAreaChart1.TargetCanvas = this.bunifuChartCanvas3;
            // 
            // AverageSalaryByAgeChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 591);
            this.Controls.Add(this.btnReload3);
            this.Controls.Add(this.btnReload2);
            this.Controls.Add(this.btnReload1);
            this.Controls.Add(this.bunifuChartCanvas3);
            this.Controls.Add(this.bunifuChartCanvas2);
            this.Controls.Add(this.bunifuChartCanvas1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AverageSalaryByAgeChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "თანამშრომლის ხელფასის და პრემიის სტატისტიკა";
            this.Load += new System.EventHandler(this.AverageSalaryByAgeChartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas2;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas3;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart bunifuLineChart1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart bunifuPieChart1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload3;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPolarAreaChart bunifuPolarAreaChart1;
    }
}