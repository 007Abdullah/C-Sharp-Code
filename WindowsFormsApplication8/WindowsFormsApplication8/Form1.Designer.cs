namespace WindowsFormsApplication8
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.telephoneDataSet = new WindowsFormsApplication8.TelephoneDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.infoationTableAdapter = new WindowsFormsApplication8.TelephoneDataSetTableAdapters.infoationTableAdapter();
            this.infoationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoationTableAdapter1 = new WindowsFormsApplication8.TelephoneDataSetTableAdapters.infoationTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TelephoneDataSet1 = new WindowsFormsApplication8.TelephoneDataSet1();
            this.infoationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // telephoneDataSet
            // 
            this.telephoneDataSet.DataSetName = "TelephoneDataSet";
            this.telephoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Postpaid",
            "Prepaid"});
            this.comboBox1.Location = new System.Drawing.Point(334, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // infoationTableAdapter
            // 
            this.infoationTableAdapter.ClearBeforeFill = true;
            // 
            // infoationBindingSource1
            // 
            this.infoationBindingSource1.DataMember = "infoation";
            this.infoationBindingSource1.DataSource = this.telephoneDataSet;
            // 
            // telephoneDataSetBindingSource
            // 
            this.telephoneDataSetBindingSource.DataSource = this.telephoneDataSet;
            this.telephoneDataSetBindingSource.Position = 0;
            // 
            // infoationTableAdapter1
            // 
            this.infoationTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication8.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(126, 225);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 309);
            this.reportViewer1.TabIndex = 1;
            // 
            // TelephoneDataSet1
            // 
            this.TelephoneDataSet1.DataSetName = "TelephoneDataSet1";
            this.TelephoneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoationBindingSource
            // 
            this.infoationBindingSource.DataMember = "infoation";
            this.infoationBindingSource.DataSource = this.telephoneDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 618);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private TelephoneDataSet telephoneDataSet;
        private TelephoneDataSetTableAdapters.infoationTableAdapter infoationTableAdapter;
        private System.Windows.Forms.BindingSource infoationBindingSource1;
        private System.Windows.Forms.BindingSource telephoneDataSetBindingSource;
        private TelephoneDataSetTableAdapters.infoationTableAdapter infoationTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TelephoneDataSet1 TelephoneDataSet1;
        private System.Windows.Forms.BindingSource infoationBindingSource;
    }
}

