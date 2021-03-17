using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIzara.Model.Entities
{
    class Ville
    {
        public string CP { get; set; }
        public string nom_ville { get; set; }
        public string ref_pays { get; set; }

        public Ville()
        {

        }

        public Ville(string nom)
        {
            this.nom_ville = nom;
        }

        public Ville(string cP, string nom_ville, string ref_pays)
        {
            CP = cP;
            this.nom_ville = nom_ville;
            this.ref_pays = ref_pays;
        }
    }
}
