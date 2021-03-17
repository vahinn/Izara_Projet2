using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIzara.Model
{
    class ConnectDB
    {
        public MySqlConnection Connexion { get; private set; }

        public ConnectDB()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            try
            {
                /*string connectionString = "SERVER=mysql-heriniaina1905.alwaysdata.net; DATABASE=heriniaina1905_projet2; UID=210520_projet2; PASSWORD=PaSs3$2021";*/
                string connectionString = "SERVER=localhost; DATABASE=izara; UID=root; PASSWORD=";
                this.Connexion = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Misy blem : {0}", e.StackTrace);
            }
        }
    }
}
