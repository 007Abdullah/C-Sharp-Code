﻿namespace Telephone_Connection_Systems
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(311, 83);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(177, 22);
            this.txtbox1.TabIndex = 0;
            this.txtbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Father Name";
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(311, 131);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(177, 22);
            this.txtbox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(311, 183);
            this.txtbox3.MaxLength = 3;
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(177, 22);
            this.txtbox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // txtbox4
            // 
            this.txtbox4.Location = new System.Drawing.Point(311, 237);
            this.txtbox4.Name = "txtbox4";
            this.txtbox4.Size = new System.Drawing.Size(177, 22);
            this.txtbox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // txtbox5
            // 
            this.txtbox5.Location = new System.Drawing.Point(311, 288);
            this.txtbox5.Name = "txtbox5";
            this.txtbox5.Size = new System.Drawing.Size(177, 22);
            this.txtbox5.TabIndex = 4;
            this.txtbox5.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtbox1;
    }
}