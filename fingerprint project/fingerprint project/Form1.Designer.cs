namespace fingerprint_project
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
            this.BtnFirstpicture = new System.Windows.Forms.Button();
            this.BtnSecondpicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btncompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFirstpicture
            // 
            this.BtnFirstpicture.Location = new System.Drawing.Point(39, 26);
            this.BtnFirstpicture.Name = "BtnFirstpicture";
            this.BtnFirstpicture.Size = new System.Drawing.Size(358, 76);
            this.BtnFirstpicture.TabIndex = 0;
            this.BtnFirstpicture.Text = "Select First FringerPrint";
            this.BtnFirstpicture.UseVisualStyleBackColor = true;
            this.BtnFirstpicture.Click += new System.EventHandler(this.BtnFirstpicture_Click);
            // 
            // BtnSecondpicture
            // 
            this.BtnSecondpicture.Location = new System.Drawing.Point(490, 26);
            this.BtnSecondpicture.Name = "BtnSecondpicture";
            this.BtnSecondpicture.Size = new System.Drawing.Size(358, 76);
            this.BtnSecondpicture.TabIndex = 1;
            this.BtnSecondpicture.Text = "Select Second Fingerprint";
            this.BtnSecondpicture.UseVisualStyleBackColor = true;
            this.BtnSecondpicture.Click += new System.EventHandler(this.BtnSecondpicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(490, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Btncompare
            // 
            this.Btncompare.Location = new System.Drawing.Point(307, 431);
            this.Btncompare.Name = "Btncompare";
            this.Btncompare.Size = new System.Drawing.Size(269, 72);
            this.Btncompare.TabIndex = 4;
            this.Btncompare.Text = "Compare Between Two Finger";
            this.Btncompare.UseVisualStyleBackColor = true;
            this.Btncompare.Click += new System.EventHandler(this.Btncompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 553);
            this.Controls.Add(this.Btncompare);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSecondpicture);
            this.Controls.Add(this.BtnFirstpicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFirstpicture;
        private System.Windows.Forms.Button BtnSecondpicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btncompare;
    }
}

