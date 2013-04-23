namespace Paintball
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
            this.btn1pa = new System.Windows.Forms.Button();
            this.btn2ps = new System.Windows.Forms.Button();
            this.btn1pe = new System.Windows.Forms.Button();
            this.btn2pl = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1pa
            // 
            this.btn1pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1pa.Location = new System.Drawing.Point(12, 26);
            this.btn1pa.Name = "btn1pa";
            this.btn1pa.Size = new System.Drawing.Size(139, 58);
            this.btn1pa.TabIndex = 0;
            this.btn1pa.Text = "1-Player (Amoeba)";
            this.btn1pa.UseVisualStyleBackColor = true;
            this.btn1pa.Click += new System.EventHandler(this.btn1pa_Click);
            this.btn1pa.MouseEnter += new System.EventHandler(this.btn1pa_MouseEnter);
            // 
            // btn2ps
            // 
            this.btn2ps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2ps.Location = new System.Drawing.Point(157, 26);
            this.btn2ps.Name = "btn2ps";
            this.btn2ps.Size = new System.Drawing.Size(139, 58);
            this.btn2ps.TabIndex = 1;
            this.btn2ps.Text = "2-Player (Short)";
            this.btn2ps.UseVisualStyleBackColor = true;
            this.btn2ps.Click += new System.EventHandler(this.btn2ps_Click);
            this.btn2ps.MouseEnter += new System.EventHandler(this.btn2ps_MouseEnter);
            // 
            // btn1pe
            // 
            this.btn1pe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1pe.Location = new System.Drawing.Point(12, 107);
            this.btn1pe.Name = "btn1pe";
            this.btn1pe.Size = new System.Drawing.Size(139, 58);
            this.btn1pe.TabIndex = 2;
            this.btn1pe.Text = "1-Player (Endless)";
            this.btn1pe.UseVisualStyleBackColor = true;
            this.btn1pe.Click += new System.EventHandler(this.btn1pe_Click);
            this.btn1pe.MouseEnter += new System.EventHandler(this.btn1pe_MouseEnter);
            // 
            // btn2pl
            // 
            this.btn2pl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2pl.Location = new System.Drawing.Point(157, 107);
            this.btn2pl.Name = "btn2pl";
            this.btn2pl.Size = new System.Drawing.Size(139, 58);
            this.btn2pl.TabIndex = 3;
            this.btn2pl.Text = "2-Player (Long)";
            this.btn2pl.UseVisualStyleBackColor = true;
            this.btn2pl.Click += new System.EventHandler(this.btn2pl_Click);
            this.btn2pl.MouseEnter += new System.EventHandler(this.btn2pl_MouseEnter);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Cyan;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 179);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(277, 88);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 276);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btn2pl);
            this.Controls.Add(this.btn1pe);
            this.Controls.Add(this.btn2ps);
            this.Controls.Add(this.btn1pa);
            this.Name = "Form1";
            this.Text = "Paintball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1pa;
        private System.Windows.Forms.Button btn2ps;
        private System.Windows.Forms.Button btn1pe;
        private System.Windows.Forms.Button btn2pl;
        private System.Windows.Forms.Label lblInfo;

    }
}

