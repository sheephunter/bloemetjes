namespace pojecta_natschool
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
            this.WBnat = new System.Windows.Forms.WebBrowser();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.leerlingLB = new System.Windows.Forms.Label();
            this.wwLB = new System.Windows.Forms.Label();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.numberTXT = new System.Windows.Forms.TextBox();
            this.roosterBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WBnat
            // 
            this.WBnat.Dock = System.Windows.Forms.DockStyle.Left;
            this.WBnat.Location = new System.Drawing.Point(0, 0);
            this.WBnat.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBnat.Name = "WBnat";
            this.WBnat.Size = new System.Drawing.Size(807, 398);
            this.WBnat.TabIndex = 0;
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(942, 19);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(176, 20);
            this.userTXT.TabIndex = 1;
            // 
            // leerlingLB
            // 
            this.leerlingLB.AutoSize = true;
            this.leerlingLB.Location = new System.Drawing.Point(825, 26);
            this.leerlingLB.Name = "leerlingLB";
            this.leerlingLB.Size = new System.Drawing.Size(83, 13);
            this.leerlingLB.TabIndex = 2;
            this.leerlingLB.Text = "leerlingnummer :";
            // 
            // wwLB
            // 
            this.wwLB.AutoSize = true;
            this.wwLB.Location = new System.Drawing.Point(828, 67);
            this.wwLB.Name = "wwLB";
            this.wwLB.Size = new System.Drawing.Size(71, 13);
            this.wwLB.TabIndex = 3;
            this.wwLB.Text = "wachtwoord :";
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(942, 64);
            this.passTXT.Name = "passTXT";
            this.passTXT.Size = new System.Drawing.Size(176, 20);
            this.passTXT.TabIndex = 4;
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(831, 104);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(287, 23);
            this.loginBTN.TabIndex = 5;
            this.loginBTN.Text = "login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // numberTXT
            // 
            this.numberTXT.Location = new System.Drawing.Point(942, 234);
            this.numberTXT.Name = "numberTXT";
            this.numberTXT.Size = new System.Drawing.Size(176, 20);
            this.numberTXT.TabIndex = 6;
            // 
            // roosterBTN
            // 
            this.roosterBTN.Location = new System.Drawing.Point(828, 230);
            this.roosterBTN.Name = "roosterBTN";
            this.roosterBTN.Size = new System.Drawing.Size(75, 23);
            this.roosterBTN.TabIndex = 7;
            this.roosterBTN.Text = "rooster";
            this.roosterBTN.UseVisualStyleBackColor = true;
            this.roosterBTN.Click += new System.EventHandler(this.roosterBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 398);
            this.Controls.Add(this.roosterBTN);
            this.Controls.Add(this.numberTXT);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.wwLB);
            this.Controls.Add(this.leerlingLB);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.WBnat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBnat;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.Label leerlingLB;
        private System.Windows.Forms.Label wwLB;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox numberTXT;
        private System.Windows.Forms.Button roosterBTN;
    }
}

