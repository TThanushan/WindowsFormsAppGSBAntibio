using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class AntibioParPrise : Antibiotique
    {
        private double dosePrise;
        public AntibioParPrise(String pLibelle, String pLibelleG, String pUnite, Categorie pCategorie, double pDosePrise, int pNombre) : base(pLibelle, pLibelleG, pUnite, pCategorie, pNombre)
        {
            this.dosePrise = pDosePrise;
        }
        public double getDosePrise()
        {
            return this.dosePrise;
        }
    


    }
}
