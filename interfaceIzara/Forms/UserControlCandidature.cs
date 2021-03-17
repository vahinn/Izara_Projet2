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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceIzara
{
    public partial class UserControlCandidature : UserControl
    {
        public UserControlCandidature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCandidaturePassword.Text != textBoxCandidatureConfirmationPassword.Text)
                    throw new Exception("Mot de passe incorecte");
                Users prof = new Users(0,
                    textBoxCandidatureNom.Text,
                    textBoxCandidaturePrenom.Text,
                    textBoxCandidatureMail.Text,
                    textBoxCandidaturePassword.Text,
                    true,
                    false,
                    new DateTime(),
                    0,
                    comboBoxCandidatureNiveau.Text,
                    0,
                    2,
                    null
                    );
                Authentication authentif = new Authentication();
                if (!authentif.Subscribe(prof))
                    throw new AuthException("misy olana ilay inscription");

                textBoxCandidatureConfirmationPassword.Text = "";
                textBoxCandidaturePassword.Text = "";
                textBoxCandidatureNom.Text = "";
                textBoxCandidaturePrenom.Text = "";
                textBoxCandidatureMail.Text = "";

                MessageBox.Show("candidature envoyée");

            }
            catch (AuthException ae)
            {
                MessageBox.Show("Une erreur s'est produite , veuillez contacter l' administrateur");

            }
            catch (Exception exp)
            {
                MessageBox.Show("Veuillez ressaisir votre mot de passe");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonProf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileRecept = string.Empty;
            OpenFileDialog i = new OpenFileDialog();
            i.Filter = "jpg files( *.jpg)|*.jpg|png files (*.png)|*.png| all files (*.*)|*.*";
            i.FilterIndex = 3;
            i.RestoreDirectory = true;
            if (i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = i.FileName;
                string[] pth = filePath.Split('\\');
                var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                fileRecept = CurrentDirectory + "\\Assets\\img\\profilePicture\\"/*+ pth[pth.Length - 1]*/;

                File.Copy(@filePath, @CurrentDirectory + pth[pth.Length - 1], true);
                pictureBox1.Load(@CurrentDirectory + pth[pth.Length - 1]);
                MessageBox.Show("fichier telechargé");
            }
        }

        private void buttonCandidatureTelecharger_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileRecept = string.Empty;
            try
            {
                OpenFileDialog i = new OpenFileDialog();
                i.Filter = "pdf files( *.pdf)|*.pdf|all files (*.*)|*.*";
                i.FilterIndex = 2;
                i.RestoreDirectory = true;
                if (i.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filePath = i.FileName;
                    string[] pth = filePath.Split('\\');
                    var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                    fileRecept = CurrentDirectory + "\\Assets\\img\\profilePicture\\"/*+ pth[pth.Length - 1]*/;

                    File.Copy(@filePath, @CurrentDirectory + pth[pth.Length - 1], true);
                    MessageBox.Show("fichier telechargé");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("une erreur s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        [Serializable]
        internal class AuthException : Exception
        {
            public AuthException()
            {
            }

            public AuthException(string message)
                : base(message)
            {
            }

            public AuthException(string message, Exception innerException)
                : base(message, innerException)
            {
            }

            protected AuthException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
}
