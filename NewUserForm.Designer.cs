
namespace FaceAuthentification
{
    partial class NewUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.GboxConnectionData = new System.Windows.Forms.GroupBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumNat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtPostNom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.GboxIdentite = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GboxConnectionData.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.GboxIdentite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(154, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 5);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "CREATION D\'UN OPERATEUR";
            // 
            // GboxConnectionData
            // 
            this.GboxConnectionData.Controls.Add(this.pnlLogin);
            this.GboxConnectionData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GboxConnectionData.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxConnectionData.Location = new System.Drawing.Point(324, 59);
            this.GboxConnectionData.Name = "GboxConnectionData";
            this.GboxConnectionData.Size = new System.Drawing.Size(245, 298);
            this.GboxConnectionData.TabIndex = 8;
            this.GboxConnectionData.TabStop = false;
            this.GboxConnectionData.Text = "Données de connexion";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnValider);
            this.pnlLogin.Controls.Add(this.btnQuitter);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtCode);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(3, 24);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(239, 271);
            this.pnlLogin.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Black;
            this.btnValider.Location = new System.Drawing.Point(126, 220);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(105, 34);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(15, 220);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 34);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Annuler";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code d\'Autorisation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identifiant d\'Utilisateur";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(15, 167);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(216, 29);
            this.txtCode.TabIndex = 2;
            this.txtCode.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(15, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 29);
            this.txtPassword.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(15, 37);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(216, 29);
            this.txtLogin.TabIndex = 0;
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.label7);
            this.pnlID.Controls.Add(this.txtNumNat);
            this.pnlID.Controls.Add(this.label6);
            this.pnlID.Controls.Add(this.label5);
            this.pnlID.Controls.Add(this.label4);
            this.pnlID.Controls.Add(this.txtPrenom);
            this.pnlID.Controls.Add(this.txtPostNom);
            this.pnlID.Controls.Add(this.txtNom);
            this.pnlID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlID.Location = new System.Drawing.Point(3, 24);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(239, 271);
            this.pnlID.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Numéro National";
            // 
            // txtNumNat
            // 
            this.txtNumNat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNat.Location = new System.Drawing.Point(13, 230);
            this.txtNumNat.Name = "txtNumNat";
            this.txtNumNat.Size = new System.Drawing.Size(216, 29);
            this.txtNumNat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Post-Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(13, 167);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(216, 29);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtPostNom
            // 
            this.txtPostNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPostNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostNom.Location = new System.Drawing.Point(13, 101);
            this.txtPostNom.Name = "txtPostNom";
            this.txtPostNom.Size = new System.Drawing.Size(216, 29);
            this.txtPostNom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(13, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(216, 29);
            this.txtNom.TabIndex = 0;
            // 
            // GboxIdentite
            // 
            this.GboxIdentite.Controls.Add(this.pnlID);
            this.GboxIdentite.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxIdentite.Location = new System.Drawing.Point(40, 59);
            this.GboxIdentite.Name = "GboxIdentite";
            this.GboxIdentite.Size = new System.Drawing.Size(245, 298);
            this.GboxIdentite.TabIndex = 7;
            this.GboxIdentite.TabStop = false;
            this.GboxIdentite.Text = "Identité de l\'Utilisateur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FaceAuthentification.Properties.Resources.le_grand_ingenieur;
            this.pictureBox1.Location = new System.Drawing.Point(99, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(608, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GboxConnectionData);
            this.Controls.Add(this.GboxIdentite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.GboxConnectionData.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.GboxIdentite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GboxConnectionData;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumNat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtPostNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox GboxIdentite;
    }
}