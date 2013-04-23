namespace TreeTester
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
            this.cmdClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdFind = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblPostOrder = new System.Windows.Forms.Label();
            this.lblInOrder = new System.Windows.Forms.Label();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLevels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(486, 259);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(72, 24);
            this.cmdClear.TabIndex = 39;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 40);
            this.button1.TabIndex = 38;
            this.button1.Text = "E&xit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(386, 259);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(72, 24);
            this.cmdDelete.TabIndex = 37;
            this.cmdDelete.Text = "&Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(290, 259);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(72, 24);
            this.cmdFind.TabIndex = 36;
            this.cmdFind.Text = "&Find";
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Empty?:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Count:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpty
            // 
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(142, 171);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(48, 16);
            this.lblEmpty.TabIndex = 33;
            this.lblEmpty.Text = "yes";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(142, 147);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(48, 16);
            this.lblCount.TabIndex = 32;
            this.lblCount.Text = "0";
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(194, 259);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(72, 24);
            this.cmdInsert.TabIndex = 31;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Result:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(406, 211);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 24);
            this.lblResult.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Input:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(214, 211);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(96, 22);
            this.txtInput.TabIndex = 27;
            // 
            // lblPostOrder
            // 
            this.lblPostOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrder.Location = new System.Drawing.Point(142, 123);
            this.lblPostOrder.Name = "lblPostOrder";
            this.lblPostOrder.Size = new System.Drawing.Size(480, 16);
            this.lblPostOrder.TabIndex = 26;
            this.lblPostOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInOrder
            // 
            this.lblInOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrder.Location = new System.Drawing.Point(142, 99);
            this.lblInOrder.Name = "lblInOrder";
            this.lblInOrder.Size = new System.Drawing.Size(480, 16);
            this.lblInOrder.TabIndex = 25;
            this.lblInOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrder.Location = new System.Drawing.Point(142, 75);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(480, 16);
            this.lblPreOrder.TabIndex = 24;
            this.lblPreOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "PostOrder:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "InOrder:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "PreOrder:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "The Tree";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(98, 260);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 40;
            this.btnDraw.Text = "Draw Tree";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Levels:";
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.Location = new System.Drawing.Point(142, 197);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(13, 13);
            this.lblLevels.TabIndex = 42;
            this.lblLevels.Text = "0";
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 351);
            this.Controls.Add(this.lblLevels);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblPostOrder);
            this.Controls.Add(this.lblInOrder);
            this.Controls.Add(this.lblPreOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tree Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblPostOrder;
        private System.Windows.Forms.Label lblInOrder;
        private System.Windows.Forms.Label lblPreOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLevels;
    }
}

