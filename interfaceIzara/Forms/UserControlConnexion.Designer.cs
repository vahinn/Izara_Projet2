
namespace interfaceIzara
{
    partial class UserControlConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlConnexion));
            this.TextBoxConnexionEmail = new System.Windows.Forms.TextBox();
            this.TextBoxConnexionPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonMdpOubli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxConnexionEmail
            // 
            this.TextBoxConnexionEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxConnexionEmail.Location = new System.Drawing.Point(314, 129);
            this.TextBoxConnexionEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxConnexionEmail.Name = "TextBoxConnexionEmail";
            this.TextBoxConnexionEmail.Size = new System.Drawing.Size(482, 22);
            this.TextBoxConnexionEmail.TabIndex = 0;
            // 
            // TextBoxConnexionPassword
            // 
            this.TextBoxConnexionPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxConnexionPassword.Location = new System.Drawing.Point(314, 265);
            this.TextBoxConnexionPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxConnexionPassword.Name = "TextBoxConnexionPassword";
            this.TextBoxConnexionPassword.PasswordChar = '*';
            this.TextBoxConnexionPassword.Size = new System.Drawing.Size(482, 22);
            this.TextBoxConnexionPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(314, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "   E-mail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(314, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "     Mot de passe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.buttonConnexion.FlatAppearance.BorderSize = 0;
            this.buttonConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnexion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexion.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnexion.Image")));
            this.buttonConnexion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConnexion.Location = new System.Drawing.Point(314, 335);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(306, 39);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonMdpOubli
            // 
            this.buttonMdpOubli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMdpOubli.FlatAppearance.BorderSize = 0;
            this.buttonMdpOubli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMdpOubli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMdpOubli.Location = new System.Drawing.Point(595, 411);
            this.buttonMdpOubli.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMdpOubli.Name = "buttonMdpOubli";
            this.buttonMdpOubli.Size = new System.Drawing.Size(227, 28);
            this.buttonMdpOubli.TabIndex = 6;
            this.buttonMdpOubli.Text = "Mot de passe oublié ?";
            this.buttonMdpOubli.UseVisualStyleBackColor = true;
            // 
            // UserControlConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonMdpOubli);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxConnexionPassword);
            this.Controls.Add(this.TextBoxConnexionEmail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlConnexion";
            this.Size = new System.Drawing.Size(850, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxConnexionEmail;
        private System.Windows.Forms.TextBox TextBoxConnexionPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonMdpOubli;
    }
}
