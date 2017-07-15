namespace CookieClicker.Forms
{
    partial class ClickerGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PointerButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PointerCPSLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PointerLevelLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StrongClickButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StrongClickCPCLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StrongClickLevelLabel = new System.Windows.Forms.Label();
            this.CPSLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CPCLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CookieColectedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CPSLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CPCLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CookieColectedLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upgrades";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PointerButton);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.PointerCPSLabel);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.PointerLevelLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Pointers";
            // 
            // PointerButton
            // 
            this.PointerButton.Enabled = false;
            this.PointerButton.Location = new System.Drawing.Point(71, 18);
            this.PointerButton.Name = "PointerButton";
            this.PointerButton.Size = new System.Drawing.Size(111, 23);
            this.PointerButton.TabIndex = 12;
            this.PointerButton.Text = "PointerButton";
            this.PointerButton.UseVisualStyleBackColor = true;
            this.PointerButton.Click += new System.EventHandler(this.PointerButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CookieClicker.Properties.Resources.SoftwareIcons_38_512;
            this.pictureBox3.Location = new System.Drawing.Point(10, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // PointerCPSLabel
            // 
            this.PointerCPSLabel.AutoSize = true;
            this.PointerCPSLabel.Location = new System.Drawing.Point(153, 66);
            this.PointerCPSLabel.Name = "PointerCPSLabel";
            this.PointerCPSLabel.Size = new System.Drawing.Size(87, 13);
            this.PointerCPSLabel.TabIndex = 10;
            this.PointerCPSLabel.Text = "PointerCPSLabel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Level : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "+ CPS Next Lvl :";
            // 
            // PointerLevelLabel
            // 
            this.PointerLevelLabel.AutoSize = true;
            this.PointerLevelLabel.Location = new System.Drawing.Point(122, 44);
            this.PointerLevelLabel.Name = "PointerLevelLabel";
            this.PointerLevelLabel.Size = new System.Drawing.Size(92, 13);
            this.PointerLevelLabel.TabIndex = 8;
            this.PointerLevelLabel.Text = "PointerLevelLabel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StrongClickButton);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.StrongClickCPCLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.StrongClickLevelLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stronger Clicks";
            // 
            // StrongClickButton
            // 
            this.StrongClickButton.Enabled = false;
            this.StrongClickButton.Location = new System.Drawing.Point(71, 18);
            this.StrongClickButton.Name = "StrongClickButton";
            this.StrongClickButton.Size = new System.Drawing.Size(111, 23);
            this.StrongClickButton.TabIndex = 11;
            this.StrongClickButton.Text = "StrongClickButton";
            this.StrongClickButton.UseVisualStyleBackColor = true;
            this.StrongClickButton.Click += new System.EventHandler(this.StrongClickButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CookieClicker.Properties.Resources._2075_512;
            this.pictureBox2.Location = new System.Drawing.Point(10, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // StrongClickCPCLabel
            // 
            this.StrongClickCPCLabel.AutoSize = true;
            this.StrongClickCPCLabel.Location = new System.Drawing.Point(153, 66);
            this.StrongClickCPCLabel.Name = "StrongClickCPCLabel";
            this.StrongClickCPCLabel.Size = new System.Drawing.Size(108, 13);
            this.StrongClickCPCLabel.TabIndex = 10;
            this.StrongClickCPCLabel.Text = "StrongClickCPCLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Level : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "+ CPC Next Lvl :";
            // 
            // StrongClickLevelLabel
            // 
            this.StrongClickLevelLabel.AutoSize = true;
            this.StrongClickLevelLabel.Location = new System.Drawing.Point(122, 44);
            this.StrongClickLevelLabel.Name = "StrongClickLevelLabel";
            this.StrongClickLevelLabel.Size = new System.Drawing.Size(113, 13);
            this.StrongClickLevelLabel.TabIndex = 8;
            this.StrongClickLevelLabel.Text = "StrongClickLevelLabel";
            // 
            // CPSLabel
            // 
            this.CPSLabel.AutoSize = true;
            this.CPSLabel.Location = new System.Drawing.Point(70, 66);
            this.CPSLabel.Name = "CPSLabel";
            this.CPSLabel.Size = new System.Drawing.Size(54, 13);
            this.CPSLabel.TabIndex = 5;
            this.CPSLabel.Text = "CPSLabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CPS:";
            // 
            // CPCLabel
            // 
            this.CPCLabel.AutoSize = true;
            this.CPCLabel.Location = new System.Drawing.Point(70, 43);
            this.CPCLabel.Name = "CPCLabel";
            this.CPCLabel.Size = new System.Drawing.Size(54, 13);
            this.CPCLabel.TabIndex = 3;
            this.CPCLabel.Text = "CPCLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPC :";
            // 
            // CookieColectedLabel
            // 
            this.CookieColectedLabel.AutoSize = true;
            this.CookieColectedLabel.Location = new System.Drawing.Point(70, 20);
            this.CookieColectedLabel.Name = "CookieColectedLabel";
            this.CookieColectedLabel.Size = new System.Drawing.Size(108, 13);
            this.CookieColectedLabel.TabIndex = 1;
            this.CookieColectedLabel.Text = "CookieColectedLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cookies :";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(799, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StatisticsForm_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CookieClicker.Properties.Resources.IFCWGMf;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CookiePictureBox_Click);
            // 
            // ClickerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClickerGame";
            this.Text = "CookieClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClickerGame_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CookieColectedLabel;
        private System.Windows.Forms.Label CPSLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CPCLabel;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label StrongClickCPCLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label StrongClickLevelLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PointerCPSLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label PointerLevelLabel;
        private System.Windows.Forms.Button PointerButton;
        private System.Windows.Forms.Button StrongClickButton;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

