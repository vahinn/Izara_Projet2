
namespace interfaceIzara
{
    partial class UserControlMenuProf
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
            this.buttonConnexionProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnexionProf
            // 
            this.buttonConnexionProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buttonConnexionProf.FlatAppearance.BorderSize = 0;
            this.buttonConnexionProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnexionProf.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexionProf.ForeColor = System.Drawing.Color.White;
            this.buttonConnexionProf.Location = new System.Drawing.Point(218, 14);
            this.buttonConnexionProf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnexionProf.Name = "buttonConnexionProf";
            this.buttonConnexionProf.Size = new System.Drawing.Size(189, 38);
            this.buttonConnexionProf.TabIndex = 6;
            this.buttonConnexionProf.Text = "Se connecter";
            this.buttonConnexionProf.UseVisualStyleBackColor = false;
            this.buttonConnexionProf.Click += new System.EventHandler(this.buttonConnexionProf_Click);
            // 
            // UserControlMenuProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonConnexionProf);
            this.Name = "UserControlMenuProf";
            this.Size = new System.Drawing.Size(420, 125);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnexionProf;
    }
}
