namespace THEME
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Side = new System.Windows.Forms.Panel();
            this.UserReport = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.UserDetails = new System.Windows.Forms.PictureBox();
            this.AddUser = new System.Windows.Forms.PictureBox();
            this.Panel_Short = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_Base = new System.Windows.Forms.Panel();
            this.Panel_Controles = new System.Windows.Forms.Panel();
            this.Panel_Form = new System.Windows.Forms.Panel();
            this.Panel_Slide = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.btn_report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_userdetail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btn_adduser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.UC_UserReporting = new THEME.UserControles.UC_UserReporting();
            this.UC_UserDetails = new THEME.UserControles.UC_UserDetails();
            this.UC_AddUser = new THEME.UserControles.UC_AddUser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel_Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUser)).BeginInit();
            this.Panel_Base.SuspendLayout();
            this.Panel_Controles.SuspendLayout();
            this.Panel_Form.SuspendLayout();
            this.Panel_Slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(748, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 35);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "TELEPHONE CONNECTION SYSTEM";
            // 
            // Panel_Side
            // 
            this.Panel_Side.Controls.Add(this.Panel_Short);
            this.Panel_Side.Controls.Add(this.UserReport);
            this.Panel_Side.Controls.Add(this.btn_menu);
            this.Panel_Side.Controls.Add(this.UserDetails);
            this.Panel_Side.Controls.Add(this.AddUser);
            this.bunifuTransition1.SetDecoration(this.Panel_Side, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Side.Location = new System.Drawing.Point(0, 35);
            this.Panel_Side.Name = "Panel_Side";
            this.Panel_Side.Size = new System.Drawing.Size(50, 526);
            this.Panel_Side.TabIndex = 11;
            // 
            // UserReport
            // 
            this.bunifuTransition1.SetDecoration(this.UserReport, BunifuAnimatorNS.DecorationType.None);
            this.UserReport.Image = ((System.Drawing.Image)(resources.GetObject("UserReport.Image")));
            this.UserReport.Location = new System.Drawing.Point(11, 243);
            this.UserReport.Name = "UserReport";
            this.UserReport.Size = new System.Drawing.Size(33, 31);
            this.UserReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserReport.TabIndex = 5;
            this.UserReport.TabStop = false;
            this.UserReport.Click += new System.EventHandler(this.UserReport_Click);
            // 
            // btn_menu
            // 
            this.bunifuTransition1.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(5, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(41, 37);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // UserDetails
            // 
            this.UserDetails.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.UserDetails, BunifuAnimatorNS.DecorationType.None);
            this.UserDetails.Image = ((System.Drawing.Image)(resources.GetObject("UserDetails.Image")));
            this.UserDetails.Location = new System.Drawing.Point(11, 170);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(33, 31);
            this.UserDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserDetails.TabIndex = 3;
            this.UserDetails.TabStop = false;
            this.UserDetails.Click += new System.EventHandler(this.UserDetails_Click);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.AddUser, BunifuAnimatorNS.DecorationType.None);
            this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
            this.AddUser.Location = new System.Drawing.Point(11, 100);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(33, 31);
            this.AddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddUser.TabIndex = 3;
            this.AddUser.TabStop = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Panel_Short
            // 
            this.bunifuTransition1.SetDecoration(this.Panel_Short, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Short.Location = new System.Drawing.Point(0, 80);
            this.Panel_Short.Name = "Panel_Short";
            this.Panel_Short.Size = new System.Drawing.Size(50, 210);
            this.Panel_Short.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_Base
            // 
            this.Panel_Base.Controls.Add(this.Panel_Controles);
            this.bunifuTransition1.SetDecoration(this.Panel_Base, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Base.Location = new System.Drawing.Point(50, 35);
            this.Panel_Base.Name = "Panel_Base";
            this.Panel_Base.Size = new System.Drawing.Size(734, 526);
            this.Panel_Base.TabIndex = 12;
            // 
            // Panel_Controles
            // 
            this.Panel_Controles.Controls.Add(this.Panel_Form);
            this.Panel_Controles.Controls.Add(this.Panel_Slide);
            this.bunifuTransition1.SetDecoration(this.Panel_Controles, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Controles.Location = new System.Drawing.Point(0, 0);
            this.Panel_Controles.Name = "Panel_Controles";
            this.Panel_Controles.Size = new System.Drawing.Size(734, 526);
            this.Panel_Controles.TabIndex = 3;
            // 
            // Panel_Form
            // 
            this.Panel_Form.Controls.Add(this.UC_UserReporting);
            this.Panel_Form.Controls.Add(this.UC_UserDetails);
            this.Panel_Form.Controls.Add(this.UC_AddUser);
            this.bunifuTransition1.SetDecoration(this.Panel_Form, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Form.Location = new System.Drawing.Point(235, 0);
            this.Panel_Form.Name = "Panel_Form";
            this.Panel_Form.Size = new System.Drawing.Size(499, 526);
            this.Panel_Form.TabIndex = 5;
            // 
            // Panel_Slide
            // 
            this.Panel_Slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Panel_Slide.Controls.Add(this.pictureBox2);
            this.Panel_Slide.Controls.Add(this.pictureBox12);
            this.Panel_Slide.Controls.Add(this.MovePanel);
            this.Panel_Slide.Controls.Add(this.btn_report);
            this.Panel_Slide.Controls.Add(this.btn_userdetail);
            this.Panel_Slide.Controls.Add(this.pictureBox9);
            this.Panel_Slide.Controls.Add(this.btn_adduser);
            this.bunifuTransition1.SetDecoration(this.Panel_Slide, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Slide.Location = new System.Drawing.Point(0, 0);
            this.Panel_Slide.Name = "Panel_Slide";
            this.Panel_Slide.Size = new System.Drawing.Size(235, 526);
            this.Panel_Slide.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox12, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(30, 170);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 31);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.bunifuTransition1.SetDecoration(this.MovePanel, BunifuAnimatorNS.DecorationType.None);
            this.MovePanel.Location = new System.Drawing.Point(225, 81);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(10, 70);
            this.MovePanel.TabIndex = 4;
            // 
            // btn_report
            // 
            this.btn_report.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.BorderRadius = 0;
            this.btn_report.ButtonText = "User Report";
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_report, BunifuAnimatorNS.DecorationType.None);
            this.btn_report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_report.Iconimage = null;
            this.btn_report.Iconimage_right = null;
            this.btn_report.Iconimage_right_Selected = null;
            this.btn_report.Iconimage_Selected = null;
            this.btn_report.IconMarginLeft = 0;
            this.btn_report.IconMarginRight = 0;
            this.btn_report.IconRightVisible = true;
            this.btn_report.IconRightZoom = 0D;
            this.btn_report.IconVisible = true;
            this.btn_report.IconZoom = 90D;
            this.btn_report.IsTab = false;
            this.btn_report.Location = new System.Drawing.Point(0, 223);
            this.btn_report.Name = "btn_report";
            this.btn_report.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_report.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btn_report.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_report.selected = false;
            this.btn_report.Size = new System.Drawing.Size(236, 70);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "User Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_report.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_report.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click_1);
            // 
            // btn_userdetail
            // 
            this.btn_userdetail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_userdetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_userdetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userdetail.BorderRadius = 0;
            this.btn_userdetail.ButtonText = "User Details";
            this.btn_userdetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_userdetail, BunifuAnimatorNS.DecorationType.None);
            this.btn_userdetail.DisabledColor = System.Drawing.Color.Gray;
            this.btn_userdetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userdetail.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_userdetail.Iconimage = null;
            this.btn_userdetail.Iconimage_right = null;
            this.btn_userdetail.Iconimage_right_Selected = null;
            this.btn_userdetail.Iconimage_Selected = null;
            this.btn_userdetail.IconMarginLeft = 0;
            this.btn_userdetail.IconMarginRight = 0;
            this.btn_userdetail.IconRightVisible = true;
            this.btn_userdetail.IconRightZoom = 0D;
            this.btn_userdetail.IconVisible = true;
            this.btn_userdetail.IconZoom = 90D;
            this.btn_userdetail.IsTab = false;
            this.btn_userdetail.Location = new System.Drawing.Point(0, 152);
            this.btn_userdetail.Name = "btn_userdetail";
            this.btn_userdetail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_userdetail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btn_userdetail.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_userdetail.selected = false;
            this.btn_userdetail.Size = new System.Drawing.Size(236, 70);
            this.btn_userdetail.TabIndex = 2;
            this.btn_userdetail.Text = "User Details";
            this.btn_userdetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_userdetail.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_userdetail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userdetail.Click += new System.EventHandler(this.btn_userdetail_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(30, 100);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(33, 31);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // btn_adduser
            // 
            this.btn_adduser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adduser.BorderRadius = 0;
            this.btn_adduser.ButtonText = "Add User";
            this.btn_adduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_adduser, BunifuAnimatorNS.DecorationType.None);
            this.btn_adduser.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adduser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduser.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adduser.Iconimage = null;
            this.btn_adduser.Iconimage_right = null;
            this.btn_adduser.Iconimage_right_Selected = null;
            this.btn_adduser.Iconimage_Selected = null;
            this.btn_adduser.IconMarginLeft = 0;
            this.btn_adduser.IconMarginRight = 0;
            this.btn_adduser.IconRightVisible = true;
            this.btn_adduser.IconRightZoom = 0D;
            this.btn_adduser.IconVisible = true;
            this.btn_adduser.IconZoom = 90D;
            this.btn_adduser.IsTab = false;
            this.btn_adduser.Location = new System.Drawing.Point(0, 81);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btn_adduser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btn_adduser.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_adduser.selected = false;
            this.btn_adduser.Size = new System.Drawing.Size(236, 70);
            this.btn_adduser.TabIndex = 1;
            this.btn_adduser.Text = "Add User";
            this.btn_adduser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adduser.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_adduser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click_1);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 1750;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // UC_UserReporting
            // 
            this.UC_UserReporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.bunifuTransition1.SetDecoration(this.UC_UserReporting, BunifuAnimatorNS.DecorationType.None);
            this.UC_UserReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_UserReporting.Location = new System.Drawing.Point(0, 0);
            this.UC_UserReporting.Name = "UC_UserReporting";
            this.UC_UserReporting.Size = new System.Drawing.Size(499, 526);
            this.UC_UserReporting.TabIndex = 2;
            this.UC_UserReporting.Visible = false;
            // 
            // UC_UserDetails
            // 
            this.UC_UserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.bunifuTransition1.SetDecoration(this.UC_UserDetails, BunifuAnimatorNS.DecorationType.None);
            this.UC_UserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_UserDetails.Location = new System.Drawing.Point(0, 0);
            this.UC_UserDetails.Name = "UC_UserDetails";
            this.UC_UserDetails.Size = new System.Drawing.Size(499, 526);
            this.UC_UserDetails.TabIndex = 1;
            this.UC_UserDetails.Visible = false;
            // 
            // UC_AddUser
            // 
            this.UC_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.bunifuTransition1.SetDecoration(this.UC_AddUser, BunifuAnimatorNS.DecorationType.None);
            this.UC_AddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_AddUser.Location = new System.Drawing.Point(0, 0);
            this.UC_AddUser.Name = "UC_AddUser";
            this.UC_AddUser.Size = new System.Drawing.Size(499, 526);
            this.UC_AddUser.TabIndex = 0;
            this.UC_AddUser.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Panel_Base);
            this.Controls.Add(this.Panel_Side);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUser)).EndInit();
            this.Panel_Base.ResumeLayout(false);
            this.Panel_Controles.ResumeLayout(false);
            this.Panel_Form.ResumeLayout(false);
            this.Panel_Slide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Side;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel_Base;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Controles;
        private System.Windows.Forms.Panel Panel_Slide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel MovePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_report;
        private Bunifu.Framework.UI.BunifuFlatButton btn_userdetail;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adduser;
        private System.Windows.Forms.Panel Panel_Form;
        private System.Windows.Forms.Panel Panel_Short;
        private System.Windows.Forms.PictureBox UserReport;
        private System.Windows.Forms.PictureBox UserDetails;
        private System.Windows.Forms.PictureBox AddUser;
        private System.Windows.Forms.Timer timer2;
        private UserControles.UC_UserReporting UC_UserReporting;
        private UserControles.UC_UserDetails UC_UserDetails;
        private UserControles.UC_AddUser UC_AddUser;




    }
}

