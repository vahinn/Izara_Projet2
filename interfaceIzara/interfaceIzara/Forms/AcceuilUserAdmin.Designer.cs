namespace interfaceIzara.Forms
{
    partial class AcceuilUserAdmin
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceuilUserAdmin));
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonAgenda = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonListEleve = new System.Windows.Forms.Button();
            this.buttonListParents = new System.Windows.Forms.Button();
            this.buttonListPro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMenuDash = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelDashBoard.SuspendLayout();
            this.panelMenuHorizontal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.BackColor = System.Drawing.Color.White;
            this.panelDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDashBoard.Controls.Add(this.panelChildForm);
            this.panelDashBoard.Controls.Add(this.panelMenuHorizontal);
            this.panelDashBoard.Controls.Add(this.panelMenuVertical);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(976, 630);
            this.panelDashBoard.TabIndex = 0;
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.Controls.Add(this.buttonQuitter);
            this.panelMenuHorizontal.Controls.Add(this.buttonAgenda);
            this.panelMenuHorizontal.Controls.Add(this.buttonDashboard);
            this.panelMenuHorizontal.Controls.Add(this.buttonListEleve);
            this.panelMenuHorizontal.Controls.Add(this.buttonListParents);
            this.panelMenuHorizontal.Controls.Add(this.buttonListPro);
            this.panelMenuHorizontal.Controls.Add(this.panel1);
            this.panelMenuHorizontal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, 44);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(197, 586);
            this.panelMenuHorizontal.TabIndex = 1;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonQuitter.FlatAppearance.BorderSize = 0;
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonQuitter.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuitter.Image")));
            this.buttonQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuitter.Location = new System.Drawing.Point(0, 546);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(197, 40);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // buttonAgenda
            // 
            this.buttonAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgenda.FlatAppearance.BorderSize = 0;
            this.buttonAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgenda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonAgenda.Location = new System.Drawing.Point(0, 240);
            this.buttonAgenda.Name = "buttonAgenda";
            this.buttonAgenda.Size = new System.Drawing.Size(197, 40);
            this.buttonAgenda.TabIndex = 5;
            this.buttonAgenda.Text = "Agenda";
            this.buttonAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgenda.UseVisualStyleBackColor = true;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonDashboard.Location = new System.Drawing.Point(0, 200);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(197, 40);
            this.buttonDashboard.TabIndex = 4;
            this.buttonDashboard.Text = "Tableau de bord";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // buttonListEleve
            // 
            this.buttonListEleve.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListEleve.FlatAppearance.BorderSize = 0;
            this.buttonListEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListEleve.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListEleve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonListEleve.Location = new System.Drawing.Point(0, 160);
            this.buttonListEleve.Name = "buttonListEleve";
            this.buttonListEleve.Size = new System.Drawing.Size(197, 40);
            this.buttonListEleve.TabIndex = 3;
            this.buttonListEleve.Text = "Liste Elèves";
            this.buttonListEleve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListEleve.UseVisualStyleBackColor = true;
            // 
            // buttonListParents
            // 
            this.buttonListParents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListParents.FlatAppearance.BorderSize = 0;
            this.buttonListParents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListParents.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListParents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonListParents.Location = new System.Drawing.Point(0, 120);
            this.buttonListParents.Name = "buttonListParents";
            this.buttonListParents.Size = new System.Drawing.Size(197, 40);
            this.buttonListParents.TabIndex = 2;
            this.buttonListParents.Text = "Liste Parents";
            this.buttonListParents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListParents.UseVisualStyleBackColor = true;
            // 
            // buttonListPro
            // 
            this.buttonListPro.BackColor = System.Drawing.Color.White;
            this.buttonListPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListPro.FlatAppearance.BorderSize = 0;
            this.buttonListPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListPro.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonListPro.Location = new System.Drawing.Point(0, 80);
            this.buttonListPro.Name = "buttonListPro";
            this.buttonListPro.Size = new System.Drawing.Size(197, 40);
            this.buttonListPro.TabIndex = 1;
            this.buttonListPro.Text = "Liste Professeurs";
            this.buttonListPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListPro.UseVisualStyleBackColor = false;
            this.buttonListPro.Click += new System.EventHandler(this.buttonListPro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.panelMenuVertical.Controls.Add(this.button2);
            this.panelMenuVertical.Controls.Add(this.button1);
            this.panelMenuVertical.Controls.Add(this.buttonMenuDash);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(976, 44);
            this.panelMenuVertical.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(835, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonMenuDash
            // 
            this.buttonMenuDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuDash.BackgroundImage")));
            this.buttonMenuDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMenuDash.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMenuDash.FlatAppearance.BorderSize = 0;
            this.buttonMenuDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuDash.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuDash.Name = "buttonMenuDash";
            this.buttonMenuDash.Size = new System.Drawing.Size(75, 44);
            this.buttonMenuDash.TabIndex = 0;
            this.buttonMenuDash.UseVisualStyleBackColor = true;
            this.buttonMenuDash.Click += new System.EventHandler(this.buttonMenuDash_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(776, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 44);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(197, 44);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(779, 586);
            this.panelChildForm.TabIndex = 2;
            // 
            // AcceuilUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDashBoard);
            this.Name = "AcceuilUserAdmin";
            this.Size = new System.Drawing.Size(976, 630);
            this.panelDashBoard.ResumeLayout(false);
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.Button buttonListPro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonAgenda;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonListEleve;
        private System.Windows.Forms.Button buttonListParents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMenuDash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelChildForm;
    }
}
