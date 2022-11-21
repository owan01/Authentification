namespace FaceAuthentification
{
    partial class LiveAuthForm
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapture.Location = new System.Drawing.Point(0, 0);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(800, 450);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // LiveAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCapture);
            this.Name = "LiveAuthForm";
            this.Text = "LiveAuthForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LiveAuthForm_FormClosing);
            this.Load += new System.EventHandler(this.LiveAuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
    }
}