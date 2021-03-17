using DotLiquid.Tags;
using interfaceIzara.Model.Entities;
using interfaceIzara.Model.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceIzara
{
    public partial class UserControlInscription : UserControl
    {

        private string pathPDP { get; set; }

        public UserControlInscription()
        {
            InitializeComponent();
        }

        private void buttonEnvoiInscription_Click(object sender, EventArgs e)
        {
            /**
             * 
             * Zavatra ovaina @ manaraka:
             *  - Mail tsy maintsy misy @
             *  - Formulaire obligatoire
             *  
             */
            try
            {
                if (textBoxInscriptionPassword.Text != textBoxInscriptionConfirmationPassword.Text)
                    throw new Exception("Mot de passe incorecte");

                Users parent = new Users(
                    textBoxInscriptionNom.Text,
                    textBoxInscriptionPrenom.Text,
                    textBoxInscriptionMail.Text,
                    textBoxInscriptionPassword.Text,
                    comboBoxInscriptionVille.Text,
                    textBoxInscriptionWhatsapp.Text,
                    pathPDP
                );

                Authentication auth = new Authentication();
                if (!auth.Subscribe(parent))
                    throw new AuthException("misy olana ilay inscription");        

                textBoxInscriptionConfirmationPassword.Text = "";
                textBoxInscriptionPassword.Text = "";
                textBoxInscriptionNom.Text = "";
                textBoxInscriptionPrenom.Text = "";
                textBoxInscriptionMail.Text = "";

                MessageBox.Show("Inscription réussie!");
            }
            catch (AuthException ae)
            {
                MessageBox.Show("Une erreur s'est produite, veuillez contacter l'administrateur");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Veuillez ressaisir votre mot de passe!");
            }
        }


        private class AuthException : Exception
        {
            public AuthException(string msg) : base(msg)
            {

            }        
        }

        private void pictureBoxPDP_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileRecept = string.Empty;
            OpenFileDialog i = new OpenFileDialog();
            i.Filter = "jpg files |*.jpg|png files |*.png| all files |*.*";
            i.FilterIndex = 3;
            i.RestoreDirectory = true;
            if (i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = i.FileName;
                string[] pth = filePath.Split('\\');
                var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                fileRecept = CurrentDirectory + "\\Assets\\img\\profilePicture\\"+ pth[pth.Length - 1];

                File.Copy(@filePath, @fileRecept, true);
                pictureBoxPDP.Load(@fileRecept);

                pathPDP = pth[pth.Length - 1];
            }
        }
    }
}
