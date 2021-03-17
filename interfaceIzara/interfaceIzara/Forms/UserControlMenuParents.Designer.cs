
namespace interfaceIzara
{
    partial class UserControlMenuParents
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
            this.buttonParrainage = new System.Windows.Forms.Button();
            this.buttonConnexionParent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonParrainage
            // 
            this.buttonParrainage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonParrainage.FlatAppearance.BorderSize = 0;
            this.buttonParrainage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParrainage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParrainage.ForeColor = System.Drawing.Color.White;
            this.buttonParrainage.Location = new System.Drawing.Point(4, 83);
            this.buttonParrainage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonParrainage.Name = "buttonParrainage";
            this.buttonParrainage.Size = new System.Drawing.Size(240, 38);
            this.buttonParrainage.TabIndex = 7;
            this.buttonParrainage.Text = "Parrainer un professeur";
            this.buttonParrainage.UseVisualStyleBackColor = false;
            // 
            // buttonConnexionParent
            // 
            this.buttonConnexionParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonConnexionParent.FlatAppearance.BorderSize = 0;
            this.buttonConnexionParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnexionParent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexionParent.ForeColor = System.Drawing.Color.White;
            this.buttonConnexionParent.Location = new System.Drawing.Point(210, 4);
            this.buttonConnexionParent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnexionParent.Name = "buttonConnexionParent";
            this.buttonConnexionParent.Size = new System.Drawing.Size(189, 38);
            this.buttonConnexionParent.TabIndex = 6;
            this.buttonConnexionParent.Text = "Se connecter";
            this.buttonConnexionParent.UseVisualStyleBackColor = false;
            this.buttonConnexionParent.Click += new System.EventHandler(this.buttonConnexionParent_Click);
            // 
            // UserControlMenuParents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonParrainage);
            this.Controls.Add(this.buttonConnexionParent);
            this.Name = "UserControlMenuParents";
            this.Size = new System.Drawing.Size(420, 125);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonParrainage;
        private System.Windows.Forms.Button buttonConnexionParent;
    }
}
