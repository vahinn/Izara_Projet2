using interfaceIzara.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIzara.Model.Utilities
{
    class Authentication
    {
        public Users Auth(Users u)
        {
            ConnectDB con = new ConnectDB();
            CrudDB db = new CrudDB();
            try
            {
                con.Connexion.Open();

                List<Users> listeUsers = db.Find<Users>("Users", u, "", con.Connexion);

                Console.WriteLine("Tafa!!!");

                return listeUsers[0];
            }
            catch (Exception e)
            {
                Console.WriteLine("Authentication :: Auth :: {0}", e.StackTrace);
            }
            finally
            {
                con.Connexion.Close();
            }
            return null;
        }

        public bool Subscribe(Users newUser)
        {
            ConnectDB con = new ConnectDB();
            CrudDB db = new CrudDB();
            try
            {
                con.Connexion.Open();
                db.Insert("Users", newUser, con.Connexion);
                Console.WriteLine("Utilisateur créé avec succes!");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Connexion.Close();
            }
            return false;
        }
    }
}
