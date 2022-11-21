namespace FaceAuthentification
{
    partial class SubjetctForm
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
            this.lblNewStudent = new System.Windows.Forms.Label();
            this.lblManageStudent = new System.Windows.Forms.Label();
            this.btnManageStudent = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNewStudent = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewStudent
            // 
            this.lblNewStudent.AutoEllipsis = true;
            this.lblNewStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStudent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewStudent.Location = new System.Drawing.Point(7, 107);
            this.lblNewStudent.Name = "lblNewStudent";
            this.lblNewStudent.Size = new System.Drawing.Size(161, 25);
            this.lblNewStudent.TabIndex = 17;
            this.lblNewStudent.Text = "Ajouter un Etudiant";
            this.lblNewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewStudent.Click += new System.EventHandler(this.lblNewStudent_Click);
            // 
            // lblManageStudent
            // 
            this.lblManageStudent.AutoEllipsis = true;
            this.lblManageStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageStudent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblManageStudent.Location = new System.Drawing.Point(216, 107);
            this.lblManageStudent.Name = "lblManageStudent";
            this.lblManageStudent.Size = new System.Drawing.Size(161, 42);
            this.lblManageStudent.TabIndex = 17;
            this.lblManageStudent.Text = "Gérer les étudiants existants";
            this.lblManageStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblManageStudent.Click += new System.EventHandler(this.lblManageStudent_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnManageStudent.Image = global::FaceAuthentification.Properties.Resources.manage;
            this.btnManageStudent.ImageActive = null;
            this.btnManageStudent.Location = new System.Drawing.Point(260, 29);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(72, 75);
            this.btnManageStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnManageStudent.TabIndex = 16;
            this.btnManageStudent.TabStop = false;
            this.btnManageStudent.Zoom = 10;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnNewStudent.Image = global::FaceAuthentification.Properties.Resources.newUser;
            this.btnNewStudent.ImageActive = null;
            this.btnNewStudent.Location = new System.Drawing.Point(51, 29);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(72, 75);
            this.btnNewStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewStudent.TabIndex = 16;
            this.btnNewStudent.TabStop = false;
            this.btnNewStudent.Zoom = 10;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // SubjetctForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 162);
            this.Controls.Add(this.lblManageStudent);
            this.Controls.Add(this.lblNewStudent);
            this.Controls.Add(this.btnManageStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SubjetctForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opérations sur les Sujets";
            ((System.ComponentModel.ISupportInitialize)(this.btnManageStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewStudent;
        private Bunifu.Framework.UI.BunifuImageButton btnNewStudent;
        private Bunifu.Framework.UI.BunifuImageButton btnManageStudent;
        private System.Windows.Forms.Label lblManageStudent;
    }
}