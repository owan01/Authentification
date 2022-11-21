
namespace FaceAuthentification
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espaceAdministrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guideDutilisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportDeBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveAuthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authentificationLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authentificationManuelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pleinÉcranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonctionnementEnArrièrePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pnlAcceuil = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecords = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnManualAuth = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLiveAuth = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuPrincipal.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.pnlAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManualAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLiveAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.liveAuthToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(974, 29);
            this.menuPrincipal.TabIndex = 14;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espaceAdministrateurToolStripMenuItem,
            this.toolStripSeparator1,
            this.guideDutilisationToolStripMenuItem,
            this.rapportDeBugToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // espaceAdministrateurToolStripMenuItem
            // 
            this.espaceAdministrateurToolStripMenuItem.Name = "espaceAdministrateurToolStripMenuItem";
            this.espaceAdministrateurToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.espaceAdministrateurToolStripMenuItem.Text = "Espace Administrateur";
            this.espaceAdministrateurToolStripMenuItem.Click += new System.EventHandler(this.espaceAdministrateurToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // guideDutilisationToolStripMenuItem
            // 
            this.guideDutilisationToolStripMenuItem.Name = "guideDutilisationToolStripMenuItem";
            this.guideDutilisationToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.guideDutilisationToolStripMenuItem.Text = "Guide d\'utilisation";
            this.guideDutilisationToolStripMenuItem.Click += new System.EventHandler(this.guideDutilisationToolStripMenuItem_Click);
            // 
            // rapportDeBugToolStripMenuItem
            // 
            this.rapportDeBugToolStripMenuItem.Name = "rapportDeBugToolStripMenuItem";
            this.rapportDeBugToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.rapportDeBugToolStripMenuItem.Text = "Rapport de bug";
            this.rapportDeBugToolStripMenuItem.Click += new System.EventHandler(this.rapportDeBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(248, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.quitterToolStripMenuItem.Text = "Quitter ";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // liveAuthToolStripMenuItem
            // 
            this.liveAuthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authentificationLiveToolStripMenuItem,
            this.authentificationManuelleToolStripMenuItem,
            this.toolStripSeparator3,
            this.pleinÉcranToolStripMenuItem,
            this.fonctionnementEnArrièrePlanToolStripMenuItem});
            this.liveAuthToolStripMenuItem.Name = "liveAuthToolStripMenuItem";
            this.liveAuthToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.liveAuthToolStripMenuItem.Text = "Mode";
            // 
            // authentificationLiveToolStripMenuItem
            // 
            this.authentificationLiveToolStripMenuItem.Name = "authentificationLiveToolStripMenuItem";
            this.authentificationLiveToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.authentificationLiveToolStripMenuItem.Text = "Authentification Live";
            // 
            // authentificationManuelleToolStripMenuItem
            // 
            this.authentificationManuelleToolStripMenuItem.Name = "authentificationManuelleToolStripMenuItem";
            this.authentificationManuelleToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.authentificationManuelleToolStripMenuItem.Text = "Authentification Manuelle";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(318, 6);
            // 
            // pleinÉcranToolStripMenuItem
            // 
            this.pleinÉcranToolStripMenuItem.Name = "pleinÉcranToolStripMenuItem";
            this.pleinÉcranToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.pleinÉcranToolStripMenuItem.Text = "Plein écran";
            // 
            // fonctionnementEnArrièrePlanToolStripMenuItem
            // 
            this.fonctionnementEnArrièrePlanToolStripMenuItem.Name = "fonctionnementEnArrièrePlanToolStripMenuItem";
            this.fonctionnementEnArrièrePlanToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.fonctionnementEnArrièrePlanToolStripMenuItem.Text = "Fonctionnement en arrière plan";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pnlAcceuil);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(974, 444);
            this.MainPanel.TabIndex = 14;
            // 
            // pnlAcceuil
            // 
            this.pnlAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.pnlAcceuil.Controls.Add(this.label3);
            this.pnlAcceuil.Controls.Add(this.label1);
            this.pnlAcceuil.Controls.Add(this.label2);
            this.pnlAcceuil.Controls.Add(this.btnRecords);
            this.pnlAcceuil.Controls.Add(this.btnManualAuth);
            this.pnlAcceuil.Controls.Add(this.btnLiveAuth);
            this.pnlAcceuil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcceuil.Location = new System.Drawing.Point(0, 0);
            this.pnlAcceuil.Name = "pnlAcceuil";
            this.pnlAcceuil.Size = new System.Drawing.Size(974, 444);
            this.pnlAcceuil.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(689, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 66);
            this.label3.TabIndex = 11;
            this.label3.Text = "HISTORIQUES DES RESULTATS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(362, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 62);
            this.label1.TabIndex = 12;
            this.label1.Text = "AUTHENTIFICATION MANUELLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(28, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 62);
            this.label2.TabIndex = 13;
            this.label2.Text = "AUTHENTIFICATION TEMPS REEL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnRecords.Image = global::FaceAuthentification.Properties.Resources.history1;
            this.btnRecords.ImageActive = null;
            this.btnRecords.Location = new System.Drawing.Point(728, 112);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(139, 139);
            this.btnRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecords.TabIndex = 10;
            this.btnRecords.TabStop = false;
            this.btnRecords.Zoom = 10;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnManualAuth
            // 
            this.btnManualAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManualAuth.BackColor = System.Drawing.Color.Transparent;
            this.btnManualAuth.Image = ((System.Drawing.Image)(resources.GetObject("btnManualAuth.Image")));
            this.btnManualAuth.ImageActive = null;
            this.btnManualAuth.Location = new System.Drawing.Point(413, 112);
            this.btnManualAuth.Name = "btnManualAuth";
            this.btnManualAuth.Size = new System.Drawing.Size(139, 139);
            this.btnManualAuth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnManualAuth.TabIndex = 9;
            this.btnManualAuth.TabStop = false;
            this.btnManualAuth.Zoom = 10;
            this.btnManualAuth.Click += new System.EventHandler(this.btnManualAuth_Click);
            // 
            // btnLiveAuth
            // 
            this.btnLiveAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLiveAuth.BackColor = System.Drawing.Color.Transparent;
            this.btnLiveAuth.Image = ((System.Drawing.Image)(resources.GetObject("btnLiveAuth.Image")));
            this.btnLiveAuth.ImageActive = null;
            this.btnLiveAuth.Location = new System.Drawing.Point(88, 112);
            this.btnLiveAuth.Name = "btnLiveAuth";
            this.btnLiveAuth.Size = new System.Drawing.Size(139, 139);
            this.btnLiveAuth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLiveAuth.TabIndex = 8;
            this.btnLiveAuth.TabStop = false;
            this.btnLiveAuth.Zoom = 10;
            this.btnLiveAuth.Click += new System.EventHandler(this.btnLiveAuth_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 473);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceAUTH";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.pnlAcceuil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManualAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLiveAuth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espaceAdministrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem guideDutilisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportDeBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem liveAuthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authentificationLiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authentificationManuelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem pleinÉcranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonctionnementEnArrièrePlanToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAcceuil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnRecords;
        private Bunifu.Framework.UI.BunifuImageButton btnManualAuth;
        private Bunifu.Framework.UI.BunifuImageButton btnLiveAuth;
    }
}