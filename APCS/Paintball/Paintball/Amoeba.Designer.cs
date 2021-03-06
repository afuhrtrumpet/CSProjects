﻿namespace Paintball
{
    partial class Amoeba
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
            this.lstDuplication = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.duplicationTimer = new System.Windows.Forms.Timer(this.components);
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGreen;
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
            this.tkbSpeed.Size = new System.Drawing.Size(231, 45);
            this.tkbSpeed.TabIndex = 1;
            this.tkbSpeed.Value = 5;
            this.tkbSpeed.ValueChanged += new System.EventHandler(this.tkbSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 12);
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
            // lstDuplication
            // 
            this.lstDuplication.FormattingEnabled = true;
            this.lstDuplication.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstDuplication.Location = new System.Drawing.Point(424, 16);
            this.lstDuplication.Name = "lstDuplication";
            this.lstDuplication.Size = new System.Drawing.Size(100, 30);
            this.lstDuplication.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 53);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duplication Interval";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // duplicationTimer
            // 
            this.duplicationTimer.Tick += new System.EventHandler(this.duplicationTimer_Tick);
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // Amoeba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDuplication);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tkbSpeed);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Amoeba";
            this.Text = "1-Player Game (Amoeba)";
            this.Load += new System.EventHandler(this.Amoeba_Load);
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
        private System.Windows.Forms.ListBox lstDuplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer duplicationTimer;
        private System.Windows.Forms.Timer moveTimer;
    }
}