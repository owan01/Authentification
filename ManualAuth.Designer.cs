namespace FaceAuthentification
{
    partial class ManualAuth
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
            this.btnCapturer = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapturer
            // 
            this.btnCapturer.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCapturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCapturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturer.ForeColor = System.Drawing.Color.Black;
            this.btnCapturer.Location = new System.Drawing.Point(48, 269);
            this.btnCapturer.Name = "btnCapturer";
            this.btnCapturer.Size = new System.Drawing.Size(216, 30);
            this.btnCapturer.TabIndex = 18;
            this.btnCapturer.Text = "Choisir un fichier";
            this.btnCapturer.UseVisualStyleBackColor = true;
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProfile.Image = global::FaceAuthentification.Properties.Resources.capturer2;
            this.picProfile.Location = new System.Drawing.Point(0, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(313, 347);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProfile.TabIndex = 19;
            this.picProfile.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(48, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Authentifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManualAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCapturer);
            this.Controls.Add(this.picProfile);
            this.Name = "ManualAuth";
            this.Text = "ManualAuth";
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapturer;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button button1;
    }
}