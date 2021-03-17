using DotLiquid.Tags;
using interfaceIzara.Model.Entities;
using interfaceIzara.Model.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceIzara
{
    public partial class UserControlInscription : UserControl
    {
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

                Users parent = new Users(0,
                    textBoxInscriptionNom.Text,
                    textBoxInscriptionPrenom.Text,
                    textBoxInscriptionMail.Text,
                    textBoxInscriptionPassword.Text,
                    true,
                    false,
                    DateTime.Now,
                    0,
                    "",
                    0,
                    1,
                    null
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
    }
}
