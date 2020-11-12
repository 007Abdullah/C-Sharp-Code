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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txt_pnumber_check.Location = new System.Drawing.Point(89, 199);
            this.txt_pnumber_check.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_pnumber_check.Name = "txt_pnumber_check";
            this.txt_pnumber_check.Size = new System.Drawing.Size(485, 41);
            this.txt_pnumber_check.TabIndex = 31;
            this.txt_pnumber_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
//            this.txt_pnumber_check.OnValueChanged += new System.EventHandler(this.txt_pnumber_check_OnValueChanged);
            this.txt_pnumber_check.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pnumber_check_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(184, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "User Detail Check";
            // 
            // DataGrid_UserDetail
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_UserDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_UserDetail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_UserDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_UserDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_UserDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_UserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_UserDetail.DoubleBuffered = true;
            this.DataGrid_UserDetail.EnableHeadersVisualStyles = false;
            this.DataGrid_UserDetail.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGrid_UserDetail.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGrid_UserDetail.Location = new System.Drawing.Point(89, 302);
            this.DataGrid_UserDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid_UserDetail.Name = "DataGrid_UserDetail";
            this.DataGrid_UserDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_UserDetail.Size = new System.Drawing.Size(485, 185);
            this.DataGrid_UserDetail.TabIndex = 29;
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
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "@copyright 2019 Telephone Connection";
            // 
            // UC_UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_pnumber_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrid_UserDetail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_UserDetails";
            this.Size = new System.Drawing.Size(665, 647);
            this.Load += new System.EventHandler(this.UC_UserDetails_Load);
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
