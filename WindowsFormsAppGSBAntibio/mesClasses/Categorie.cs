using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class Categorie
    {
        private String libelle;

        public Categorie(String pLibelle)
        {
            this.libelle = pLibelle;
        }

        public String getLibelle()
        {
            return this.libelle;
        }

        public bool equals(Object o)
        { // pour utiliser indexOf ou contains
            String libelle = ((Categorie)o).getLibelle();
            return (this.libelle.Equals(libelle));
        }
    }
}
