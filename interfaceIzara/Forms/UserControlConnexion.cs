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
    public partial class UserControlConnexion : UserControl
    {
        public UserControlConnexion()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            Users user = new Users(TextBoxConnexionEmail.Text, TextBoxConnexionPassword.Text);
            Authentication auth = new Authentication();
            Users utilisateur;

            try
            {
                utilisateur = auth.Auth(user);
                Console.WriteLine("Nom : {0}", utilisateur.nom);
                Console.WriteLine("Mail : {0}", utilisateur.mail);

                MessageBox.Show(utilisateur.nom+" est Connecté!");
            } 
            catch(NullReferenceException exp)
            {
                MessageBox.Show("Veuillez vérifier votre mail ou mot de passe!");
                Console.WriteLine("UserControlConnexion :: buttonConnexion_Click :: {0}",exp.StackTrace);
            }
        }
    }
}
