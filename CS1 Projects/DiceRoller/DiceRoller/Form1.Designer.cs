namespace DiceRoller
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRolls = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Image = global::DiceRoller.Properties.Resources.die3s;
            this.btnRoll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRoll.Location = new System.Drawing.Point(55, 312);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(85, 87);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll\'em";
            this.btnRoll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.LightSalmon;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(258, 148);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(144, 267);
            this.lblResults.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 86);
            this.label3.TabIndex = 3;
            this.label3.Text = "How many times do you want to roll the dice?";
            // 
            // tbxRolls
            // 
            this.tbxRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRolls.Location = new System.Drawing.Point(229, 37);
            this.tbxRolls.Name = "tbxRolls";
            this.tbxRolls.Size = new System.Drawing.Size(88, 26);
            this.tbxRolls.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 488);
            this.Controls.Add(this.tbxRolls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRolls;
    }
}

