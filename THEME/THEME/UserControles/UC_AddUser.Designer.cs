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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddUser));
            this.txt_mdcon_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_typcon_user = new System.Windows.Forms.ComboBox();
            this.txt_ciyt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_address_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tphone_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_uname_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
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
            this.txt_mdcon_user.Location = new System.Drawing.Point(121, 302);
            this.txt_mdcon_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mdcon_user.Name = "txt_mdcon_user";
            this.txt_mdcon_user.Size = new System.Drawing.Size(259, 33);
            this.txt_mdcon_user.TabIndex = 34;
            this.txt_mdcon_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(118, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 33;
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
            this.cmbox_typcon_user.Location = new System.Drawing.Point(259, 348);
            this.cmbox_typcon_user.Name = "cmbox_typcon_user";
            this.cmbox_typcon_user.Size = new System.Drawing.Size(121, 21);
            this.cmbox_typcon_user.TabIndex = 32;
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
            this.txt_ciyt_user.Location = new System.Drawing.Point(121, 261);
            this.txt_ciyt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciyt_user.Name = "txt_ciyt_user";
            this.txt_ciyt_user.Size = new System.Drawing.Size(259, 33);
            this.txt_ciyt_user.TabIndex = 31;
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
            this.txt_address_user.Location = new System.Drawing.Point(121, 220);
            this.txt_address_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address_user.Name = "txt_address_user";
            this.txt_address_user.Size = new System.Drawing.Size(259, 33);
            this.txt_address_user.TabIndex = 30;
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
            this.txt_tphone_user.Location = new System.Drawing.Point(121, 179);
            this.txt_tphone_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tphone_user.Name = "txt_tphone_user";
            this.txt_tphone_user.Size = new System.Drawing.Size(259, 33);
            this.txt_tphone_user.TabIndex = 29;
            this.txt_tphone_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_uname_user.Location = new System.Drawing.Point(121, 136);
            this.txt_uname_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uname_user.Name = "txt_uname_user";
            this.txt_uname_user.Size = new System.Drawing.Size(259, 33);
            this.txt_uname_user.TabIndex = 27;
            this.txt_uname_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Register";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.bunifuThinButton24.Location = new System.Drawing.Point(125, 405);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(255, 41);
            this.bunifuThinButton24.TabIndex = 28;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(154, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "User Registration";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(164, 474);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 12);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "@copyright 2019 Telephone Connection";
            // 
            // UC_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_mdcon_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_typcon_user);
            this.Controls.Add(this.txt_ciyt_user);
            this.Controls.Add(this.txt_address_user);
            this.Controls.Add(this.txt_tphone_user);
            this.Controls.Add(this.txt_uname_user);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.label4);
            this.Name = "UC_AddUser";
            this.Size = new System.Drawing.Size(499, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mdcon_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_typcon_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ciyt_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_address_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tphone_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_uname_user;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
