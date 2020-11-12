namespace THEME.UserControles
{
    partial class UC_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddUser));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Panel_AddUser = new System.Windows.Forms.Panel();
            this.txt_mdcon_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_typcon_user = new System.Windows.Forms.ComboBox();
            this.txt_ciyt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_address_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tphone_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_uname_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_AddUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.telephoneDataSet = new THEME.TelephoneDataSet();
            this.infoationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoationTableAdapter = new THEME.TelephoneDataSetTableAdapters.infoationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(219, 583);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(220, 15);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "@copyright 2019 Telephone Connection";
            // 
            // Panel_AddUser
            // 
            this.Panel_AddUser.Controls.Add(this.label1);
            this.Panel_AddUser.Controls.Add(this.comboBox1);
            this.Panel_AddUser.Controls.Add(this.txt_mdcon_user);
            this.Panel_AddUser.Controls.Add(this.label2);
            this.Panel_AddUser.Controls.Add(this.cmbox_typcon_user);
            this.Panel_AddUser.Controls.Add(this.txt_ciyt_user);
            this.Panel_AddUser.Controls.Add(this.txt_address_user);
            this.Panel_AddUser.Controls.Add(this.txt_tphone_user);
            this.Panel_AddUser.Controls.Add(this.txt_uname_user);
            this.Panel_AddUser.Controls.Add(this.btn_AddUser);
            this.Panel_AddUser.Controls.Add(this.label4);
            this.Panel_AddUser.Location = new System.Drawing.Point(44, 25);
            this.Panel_AddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_AddUser.Name = "Panel_AddUser";
            this.Panel_AddUser.Size = new System.Drawing.Size(555, 517);
            this.Panel_AddUser.TabIndex = 36;
            // 
            // txt_mdcon_user
            // 
            this.txt_mdcon_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mdcon_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_mdcon_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_mdcon_user.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_mdcon_user.HintText = "Mode Of Connection";
            this.txt_mdcon_user.isPassword = false;
            this.txt_mdcon_user.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mdcon_user.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mdcon_user.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mdcon_user.LineThickness = 3;
            this.txt_mdcon_user.Location = new System.Drawing.Point(107, 306);
            this.txt_mdcon_user.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_mdcon_user.Name = "txt_mdcon_user";
            this.txt_mdcon_user.Size = new System.Drawing.Size(345, 41);
            this.txt_mdcon_user.TabIndex = 43;
            this.txt_mdcon_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(103, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Type Of Connection";
            // 
            // cmbox_typcon_user
            // 
            this.cmbox_typcon_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.cmbox_typcon_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.cmbox_typcon_user.FormattingEnabled = true;
            this.cmbox_typcon_user.Items.AddRange(new object[] {
            "Prepaid",
            "Postpaid"});
            this.cmbox_typcon_user.Location = new System.Drawing.Point(291, 363);
            this.cmbox_typcon_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbox_typcon_user.Name = "cmbox_typcon_user";
            this.cmbox_typcon_user.Size = new System.Drawing.Size(160, 24);
            this.cmbox_typcon_user.TabIndex = 41;
            // 
            // txt_ciyt_user
            // 
            this.txt_ciyt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ciyt_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ciyt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_ciyt_user.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_ciyt_user.HintText = "City";
            this.txt_ciyt_user.isPassword = false;
            this.txt_ciyt_user.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ciyt_user.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ciyt_user.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ciyt_user.LineThickness = 3;
            this.txt_ciyt_user.Location = new System.Drawing.Point(107, 256);
            this.txt_ciyt_user.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_ciyt_user.Name = "txt_ciyt_user";
            this.txt_ciyt_user.Size = new System.Drawing.Size(345, 41);
            this.txt_ciyt_user.TabIndex = 40;
            this.txt_ciyt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_address_user
            // 
            this.txt_address_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_address_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_address_user.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_address_user.HintText = "Address";
            this.txt_address_user.isPassword = false;
            this.txt_address_user.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txt_address_user.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txt_address_user.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.txt_address_user.LineThickness = 3;
            this.txt_address_user.Location = new System.Drawing.Point(107, 206);
            this.txt_address_user.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_address_user.Name = "txt_address_user";
            this.txt_address_user.Size = new System.Drawing.Size(345, 41);
            this.txt_address_user.TabIndex = 39;
            this.txt_address_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_tphone_user
            // 
            this.txt_tphone_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tphone_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tphone_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_tphone_user.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_tphone_user.HintText = "Telephone Number";
            this.txt_tphone_user.isPassword = false;
            this.txt_tphone_user.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tphone_user.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tphone_user.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tphone_user.LineThickness = 3;
            this.txt_tphone_user.Location = new System.Drawing.Point(107, 155);
            this.txt_tphone_user.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_tphone_user.Name = "txt_tphone_user";
            this.txt_tphone_user.Size = new System.Drawing.Size(345, 41);
            this.txt_tphone_user.TabIndex = 38;
            this.txt_tphone_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tphone_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tphone_user_KeyPress);
            // 
            // txt_uname_user
            // 
            this.txt_uname_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_uname_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_uname_user.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_uname_user.HintText = "User Name";
            this.txt_uname_user.isPassword = false;
            this.txt_uname_user.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txt_uname_user.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txt_uname_user.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.txt_uname_user.LineThickness = 3;
            this.txt_uname_user.Location = new System.Drawing.Point(107, 102);
            this.txt_uname_user.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_uname_user.Name = "txt_uname_user";
            this.txt_uname_user.Size = new System.Drawing.Size(345, 41);
            this.txt_uname_user.TabIndex = 36;
            this.txt_uname_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.ActiveBorderThickness = 1;
            this.btn_AddUser.ActiveCornerRadius = 20;
            this.btn_AddUser.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_AddUser.ActiveForecolor = System.Drawing.Color.White;
            this.btn_AddUser.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btn_AddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddUser.BackgroundImage")));
            this.btn_AddUser.ButtonText = "Add User";
            this.btn_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.btn_AddUser.IdleBorderThickness = 1;
            this.btn_AddUser.IdleCornerRadius = 20;
            this.btn_AddUser.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_AddUser.IdleForecolor = System.Drawing.Color.White;
            this.btn_AddUser.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.btn_AddUser.Location = new System.Drawing.Point(112, 433);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(340, 50);
            this.btn_AddUser.TabIndex = 37;
            this.btn_AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(155, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "User Registration";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mobile",
            "Telephone"});
            this.comboBox1.Location = new System.Drawing.Point(291, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 44;
            // 
            // telephoneDataSet
            // 
            this.telephoneDataSet.DataSetName = "TelephoneDataSet";
            this.telephoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoationBindingSource
            // 
            this.infoationBindingSource.DataMember = "infoation";
            this.infoationBindingSource.DataSource = this.telephoneDataSet;
            // 
            // infoationTableAdapter
            // 
            this.infoationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 45;
            // 
            // UC_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.Panel_AddUser);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_AddUser";
            this.Size = new System.Drawing.Size(665, 647);
            this.Load += new System.EventHandler(this.UC_AddUser_Load);
            this.Panel_AddUser.ResumeLayout(false);
            this.Panel_AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel Panel_AddUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mdcon_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_typcon_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ciyt_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_address_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tphone_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_uname_user;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource infoationBindingSource;
        private TelephoneDataSet telephoneDataSet;
        private TelephoneDataSetTableAdapters.infoationTableAdapter infoationTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
