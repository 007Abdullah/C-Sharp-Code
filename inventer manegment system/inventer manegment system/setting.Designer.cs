namespace inventer_manegment_system
{
    partial class setting
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
            this.label3 = new System.Windows.Forms.Label();
            this.servertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databasetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passeordtxt = new System.Windows.Forms.TextBox();
            this.integratedtxt = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.leftpenal.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpenal
            // 
            this.leftpenal.Controls.Add(this.button1);
            this.leftpenal.Controls.Add(this.integratedtxt);
            this.leftpenal.Controls.Add(this.passeordtxt);
            this.leftpenal.Controls.Add(this.label6);
            this.leftpenal.Controls.Add(this.useridtxt);
            this.leftpenal.Controls.Add(this.label5);
            this.leftpenal.Controls.Add(this.databasetxt);
            this.leftpenal.Controls.Add(this.label4);
            this.leftpenal.Controls.Add(this.servertxt);
            this.leftpenal.Controls.Add(this.label3);
            this.leftpenal.Size = new System.Drawing.Size(250, 751);
            this.leftpenal.Controls.SetChildIndex(this.label3, 0);
            this.leftpenal.Controls.SetChildIndex(this.servertxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.label4, 0);
            this.leftpenal.Controls.SetChildIndex(this.databasetxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.label5, 0);
            this.leftpenal.Controls.SetChildIndex(this.useridtxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.label6, 0);
            this.leftpenal.Controls.SetChildIndex(this.passeordtxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.integratedtxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.button1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // servertxt
            // 
            this.servertxt.Location = new System.Drawing.Point(12, 278);
            this.servertxt.MaxLength = 100;
            this.servertxt.Name = "servertxt";
            this.servertxt.Size = new System.Drawing.Size(223, 27);
            this.servertxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database";
            // 
            // databasetxt
            // 
            this.databasetxt.Location = new System.Drawing.Point(12, 331);
            this.databasetxt.MaxLength = 100;
            this.databasetxt.Name = "databasetxt";
            this.databasetxt.Size = new System.Drawing.Size(223, 27);
            this.databasetxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "User ID";
            // 
            // useridtxt
            // 
            this.useridtxt.Location = new System.Drawing.Point(12, 389);
            this.useridtxt.MaxLength = 100;
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(223, 27);
            this.useridtxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // passeordtxt
            // 
            this.passeordtxt.Location = new System.Drawing.Point(12, 450);
            this.passeordtxt.MaxLength = 100;
            this.passeordtxt.Name = "passeordtxt";
            this.passeordtxt.Size = new System.Drawing.Size(223, 27);
            this.passeordtxt.TabIndex = 3;
            this.passeordtxt.UseSystemPasswordChar = true;
            // 
            // integratedtxt
            // 
            this.integratedtxt.AutoSize = true;
            this.integratedtxt.Location = new System.Drawing.Point(12, 493);
            this.integratedtxt.Name = "integratedtxt";
            this.integratedtxt.Size = new System.Drawing.Size(148, 24);
            this.integratedtxt.TabIndex = 4;
            this.integratedtxt.Text = "Integrted Security";
            this.integratedtxt.UseVisualStyleBackColor = true;
            this.integratedtxt.CheckedChanged += new System.EventHandler(this.integratedtxt_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 751);
            this.Name = "setting";
            this.Text = "setting";
            this.leftpenal.ResumeLayout(false);
            this.leftpenal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox integratedtxt;
        private System.Windows.Forms.TextBox passeordtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox useridtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox databasetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servertxt;
    }
}