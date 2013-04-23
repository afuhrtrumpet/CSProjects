namespace Paintball
{
    partial class Long2P
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tkbSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstLives = new System.Windows.Forms.ListBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.powerUpTimer = new System.Windows.Forms.Timer(this.components);
            this.powerAppearTimer = new System.Windows.Forms.Timer(this.components);
            this.powerStartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Plum;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 486);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // tkbSpeed
            // 
            this.tkbSpeed.Location = new System.Drawing.Point(12, 12);
            this.tkbSpeed.Maximum = 20;
            this.tkbSpeed.Minimum = 5;
            this.tkbSpeed.Name = "tkbSpeed";
            this.tkbSpeed.Size = new System.Drawing.Size(172, 45);
            this.tkbSpeed.TabIndex = 1;
            this.tkbSpeed.Value = 5;
            this.tkbSpeed.ValueChanged += new System.EventHandler(this.tkbSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed";
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(530, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 34);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(665, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstLives
            // 
            this.lstLives.FormattingEnabled = true;
            this.lstLives.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.lstLives.Location = new System.Drawing.Point(394, 12);
            this.lstLives.Name = "lstLives";
            this.lstLives.Size = new System.Drawing.Size(102, 30);
            this.lstLives.TabIndex = 5;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(314, 12);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(53, 24);
            this.lblLives.TabIndex = 6;
            this.lblLives.Text = "Lives";
            // 
            // powerUpTimer
            // 
            this.powerUpTimer.Interval = 1000;
            this.powerUpTimer.Tick += new System.EventHandler(this.powerUpTimer_Tick);
            // 
            // powerAppearTimer
            // 
            this.powerAppearTimer.Interval = 15000;
            this.powerAppearTimer.Tick += new System.EventHandler(this.powerAppearTimer_Tick);
            // 
            // powerStartTimer
            // 
            this.powerStartTimer.Interval = 10000;
            this.powerStartTimer.Tick += new System.EventHandler(this.powerStartTimer_Tick);
            // 
            // Long2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lstLives);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tkbSpeed);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Long2P";
            this.Text = "Two-Player Game (Long)";
            this.Load += new System.EventHandler(this.Long2P_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short2P_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tkbSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstLives;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer powerUpTimer;
        private System.Windows.Forms.Timer powerAppearTimer;
        private System.Windows.Forms.Timer powerStartTimer;
    }
}