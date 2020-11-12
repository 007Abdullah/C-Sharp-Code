namespace WindowsFormsApplication8
{
    partial class mode_of_connection
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeofconnectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofconntionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneDataSet = new WindowsFormsApplication8.TelephoneDataSet();
            this.infoationTableAdapter = new WindowsFormsApplication8.TelephoneDataSetTableAdapters.infoationTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mobile",
            "Landline"});
            this.comboBox1.Location = new System.Drawing.Point(505, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.telephoneNODataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.modeofconnectionDataGridViewTextBoxColumn,
            this.typeofconntionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(223, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // telephoneNODataGridViewTextBoxColumn
            // 
            this.telephoneNODataGridViewTextBoxColumn.DataPropertyName = "TelephoneNO";
            this.telephoneNODataGridViewTextBoxColumn.HeaderText = "TelephoneNO";
            this.telephoneNODataGridViewTextBoxColumn.Name = "telephoneNODataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // modeofconnectionDataGridViewTextBoxColumn
            // 
            this.modeofconnectionDataGridViewTextBoxColumn.DataPropertyName = "Mode_of_connection";
            this.modeofconnectionDataGridViewTextBoxColumn.HeaderText = "Mode_of_connection";
            this.modeofconnectionDataGridViewTextBoxColumn.Name = "modeofconnectionDataGridViewTextBoxColumn";
            // 
            // typeofconntionDataGridViewTextBoxColumn
            // 
            this.typeofconntionDataGridViewTextBoxColumn.DataPropertyName = "type_of_conntion";
            this.typeofconntionDataGridViewTextBoxColumn.HeaderText = "type_of_conntion";
            this.typeofconntionDataGridViewTextBoxColumn.Name = "typeofconntionDataGridViewTextBoxColumn";
            // 
            // infoationBindingSource
            // 
            this.infoationBindingSource.DataMember = "infoation";
            this.infoationBindingSource.DataSource = this.telephoneDataSet;
            // 
            // telephoneDataSet
            // 
            this.telephoneDataSet.DataSetName = "TelephoneDataSet";
            this.telephoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoationTableAdapter
            // 
            this.infoationTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(146, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(838, 361);
            this.reportViewer1.TabIndex = 2;
            // 
            // mode_of_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "mode_of_connection";
            this.Text = "mode_of_connection";
            this.Load += new System.EventHandler(this.mode_of_connection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelephoneDataSet telephoneDataSet;
        private System.Windows.Forms.BindingSource infoationBindingSource;
        private TelephoneDataSetTableAdapters.infoationTableAdapter infoationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeofconnectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofconntionDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}