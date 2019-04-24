using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public abstract class Antibiotique
    {
        private String libelle;
        private String libelleG;
        private String unite;
        private int nombreParJour;
        private Categorie laCategorie;

        public Antibiotique(String pLibelle, String pLibelleG, String pUnite, Categorie pCategorie, int pNombre)
        {
            this.libelle = pLibelle;
            this.libelleG = pLibelleG;
            this.unite = pUnite;
            this.laCategorie = pCategorie;
            this.nombreParJour = pNombre;
        }

        public String getLibelleG()
        {
            return this.libelleG;
        }

        public String getLibelle()
        {
            return this.libelle;
        }
        public String getUnite()
        {
            return this.unite;
        }
        public Categorie getCategorie()
        {
            return this.laCategorie;
        }
        public int getNombre()
        {
            return this.nombreParJour;
        }

        
    }

}
