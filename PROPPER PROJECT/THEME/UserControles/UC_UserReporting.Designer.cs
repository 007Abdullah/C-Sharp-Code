namespace THEME.UserControles
{
    partial class UC_UserReporting
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbox_typcon_user = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.telephoneDataSet1 = new THEME.TelephoneDataSet();
            this.infoationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoationTableAdapter = new THEME.TelephoneDataSetTableAdapters.infoationTableAdapter();
            this.telephoneDataSet2 = new THEME.TelephoneDataSet2();
            this.telephoneDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet2BindingSource)).BeginInit();
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
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "@copyright 2019 Telephone Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(243, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "User Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(141, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mode Of Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(141, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Type Of Connection";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mobile",
            "LandLine"});
            this.comboBox1.Location = new System.Drawing.Point(329, 154);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // cmbox_typcon_user
            // 
            this.cmbox_typcon_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.cmbox_typcon_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(14)))), ((int)(((byte)(116)))));
            this.cmbox_typcon_user.FormattingEnabled = true;
            this.cmbox_typcon_user.Items.AddRange(new object[] {
            "Prepaid",
            "Postpaid"});
            this.cmbox_typcon_user.Location = new System.Drawing.Point(329, 193);
            this.cmbox_typcon_user.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_typcon_user.Name = "cmbox_typcon_user";
            this.cmbox_typcon_user.Size = new System.Drawing.Size(160, 24);
            this.cmbox_typcon_user.TabIndex = 44;
            this.cmbox_typcon_user.SelectedValueChanged += new System.EventHandler(this.cmbox_typcon_user_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.telephoneDataSet2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "THEME.UserControles.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(93, 254);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(453, 246);
            this.reportViewer1.TabIndex = 47;
            // 
            // telephoneDataSet1
            // 
            this.telephoneDataSet1.DataSetName = "TelephoneDataSet";
            this.telephoneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoationBindingSource
            // 
            this.infoationBindingSource.DataMember = "infoation";
            this.infoationBindingSource.DataSource = this.telephoneDataSet1;
            // 
            // infoationTableAdapter
            // 
            this.infoationTableAdapter.ClearBeforeFill = true;
            // 
            // telephoneDataSet2
            // 
            this.telephoneDataSet2.DataSetName = "TelephoneDataSet2";
            this.telephoneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telephoneDataSet2BindingSource
            // 
            this.telephoneDataSet2BindingSource.DataSource = this.telephoneDataSet2;
            this.telephoneDataSet2BindingSource.Position = 0;
            // 
            // UC_UserReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbox_typcon_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_UserReporting";
            this.Size = new System.Drawing.Size(665, 647);
            this.Load += new System.EventHandler(this.UC_UserReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbox_typcon_user;
        private TelephoneDataSet telephoneDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource infoationBindingSource;
        private TelephoneDataSetTableAdapters.infoationTableAdapter infoationTableAdapter;
        private System.Windows.Forms.BindingSource telephoneDataSet2BindingSource;
        private TelephoneDataSet2 telephoneDataSet2;
    }
}
