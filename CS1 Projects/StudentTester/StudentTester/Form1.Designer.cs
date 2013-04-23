namespace StudentTester
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instantiateButton = new System.Windows.Forms.Button();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newScoreBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(183, 41);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(179, 29);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name";
            // 
            // instantiateButton
            // 
            this.instantiateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instantiateButton.Location = new System.Drawing.Point(47, 97);
            this.instantiateButton.Name = "instantiateButton";
            this.instantiateButton.Size = new System.Drawing.Size(126, 98);
            this.instantiateButton.TabIndex = 2;
            this.instantiateButton.Text = "Instantiate (new) the student";
            this.instantiateButton.UseVisualStyleBackColor = true;
            this.instantiateButton.Click += new System.EventHandler(this.instantiateButton_Click);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(242, 97);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(120, 98);
            this.studentNameLabel.TabIndex = 3;
            this.studentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Quiz Score:";
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLabel.Location = new System.Drawing.Point(242, 228);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(120, 23);
            this.totalScoreLabel.TabIndex = 5;
            this.totalScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average Quiz Score:";
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.averageScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageScoreLabel.Location = new System.Drawing.Point(243, 276);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(119, 24);
            this.averageScoreLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Score:";
            // 
            // newScoreBox
            // 
            this.newScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScoreBox.Location = new System.Drawing.Point(183, 321);
            this.newScoreBox.Name = "newScoreBox";
            this.newScoreBox.Size = new System.Drawing.Size(100, 29);
            this.newScoreBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(311, 316);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 63);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Score";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.instantiateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 381);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newScoreBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.instantiateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Student Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button instantiateButton;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newScoreBox;
        private System.Windows.Forms.Button addButton;
    }
}

