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
        public float tarifHoraire { get; set; }
        public int reference_groupe { get; set; }
        public string code_parrainage { get; set; }

        public Users(int iD, string nom, string prenom, string mail, string password, bool isActive, bool isValidate, DateTime validationDate, float rate, string niveau, float tarifHoraire, int rf_group, string cd_parrainage)
        {
            ID = iD;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.password = password;
            this.isActive = isActive;
            this.isValidate = isValidate;
            this.validationDate = validationDate;
            this.rate = rate;
            this.niveau = niveau;
            this.tarifHoraire = tarifHoraire;
            this.reference_groupe = rf_group;
            this.code_parrainage = cd_parrainage;
        }

        public Users()
        {

        }
        public Users(string mail, string pass)
        {
            this.mail = mail;
            this.password = pass;
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
    }
}
