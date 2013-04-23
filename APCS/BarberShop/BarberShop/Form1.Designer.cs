namespace BarberShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxCust = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simEndtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.seedText = new System.Windows.Forms.TextBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.chkChair3 = new System.Windows.Forms.CheckBox();
            this.chkChair1 = new System.Windows.Forms.CheckBox();
            this.chkChair2 = new System.Windows.Forms.CheckBox();
            this.lblChair3 = new System.Windows.Forms.Label();
            this.lblChair2 = new System.Windows.Forms.Label();
            this.lblChair1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(29, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(29, 80);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(103, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Simulation";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(29, 133);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 32);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Simulation";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Max Customers per 5-Minute Interval";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxCust
            // 
            this.txtMaxCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCust.Location = new System.Drawing.Point(128, 201);
            this.txtMaxCust.Name = "txtMaxCust";
            this.txtMaxCust.Size = new System.Drawing.Size(32, 26);
            this.txtMaxCust.TabIndex = 15;
            this.txtMaxCust.Text = "5";
            this.txtMaxCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Simulation duration";
            // 
            // simEndtext
            // 
            this.simEndtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simEndtext.Location = new System.Drawing.Point(126, 250);
            this.simEndtext.Name = "simEndtext";
            this.simEndtext.Size = new System.Drawing.Size(51, 26);
            this.simEndtext.TabIndex = 17;
            this.simEndtext.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Random seed value";
            // 
            // seedText
            // 
            this.seedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedText.Location = new System.Drawing.Point(126, 294);
            this.seedText.Name = "seedText";
            this.seedText.Size = new System.Drawing.Size(53, 26);
            this.seedText.TabIndex = 19;
            // 
            // lblStats
            // 
            this.lblStats.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(432, 33);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(200, 136);
            this.lblStats.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Simulation Stats";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "The Queue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQueue
            // 
            this.txtQueue.AcceptsReturn = true;
            this.txtQueue.Location = new System.Drawing.Point(192, 34);
            this.txtQueue.Multiline = true;
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.ReadOnly = true;
            this.txtQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueue.Size = new System.Drawing.Size(214, 216);
            this.txtQueue.TabIndex = 20;
            // 
            // chkChair3
            // 
            this.chkChair3.Location = new System.Drawing.Point(518, 350);
            this.chkChair3.Name = "chkChair3";
            this.chkChair3.Size = new System.Drawing.Size(104, 24);
            this.chkChair3.TabIndex = 26;
            // 
            // chkChair1
            // 
            this.chkChair1.Location = new System.Drawing.Point(94, 350);
            this.chkChair1.Name = "chkChair1";
            this.chkChair1.Size = new System.Drawing.Size(104, 24);
            this.chkChair1.TabIndex = 24;
            // 
            // chkChair2
            // 
            this.chkChair2.Location = new System.Drawing.Point(302, 350);
            this.chkChair2.Name = "chkChair2";
            this.chkChair2.Size = new System.Drawing.Size(104, 24);
            this.chkChair2.TabIndex = 25;
            // 
            // lblChair3
            // 
            this.lblChair3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChair3.ForeColor = System.Drawing.SystemColors.Info;
            this.lblChair3.Image = ((System.Drawing.Image)(resources.GetObject("lblChair3.Image")));
            this.lblChair3.Location = new System.Drawing.Point(446, 382);
            this.lblChair3.Name = "lblChair3";
            this.lblChair3.Size = new System.Drawing.Size(152, 192);
            this.lblChair3.TabIndex = 30;
            this.lblChair3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChair2
            // 
            this.lblChair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChair2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChair2.Image = ((System.Drawing.Image)(resources.GetObject("lblChair2.Image")));
            this.lblChair2.Location = new System.Drawing.Point(238, 382);
            this.lblChair2.Name = "lblChair2";
            this.lblChair2.Size = new System.Drawing.Size(152, 192);
            this.lblChair2.TabIndex = 29;
            this.lblChair2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChair1
            // 
            this.lblChair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChair1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChair1.Image = ((System.Drawing.Image)(resources.GetObject("lblChair1.Image")));
            this.lblChair1.Location = new System.Drawing.Point(27, 382);
            this.lblChair1.Name = "lblChair1";
            this.lblChair1.Size = new System.Drawing.Size(152, 192);
            this.lblChair1.TabIndex = 28;
            this.lblChair1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "The Chairs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 606);
            this.Controls.Add(this.chkChair3);
            this.Controls.Add(this.chkChair1);
            this.Controls.Add(this.chkChair2);
            this.Controls.Add(this.lblChair3);
            this.Controls.Add(this.lblChair2);
            this.Controls.Add(this.lblChair1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQueue);
            this.Controls.Add(this.seedText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.simEndtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaxCust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Barber Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxCust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox simEndtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox seedText;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.CheckBox chkChair3;
        private System.Windows.Forms.CheckBox chkChair1;
        private System.Windows.Forms.CheckBox chkChair2;
        private System.Windows.Forms.Label lblChair3;
        private System.Windows.Forms.Label lblChair2;
        private System.Windows.Forms.Label lblChair1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

