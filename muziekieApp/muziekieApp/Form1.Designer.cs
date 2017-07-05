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
            this.Btnreplay = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.rbTheme1 = new System.Windows.Forms.RadioButton();
            this.rbThemeDefault = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnPlay.BackColor = System.Drawing.Color.Teal;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlay.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(657, 535);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(86, 37);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(556, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.BackColor = System.Drawing.Color.Teal;
            this.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnForward.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForward.Location = new System.Drawing.Point(769, 535);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(75, 37);
            this.BtnForward.TabIndex = 3;
            this.BtnForward.Text = "->";
            this.BtnForward.UseVisualStyleBackColor = false;
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
            this.BtnUser.Location = new System.Drawing.Point(1309, 12);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(75, 23);
            this.BtnUser.TabIndex = 6;
            this.BtnUser.Text = "button1";
            this.BtnUser.UseVisualStyleBackColor = true;
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.BackColor = System.Drawing.Color.Teal;
            this.BtnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShuffle.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShuffle.Location = new System.Drawing.Point(171, 12);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(91, 23);
            this.BtnShuffle.TabIndex = 7;
            this.BtnShuffle.Text = "Shuffle";
            this.BtnShuffle.UseVisualStyleBackColor = false;
            this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // Btnreplay
            // 
            this.Btnreplay.BackColor = System.Drawing.Color.Teal;
            this.Btnreplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnreplay.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnreplay.Location = new System.Drawing.Point(1227, 536);
            this.Btnreplay.Name = "Btnreplay";
            this.Btnreplay.Size = new System.Drawing.Size(75, 37);
            this.Btnreplay.TabIndex = 8;
            this.Btnreplay.Text = "Replay";
            this.Btnreplay.UseVisualStyleBackColor = false;
            this.Btnreplay.Click += new System.EventHandler(this.Btnreplay_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Teal;
            this.BtnStop.Enabled = false;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStop.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(657, 535);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(86, 37);
            this.BtnStop.TabIndex = 9;
            this.BtnStop.Text = "Pause";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Visible = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // rbTheme1
            // 
            this.rbTheme1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTheme1.AutoSize = true;
            this.rbTheme1.BackColor = System.Drawing.Color.Teal;
            this.rbTheme1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTheme1.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTheme1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbTheme1.Location = new System.Drawing.Point(12, 543);
            this.rbTheme1.Name = "rbTheme1";
            this.rbTheme1.Size = new System.Drawing.Size(70, 30);
            this.rbTheme1.TabIndex = 10;
            this.rbTheme1.TabStop = true;
            this.rbTheme1.Text = "space";
            this.rbTheme1.UseVisualStyleBackColor = false;
            this.rbTheme1.CheckedChanged += new System.EventHandler(this.rbTheme1_CheckedChanged);
            // 
            // rbThemeDefault
            // 
            this.rbThemeDefault.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbThemeDefault.AutoSize = true;
            this.rbThemeDefault.BackColor = System.Drawing.Color.Teal;
            this.rbThemeDefault.Enabled = false;
            this.rbThemeDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbThemeDefault.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThemeDefault.Location = new System.Drawing.Point(12, 579);
            this.rbThemeDefault.Name = "rbThemeDefault";
            this.rbThemeDefault.Size = new System.Drawing.Size(81, 30);
            this.rbThemeDefault.TabIndex = 11;
            this.rbThemeDefault.TabStop = true;
            this.rbThemeDefault.Text = "default";
            this.rbThemeDefault.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(268, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "~";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::muziekieApp.Properties.Resources.mountain;
            this.ClientSize = new System.Drawing.Size(1480, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbThemeDefault);
            this.Controls.Add(this.rbTheme1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.Btnreplay);
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
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Btnreplay;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.RadioButton rbTheme1;
        private System.Windows.Forms.RadioButton rbThemeDefault;
        private System.Windows.Forms.Label label1;
    }
}

