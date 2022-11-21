namespace FaceAuthentification
{
    partial class NewStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStudentForm));
            this.btnCapturer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlIdentiteEtudiant = new System.Windows.Forms.Panel();
            this.lblPrenomEtudiant = new System.Windows.Forms.Label();
            this.lblPostNomEtudiant = new System.Windows.Forms.Label();
            this.lblProfileEtudiant = new System.Windows.Forms.Label();
            this.lblNomEtudiant = new System.Windows.Forms.Label();
            this.txtPrenomEtudiant = new System.Windows.Forms.TextBox();
            this.txtPostNomEtudiant = new System.Windows.Forms.TextBox();
            this.txtNomEtudiant = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.pnlIdentiteEtudiant.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnCapturer.Location = new System.Drawing.Point(284, 238);
            this.btnCapturer.Name = "btnCapturer";
            this.btnCapturer.Size = new System.Drawing.Size(154, 30);
            this.btnCapturer.TabIndex = 12;
            this.btnCapturer.Text = "Valider";
            this.btnCapturer.UseVisualStyleBackColor = true;
            this.btnCapturer.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(56, 10);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 34);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Annuler";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pnlIdentiteEtudiant
            // 
            this.pnlIdentiteEtudiant.Controls.Add(this.btnCapturer);
            this.pnlIdentiteEtudiant.Controls.Add(this.picProfile);
            this.pnlIdentiteEtudiant.Controls.Add(this.lblPrenomEtudiant);
            this.pnlIdentiteEtudiant.Controls.Add(this.lblPostNomEtudiant);
            this.pnlIdentiteEtudiant.Controls.Add(this.lblProfileEtudiant);
            this.pnlIdentiteEtudiant.Controls.Add(this.lblNomEtudiant);
            this.pnlIdentiteEtudiant.Controls.Add(this.txtPrenomEtudiant);
            this.pnlIdentiteEtudiant.Controls.Add(this.txtPostNomEtudiant);
            this.pnlIdentiteEtudiant.Controls.Add(this.txtNomEtudiant);
            this.pnlIdentiteEtudiant.Location = new System.Drawing.Point(12, 12);
            this.pnlIdentiteEtudiant.Name = "pnlIdentiteEtudiant";
            this.pnlIdentiteEtudiant.Size = new System.Drawing.Size(473, 276);
            this.pnlIdentiteEtudiant.TabIndex = 13;
            // 
            // lblPrenomEtudiant
            // 
            this.lblPrenomEtudiant.AutoSize = true;
            this.lblPrenomEtudiant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomEtudiant.Location = new System.Drawing.Point(19, 216);
            this.lblPrenomEtudiant.Name = "lblPrenomEtudiant";
            this.lblPrenomEtudiant.Size = new System.Drawing.Size(152, 16);
            this.lblPrenomEtudiant.TabIndex = 14;
            this.lblPrenomEtudiant.Text = "Identifiant d\'Utilisateur";
            // 
            // lblPostNomEtudiant
            // 
            this.lblPostNomEtudiant.AutoSize = true;
            this.lblPostNomEtudiant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNomEtudiant.Location = new System.Drawing.Point(19, 115);
            this.lblPostNomEtudiant.Name = "lblPostNomEtudiant";
            this.lblPostNomEtudiant.Size = new System.Drawing.Size(152, 16);
            this.lblPostNomEtudiant.TabIndex = 15;
            this.lblPostNomEtudiant.Text = "Identifiant d\'Utilisateur";
            // 
            // lblProfileEtudiant
            // 
            this.lblProfileEtudiant.AutoSize = true;
            this.lblProfileEtudiant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEtudiant.Location = new System.Drawing.Point(296, 13);
            this.lblProfileEtudiant.Name = "lblProfileEtudiant";
            this.lblProfileEtudiant.Size = new System.Drawing.Size(131, 16);
            this.lblProfileEtudiant.TabIndex = 16;
            this.lblProfileEtudiant.Text = "Profile de l\'Etudiant";
            // 
            // lblNomEtudiant
            // 
            this.lblNomEtudiant.AutoSize = true;
            this.lblNomEtudiant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEtudiant.Location = new System.Drawing.Point(19, 12);
            this.lblNomEtudiant.Name = "lblNomEtudiant";
            this.lblNomEtudiant.Size = new System.Drawing.Size(152, 16);
            this.lblNomEtudiant.TabIndex = 16;
            this.lblNomEtudiant.Text = "Identifiant d\'Utilisateur";
            // 
            // txtPrenomEtudiant
            // 
            this.txtPrenomEtudiant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrenomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomEtudiant.Location = new System.Drawing.Point(22, 236);
            this.txtPrenomEtudiant.Name = "txtPrenomEtudiant";
            this.txtPrenomEtudiant.Size = new System.Drawing.Size(216, 29);
            this.txtPrenomEtudiant.TabIndex = 11;
            // 
            // txtPostNomEtudiant
            // 
            this.txtPostNomEtudiant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPostNomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostNomEtudiant.Location = new System.Drawing.Point(22, 134);
            this.txtPostNomEtudiant.Name = "txtPostNomEtudiant";
            this.txtPostNomEtudiant.Size = new System.Drawing.Size(216, 29);
            this.txtPostNomEtudiant.TabIndex = 12;
            // 
            // txtNomEtudiant
            // 
            this.txtNomEtudiant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEtudiant.Location = new System.Drawing.Point(22, 32);
            this.txtNomEtudiant.Name = "txtNomEtudiant";
            this.txtNomEtudiant.Size = new System.Drawing.Size(216, 29);
            this.txtNomEtudiant.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnQuitter);
            this.panel2.Location = new System.Drawing.Point(12, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 52);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Image = global::FaceAuthentification.Properties.Resources.capturer2;
            this.picProfile.Location = new System.Drawing.Point(271, 32);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(181, 200);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProfile.TabIndex = 17;
            this.picProfile.TabStop = false;
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlIdentiteEtudiant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewStudentForm";
            this.Text = "Nouvel Etudiant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewStudentForm_FormClosing);
            this.pnlIdentiteEtudiant.ResumeLayout(false);
            this.pnlIdentiteEtudiant.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapturer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pnlIdentiteEtudiant;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblPrenomEtudiant;
        private System.Windows.Forms.Label lblPostNomEtudiant;
        private System.Windows.Forms.Label lblNomEtudiant;
        private System.Windows.Forms.TextBox txtPrenomEtudiant;
        private System.Windows.Forms.TextBox txtPostNomEtudiant;
        private System.Windows.Forms.TextBox txtNomEtudiant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProfileEtudiant;
        private System.Windows.Forms.Button button1;
    }
}