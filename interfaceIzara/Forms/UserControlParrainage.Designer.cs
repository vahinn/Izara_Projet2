
namespace interfaceIzara
{
    partial class UserControlParrainage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlParrainage));
            this.labelParrainage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnvoiCandidature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelParrainage
            // 
            this.labelParrainage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelParrainage.AutoSize = true;
            this.labelParrainage.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParrainage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.labelParrainage.Location = new System.Drawing.Point(328, 62);
            this.labelParrainage.Name = "labelParrainage";
            this.labelParrainage.Size = new System.Drawing.Size(248, 28);
            this.labelParrainage.TabIndex = 0;
            this.labelParrainage.Text = "Lettre de Parrainage";
            this.labelParrainage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 165);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonEnvoiCandidature
            // 
            this.buttonEnvoiCandidature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnvoiCandidature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.buttonEnvoiCandidature.FlatAppearance.BorderSize = 0;
            this.buttonEnvoiCandidature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnvoiCandidature.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnvoiCandidature.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnvoiCandidature.Image")));
            this.buttonEnvoiCandidature.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEnvoiCandidature.Location = new System.Drawing.Point(333, 381);
            this.buttonEnvoiCandidature.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEnvoiCandidature.Name = "buttonEnvoiCandidature";
            this.buttonEnvoiCandidature.Size = new System.Drawing.Size(243, 44);
            this.buttonEnvoiCandidature.TabIndex = 88;
            this.buttonEnvoiCandidature.Text = "Envoyer";
            this.buttonEnvoiCandidature.UseVisualStyleBackColor = false;
            // 
            // UserControlParrainage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonEnvoiCandidature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelParrainage);
            this.Name = "UserControlParrainage";
            this.Size = new System.Drawing.Size(850, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParrainage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnvoiCandidature;
    }
}
