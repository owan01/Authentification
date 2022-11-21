namespace FaceAuthentification
{
    partial class UserManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOerationEnreg = new System.Windows.Forms.Panel();
            this.pnlGridViewer = new System.Windows.Forms.Panel();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlOerationEnreg.SuspendLayout();
            this.pnlGridViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.pnlDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOerationEnreg
            // 
            this.pnlOerationEnreg.Controls.Add(this.pnlGridViewer);
            this.pnlOerationEnreg.Controls.Add(this.pnlDataGridView);
            this.pnlOerationEnreg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOerationEnreg.Location = new System.Drawing.Point(0, 0);
            this.pnlOerationEnreg.Name = "pnlOerationEnreg";
            this.pnlOerationEnreg.Size = new System.Drawing.Size(947, 496);
            this.pnlOerationEnreg.TabIndex = 16;
            // 
            // pnlGridViewer
            // 
            this.pnlGridViewer.Controls.Add(this.userGridView);
            this.pnlGridViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridViewer.Location = new System.Drawing.Point(0, 50);
            this.pnlGridViewer.Name = "pnlGridViewer";
            this.pnlGridViewer.Size = new System.Drawing.Size(947, 446);
            this.pnlGridViewer.TabIndex = 20;
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AllowUserToResizeColumns = false;
            this.userGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.userGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridView.EnableHeadersVisualStyles = false;
            this.userGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.userGridView.Location = new System.Drawing.Point(0, 0);
            this.userGridView.MultiSelect = false;
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.userGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGridView.ShowEditingIcon = false;
            this.userGridView.Size = new System.Drawing.Size(947, 446);
            this.userGridView.TabIndex = 0;
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Controls.Add(this.btnEditUser);
            this.pnlDataGridView.Controls.Add(this.btnDeleteUser);
            this.pnlDataGridView.Controls.Add(this.btnSearchUser);
            this.pnlDataGridView.Controls.Add(this.searchBox);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(947, 50);
            this.pnlDataGridView.TabIndex = 19;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditUser.BackColor = System.Drawing.Color.Transparent;
            this.btnEditUser.Enabled = false;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(536, 9);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(186, 35);
            this.btnEditUser.TabIndex = 18;
            this.btnEditUser.Text = "Modifier";
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(748, 9);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(186, 35);
            this.btnDeleteUser.TabIndex = 18;
            this.btnDeleteUser.Text = "Supprimer";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(324, 9);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(186, 35);
            this.btnSearchUser.TabIndex = 18;
            this.btnSearchUser.Text = "Rechercher";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.HintForeColor = System.Drawing.Color.Gray;
            this.searchBox.HintText = "Entrer le Texte à rechercher";
            this.searchBox.isPassword = false;
            this.searchBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchBox.LineThickness = 4;
            this.searchBox.Location = new System.Drawing.Point(8, 7);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(296, 37);
            this.searchBox.TabIndex = 17;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 496);
            this.Controls.Add(this.pnlOerationEnreg);
            this.Name = "UserManager";
            this.Text = "UserManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManager_FormClosing);
            this.Load += new System.EventHandler(this.UserManager_Load);
            this.pnlOerationEnreg.ResumeLayout(false);
            this.pnlGridViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        public System.Windows.Forms.Button btnSearchUser;
        public Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        public System.Windows.Forms.Panel pnlOerationEnreg;
        public System.Windows.Forms.Panel pnlGridViewer;
    }
}