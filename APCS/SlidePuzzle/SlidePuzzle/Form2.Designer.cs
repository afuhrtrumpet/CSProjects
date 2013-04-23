namespace SlidePuzzle
{
    partial class Settings
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
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(12, 12);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(129, 47);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "Start Game (Default)";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(147, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(125, 47);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload Your Own Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // imageDialog
            // 
            this.imageDialog.Filter = "JPG Images|*jpg|PNG Images|*.png|GIF Images|*.gif|BMP Images|*.bmp\"";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDefault);
            this.Name = "Settings";
            this.Text = "Slide Puzzle Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog imageDialog;
    }
}