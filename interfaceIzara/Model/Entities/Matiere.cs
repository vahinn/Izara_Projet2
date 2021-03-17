using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIzara.Model.Entities
{
    class Matiere
    {
        public string REF_MATIERE { get; set; }
        public string nom_matiere { get; set; }
        public int categorie { get; set; }

        public Matiere()
        {

        }

        public Matiere(string nom)
        {
            this.nom_matiere = nom;
        }

        public Matiere(string ref_mat, string nom)
        {
            this.REF_MATIERE = ref_mat;
            this.nom_matiere = nom;
        }


        public Matiere(string rEF_MATIERE, string nom_matiere, int categorie) : this(rEF_MATIERE, nom_matiere)
        {
            this.categorie = categorie;
        }
    }
}
