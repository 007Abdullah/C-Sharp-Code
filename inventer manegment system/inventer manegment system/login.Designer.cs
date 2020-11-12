namespace inventer_manegment_system
{
    partial class login
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.leftpenal.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpenal
            // 
            this.leftpenal.Controls.Add(this.button1);
            this.leftpenal.Controls.Add(this.passwordtxt);
            this.leftpenal.Controls.Add(this.label4);
            this.leftpenal.Controls.Add(this.usernametxt);
            this.leftpenal.Controls.Add(this.label3);
            this.leftpenal.Controls.SetChildIndex(this.label3, 0);
            this.leftpenal.Controls.SetChildIndex(this.usernametxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.label4, 0);
            this.leftpenal.Controls.SetChildIndex(this.passwordtxt, 0);
            this.leftpenal.Controls.SetChildIndex(this.button1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(12, 281);
            this.usernametxt.MaxLength = 30;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(222, 27);
            this.usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(12, 334);
            this.passwordtxt.MaxLength = 30;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(222, 27);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 722);
            this.Name = "login";
            this.Text = "login";
            this.leftpenal.ResumeLayout(false);
            this.leftpenal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametxt;
    }
}