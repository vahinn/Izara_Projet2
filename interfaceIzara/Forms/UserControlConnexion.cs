using interfaceIzara.Model;
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

                switch (utilisateur.reference_groupe)
                {
                    case 1:
                        Console.WriteLine("Parent");
                        break;
                    case 2:
                        Console.WriteLine("Prof");
                        break;
                    case 3:
                        Console.WriteLine("Administrateur");
                        break;
                }
            } 
            catch(NullReferenceException NullExp)
            {
                MessageBox.Show("Veuillez vérifier votre mail ou mot de passe!");
                Console.WriteLine("UserControlConnexion :: buttonConnexion_Click :: {0}", NullExp.StackTrace);
            }
        }

        private Group GetGroupRef(Users user)
        {
            ConnectDB con = new ConnectDB();
            CrudDB db = new CrudDB();
            try
            {
                con.Connexion.Open();
                List<Group> liste_grp = db.Find<Group>("group", new Group(), "", con.Connexion);

                return liste_grp[0];
            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Connexion.Close();
            }
            return 0;
        }
    }
}