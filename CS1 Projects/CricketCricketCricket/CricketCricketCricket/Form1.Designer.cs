namespace CricketCricketCricket
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chirpNumber = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.tempButton = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(304, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 171);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "First, input the number of chirps heard:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Now input the number of seconds in which you heard the chirps.";
            // 
            // chirpNumber
            // 
            this.chirpNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chirpNumber.Location = new System.Drawing.Point(189, 222);
            this.chirpNumber.Name = "chirpNumber";
            this.chirpNumber.Size = new System.Drawing.Size(100, 22);
            this.chirpNumber.TabIndex = 1;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(189, 303);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 22);
            this.time.TabIndex = 2;
            // 
            // tempButton
            // 
            this.tempButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempButton.Location = new System.Drawing.Point(44, 358);
            this.tempButton.Name = "tempButton";
            this.tempButton.Size = new System.Drawing.Size(245, 33);
            this.tempButton.TabIndex = 3;
            this.tempButton.Text = "Find the temperature!";
            this.tempButton.UseVisualStyleBackColor = true;
            this.tempButton.Click += new System.EventHandler(this.tempButton_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.Gold;
            this.answer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(44, 398);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(245, 50);
            this.answer.TabIndex = 5;
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(304, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.tempButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(492, 466);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.tempButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.chirpNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Wonderful Magical Cricket Calculator!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chirpNumber;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button tempButton;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button exitButton;
    }
}

