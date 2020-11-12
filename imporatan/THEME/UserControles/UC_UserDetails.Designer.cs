namespace THEME.UserControles
{
    partial class UC_UserDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_pnumber_check = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrid_UserDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_UserDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pnumber_check
            // 
            this.txt_pnumber_check.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pnumber_check.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pnumber_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_pnumber_check.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.txt_pnumber_check.HintText = "Enter Phone Number";
            this.txt_pnumber_check.isPassword = false;
            this.txt_pnumber_check.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pnumber_check.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pnumber_check.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pnumber_check.LineThickness = 3;
            this.txt_pnumber_check.Location = new System.Drawing.Point(67, 162);
            this.txt_pnumber_check.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pnumber_check.Name = "txt_pnumber_check";
            this.txt_pnumber_check.Size = new System.Drawing.Size(364, 33);
            this.txt_pnumber_check.TabIndex = 31;
            this.txt_pnumber_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pnumber_check.OnValueChanged += new System.EventHandler(this.txt_pnumber_check_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(138, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "User Detail Check";
            // 
            // DataGrid_UserDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_UserDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_UserDetail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_UserDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_UserDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_UserDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_UserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_UserDetail.DoubleBuffered = true;
            this.DataGrid_UserDetail.EnableHeadersVisualStyles = false;
            this.DataGrid_UserDetail.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGrid_UserDetail.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGrid_UserDetail.Location = new System.Drawing.Point(67, 245);
            this.DataGrid_UserDetail.Name = "DataGrid_UserDetail";
            this.DataGrid_UserDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_UserDetail.Size = new System.Drawing.Size(364, 150);
            this.DataGrid_UserDetail.TabIndex = 29;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(164, 474);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 12);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "@copyright 2019 Telephone Connection";
            // 
            // UC_UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_pnumber_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrid_UserDetail);
            this.Name = "UC_UserDetails";
            this.Size = new System.Drawing.Size(499, 526);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_UserDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pnumber_check;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_UserDetail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
