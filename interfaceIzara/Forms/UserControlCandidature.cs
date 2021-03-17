using interfaceIzara.Model.Entities;
using interfaceIzara.Model.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            try {
                if (textBoxCandidaturePassword.Text != textBoxCandidatureConfirmationPassword.Text)
                    throw new Exception("Mot de passe incorecte");
                Users prof = new Users(
                    //...
                );
                Authentication authentif = new Authentication();
                if (!authentif.Subscribe(prof))
                    throw new AuthException("misy olana ilay inscription");

                textBoxCandidatureConfirmationPassword.Text = "";
                textBoxCandidaturePassword.Text = "";
                textBoxCandidatureNom.Text="";
                textBoxCandidaturePrenom.Text="";
                textBoxCandidatureMail.Text="";

                MessageBox.Show("candidature envoyée");

            }
            catch (AuthException ae)
            {
                MessageBox.Show("Une erreur s'est produite , veuillez contacter l' administrateur");

            }
            catch (Exception exp )
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
    }

    [Serializable]
    internal class AuthException : Exception
    {
        public AuthException()
        {
        }

        public AuthException(string message) : base(message)
        {
        }

        public AuthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AuthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
