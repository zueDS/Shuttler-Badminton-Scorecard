namespace last_final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.shuttler = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new last_final.UserControl1();
            this.userControl21 = new last_final.UserControl2();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.about);
            this.panel2.Location = new System.Drawing.Point(0, 508);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 69);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ZT Grafton", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(909, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAAGOORZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(820, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Powered By";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.Snow;
            this.about.Location = new System.Drawing.Point(40, 17);
            this.about.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(93, 25);
            this.about.TabIndex = 0;
            this.about.Text = "About Us";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // shuttler
            // 
            this.shuttler.AutoSize = true;
            this.shuttler.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.shuttler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shuttler.Location = new System.Drawing.Point(36, 17);
            this.shuttler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shuttler.Name = "shuttler";
            this.shuttler.Size = new System.Drawing.Size(146, 53);
            this.shuttler.TabIndex = 2;
            this.shuttler.Text = "Shuttler";
            this.shuttler.Click += new System.EventHandler(this.shuttler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.shuttler);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 79);
            this.panel1.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(53, 98);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(962, 390);
            this.userControl11.TabIndex = 5;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(184, 103);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(743, 354);
            this.userControl21.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1065, 567);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shuttler";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label shuttler;
        private System.Windows.Forms.Panel panel1;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
    }
}

