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
            this.components = new System.ComponentModel.Container();
            this.txt_pnumber_check = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.telephoneDataSet = new THEME.TelephoneDataSet();
            this.infoationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoationTableAdapter = new THEME.TelephoneDataSetTableAdapters.infoationTableAdapter();
            this.infoationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeofconntionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeofconnectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomDataGrid1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
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
            this.txt_pnumber_check.Margin = new System.Windows.Forms.Padding(5);
            this.txt_pnumber_check.Name = "txt_pnumber_check";
            this.txt_pnumber_check.Size = new System.Drawing.Size(485, 41);
            this.txt_pnumber_check.TabIndex = 31;
            this.txt_pnumber_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // infoationBindingSource1
            // 
            this.infoationBindingSource1.DataMember = "infoation";
            this.infoationBindingSource1.DataSource = this.telephoneDataSet;
            // 
            // typeofconntionDataGridViewTextBoxColumn
            // 
            this.typeofconntionDataGridViewTextBoxColumn.DataPropertyName = "type_of_conntion";
            this.typeofconntionDataGridViewTextBoxColumn.HeaderText = "type_of_conntion";
            this.typeofconntionDataGridViewTextBoxColumn.Name = "typeofconntionDataGridViewTextBoxColumn";
            // 
            // modeofconnectionDataGridViewTextBoxColumn
            // 
            this.modeofconnectionDataGridViewTextBoxColumn.DataPropertyName = "Mode_of_connection";
            this.modeofconnectionDataGridViewTextBoxColumn.HeaderText = "Mode_of_connection";
            this.modeofconnectionDataGridViewTextBoxColumn.Name = "modeofconnectionDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // telephoneNODataGridViewTextBoxColumn
            // 
            this.telephoneNODataGridViewTextBoxColumn.DataPropertyName = "TelephoneNO";
            this.telephoneNODataGridViewTextBoxColumn.HeaderText = "TelephoneNO";
            this.telephoneNODataGridViewTextBoxColumn.Name = "telephoneNODataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.telephoneNODataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.modeofconnectionDataGridViewTextBoxColumn,
            this.typeofconntionDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.infoationBindingSource;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(89, 304);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(485, 185);
            this.bunifuCustomDataGrid1.TabIndex = 33;
            // 
            // UC_UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_pnumber_check);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_UserDetails";
            this.Size = new System.Drawing.Size(665, 647);
            this.Load += new System.EventHandler(this.UC_UserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pnumber_check;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.BindingSource infoationBindingSource1;
        private TelephoneDataSet telephoneDataSet;
        private System.Windows.Forms.BindingSource infoationBindingSource;
        private TelephoneDataSetTableAdapters.infoationTableAdapter infoationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofconntionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeofconnectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView bunifuCustomDataGrid1;
    }
}
