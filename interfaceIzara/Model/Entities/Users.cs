using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIzara.Model.Entities
{
    class Users
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        private string _password;
        public string password
        {
            get
            {
                return this._password;
            }
            private set
            {
                _password = hashPassword(value);
            }
        }
        public bool isActive { get; set; }
        public bool isValidate { get; set; }
        public DateTime validationDate { get; set; }
        public float rate { get; set; }
        public string niveau { get; set; }
        public string pdp { get; set; }
        private string matiere;
        public string ref_matiere { 
            get 
            {
                return this.matiere;
            }
            set 
            {
                this.matiere = getRefMatiere(value);
            }
        }
        public float tarifHoraire { get; set; }
        public string whatsApp { get; set; }
        public int anneeExp { get; set; }
        public string cv { get; set; }
        public string Etablissement { get; set; }
        public int reference_groupe { get; set; }
        public string code_parrainage { get; set; }
        private string ville;
        public string cp_ville
        {
            get
            {
                return ville;
            }
            set
            {
                ville = getVille(value);
            }
        }


        public Users()
        {

        }


        /***
         * 
         * For authentication
         * 
         */
        public Users(string mail, string pass)
        {
            this.mail = mail;
            this.password = pass;
        }

        /**
         * 
         * For creating parent
         * 
         */
        public Users(string nom, string prenom, string mail, string password, string ville, string whtsapp, string pdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.password = password;
            this.cp_ville = ville;
            this.whatsApp = whtsapp;
            this.pdp = pdp;
            this.reference_groupe = 1;
        }

        /**
         * 
         * For creating prof
         * 
         */
        public Users(string nom, string prenom, string mail, string password, string ville, string whtsapp, string cv, string pdp, string etablissement, string matiere, int anneeExp, string niveau)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.password = password;
            this.cp_ville = ville;
            this.whatsApp = whtsapp;
            this.cv = cv;
            this.pdp = pdp;
            this.Etablissement = etablissement;
            this.ref_matiere = matiere;
            this.anneeExp = anneeExp;
            this.niveau = niveau;
            this.reference_groupe = 2;
        }

        private String hashPassword(string pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                Console.WriteLine(sha256.ToString());
                Console.WriteLine(pass);
                byte[] byteArray = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < byteArray.Length; i += 1)
                {
                    /*                    sb.Append(byteArray[i].ToString("x2"));*/
                    sb.Append(byteArray[i].ToString());
                }
                return sb.ToString();
            }
        }

        private string getVille(string val)
        {
            ConnectDB con = new ConnectDB();
            CrudDB db = new CrudDB();

            try
            {

                con.Connexion.Open();

                List<Ville> listVilles = db.Find<Ville>("ville", new Ville(val), "", con.Connexion);

                return listVilles[0].CP;
            }
            catch(Exception e)
            {
                Console.WriteLine("getVille :: Probleme :: {0}", e.StackTrace);
            }
            finally
            {
                con.Connexion.Close();
            }
            return null;
        }

        private string getRefMatiere(string matiere)
        {
            ConnectDB con = new ConnectDB();
            CrudDB db = new CrudDB();

            try
            {
                con.Connexion.Open();
                List<Matiere> listeMatiere = db.Find<Matiere>("Matiere", new Matiere(), "", con.Connexion);

                return listeMatiere[0].REF_MATIERE;
            }
            catch(Exception e)
            {
                Console.WriteLine("Users :: GetMatiere :: {0}",e.StackTrace);
            }
            finally
            {
                con.Connexion.Close();
            }
            return null;
        }
    }
}
