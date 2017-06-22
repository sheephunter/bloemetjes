namespace muziekieApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.PbSong = new System.Windows.Forms.ProgressBar();
            this.DgMenu = new System.Windows.Forms.DataGridView();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnShuffle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1131, 489);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(657, 536);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "button1";
            this.BtnPlay.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.Location = new System.Drawing.Point(738, 536);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(75, 23);
            this.BtnForward.TabIndex = 3;
            this.BtnForward.Text = "button3";
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.button3_Click);
            // 
            // PbSong
            // 
            this.PbSong.Location = new System.Drawing.Point(171, 579);
            this.PbSong.Name = "PbSong";
            this.PbSong.Size = new System.Drawing.Size(1131, 23);
            this.PbSong.TabIndex = 4;
            // 
            // DgMenu
            // 
            this.DgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMenu.Location = new System.Drawing.Point(12, 12);
            this.DgMenu.Name = "DgMenu";
            this.DgMenu.Size = new System.Drawing.Size(132, 518);
            this.DgMenu.TabIndex = 5;
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(1337, 12);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(75, 23);
            this.BtnUser.TabIndex = 6;
            this.BtnUser.Text = "button1";
            this.BtnUser.UseVisualStyleBackColor = true;
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.Location = new System.Drawing.Point(171, 12);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(75, 23);
            this.BtnShuffle.TabIndex = 7;
            this.BtnShuffle.Text = "button1";
            this.BtnShuffle.UseVisualStyleBackColor = true;
            this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 614);
            this.Controls.Add(this.BtnShuffle);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.DgMenu);
            this.Controls.Add(this.PbSong);
            this.Controls.Add(this.BtnForward);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.ProgressBar PbSong;
        private System.Windows.Forms.DataGridView DgMenu;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnShuffle;
    }
}

