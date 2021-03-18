using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIzara.Model.Entities
{
    class Group
    {
        public int REF { get; set; }
        public string nom_group { get; set; }

        public Group()
        {

        }

        public Group(int ref_gp, string nom)
        {
            this.REF = ref_gp;
            this.nom_group = nom;
        }
    }
}
