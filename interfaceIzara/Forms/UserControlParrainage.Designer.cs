
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlParrainage));
            System.Windows.Forms.DateTimePicker dateTimePickerParrainage;
            this.labelParrainage = new System.Windows.Forms.Label();
            this.buttonEnvoiCandidature = new System.Windows.Forms.Button();
            this.textBoxParrainage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            dateTimePickerParrainage = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelParrainage
            // 
            this.labelParrainage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelParrainage.AutoSize = true;
            this.labelParrainage.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParrainage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.labelParrainage.Location = new System.Drawing.Point(328, 15);
            this.labelParrainage.Name = "labelParrainage";
            this.labelParrainage.Size = new System.Drawing.Size(248, 28);
            this.labelParrainage.TabIndex = 0;
            this.labelParrainage.Text = "Lettre de Parrainage";
            this.labelParrainage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonEnvoiCandidature.Location = new System.Drawing.Point(333, 457);
            this.buttonEnvoiCandidature.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEnvoiCandidature.Name = "buttonEnvoiCandidature";
            this.buttonEnvoiCandidature.Size = new System.Drawing.Size(243, 44);
            this.buttonEnvoiCandidature.TabIndex = 88;
            this.buttonEnvoiCandidature.Text = "Envoyer";
            this.buttonEnvoiCandidature.UseVisualStyleBackColor = false;
            // 
            // textBoxParrainage
            // 
            this.textBoxParrainage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxParrainage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParrainage.Location = new System.Drawing.Point(97, 276);
            this.textBoxParrainage.Multiline = true;
            this.textBoxParrainage.Name = "textBoxParrainage";
            this.textBoxParrainage.Size = new System.Drawing.Size(650, 163);
            this.textBoxParrainage.TabIndex = 89;
            this.textBoxParrainage.Text = resources.GetString("textBoxParrainage.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 90;
            this.textBox1.Text = "Nom du parent";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(97, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 23);
            this.textBox2.TabIndex = 91;
            this.textBox2.Text = "Prénom du parent";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(97, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 23);
            this.textBox3.TabIndex = 92;
            this.textBox3.Text = "e mail du parent";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(333, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 23);
            this.textBox4.TabIndex = 95;
            this.textBox4.Text = "e mail du professeur";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(333, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(210, 23);
            this.textBox5.TabIndex = 94;
            this.textBox5.Text = "Prénom du professeur";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(333, 107);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 23);
            this.textBox6.TabIndex = 93;
            this.textBox6.Text = "Nom du professeur à parrainer";
            // 
            // dateTimePickerParrainage
            // 
            dateTimePickerParrainage.Location = new System.Drawing.Point(97, 102);
            dateTimePickerParrainage.Name = "dateTimePickerParrainage";
            dateTimePickerParrainage.Size = new System.Drawing.Size(200, 22);
            dateTimePickerParrainage.TabIndex = 97;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "6ème",
            "5ème",
            "4ème",
            "3ème",
            "Seconde",
            "Première",
            "Terminale",
            ""});
            this.checkedListBox1.Location = new System.Drawing.Point(572, 102);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 157);
            this.checkedListBox1.TabIndex = 98;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // UserControlParrainage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(dateTimePickerParrainage);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxParrainage);
            this.Controls.Add(this.buttonEnvoiCandidature);
            this.Controls.Add(this.labelParrainage);
            this.Name = "UserControlParrainage";
            this.Size = new System.Drawing.Size(850, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParrainage;
        private System.Windows.Forms.Button buttonEnvoiCandidature;
        private System.Windows.Forms.TextBox textBoxParrainage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
