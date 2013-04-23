namespace AsciiAnimation
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentFrame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.computerAngerButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.jJacksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backBox = new System.Windows.Forms.CheckBox();
            this.lollercoasterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Current Frame";
            // 
            // lblCurrentFrame
            // 
            this.lblCurrentFrame.BackColor = System.Drawing.Color.PaleGreen;
            this.lblCurrentFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFrame.Location = new System.Drawing.Point(284, 425);
            this.lblCurrentFrame.Name = "lblCurrentFrame";
            this.lblCurrentFrame.Size = new System.Drawing.Size(90, 38);
            this.lblCurrentFrame.TabIndex = 20;
            this.lblCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(518, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Slow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fast";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(63, 425);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            // 
            // computerAngerButton
            // 
            this.computerAngerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerAngerButton.Location = new System.Drawing.Point(520, 140);
            this.computerAngerButton.Name = "computerAngerButton";
            this.computerAngerButton.Size = new System.Drawing.Size(129, 30);
            this.computerAngerButton.TabIndex = 15;
            this.computerAngerButton.Text = "Computer Anger";
            this.computerAngerButton.UseVisualStyleBackColor = true;
            this.computerAngerButton.Click += new System.EventHandler(this.computerAngerButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.Location = new System.Drawing.Point(518, 86);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(130, 32);
            this.trainButton.TabIndex = 14;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // jJacksButton
            // 
            this.jJacksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jJacksButton.Location = new System.Drawing.Point(520, 40);
            this.jJacksButton.Name = "jJacksButton";
            this.jJacksButton.Size = new System.Drawing.Size(129, 30);
            this.jJacksButton.TabIndex = 13;
            this.jJacksButton.Text = "Jumping Jacks";
            this.jJacksButton.UseVisualStyleBackColor = true;
            this.jJacksButton.Click += new System.EventHandler(this.jJacksButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 330);
            this.label1.TabIndex = 12;
            // 
            // backBox
            // 
            this.backBox.AutoSize = true;
            this.backBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBox.Location = new System.Drawing.Point(520, 372);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(115, 20);
            this.backBox.TabIndex = 24;
            this.backBox.Text = "Go Backwards";
            this.backBox.UseVisualStyleBackColor = true;
            // 
            // lollercoasterButton
            // 
            this.lollercoasterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollercoasterButton.Location = new System.Drawing.Point(518, 188);
            this.lollercoasterButton.Name = "lollercoasterButton";
            this.lollercoasterButton.Size = new System.Drawing.Size(128, 30);
            this.lollercoasterButton.TabIndex = 25;
            this.lollercoasterButton.Text = "Lollercoaster";
            this.lollercoasterButton.UseVisualStyleBackColor = true;
            this.lollercoasterButton.Click += new System.EventHandler(this.lollercoasterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 541);
            this.Controls.Add(this.lollercoasterButton);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCurrentFrame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.computerAngerButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.jJacksButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ASCII Animation";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentFrame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button computerAngerButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button jJacksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox backBox;
        private System.Windows.Forms.Button lollercoasterButton;
    }
}

