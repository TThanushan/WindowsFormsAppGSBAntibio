using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class AntibioParKilo : Antibiotique
    {
        private double doseKilo;
        public AntibioParKilo(String pLibelle, String pLibelleG, String pUnite, Categorie pCategorie, double pDoseKilo, int pNombre) : base(pLibelle, pLibelleG, pUnite, pCategorie, pNombre)
        {
            this.doseKilo = pDoseKilo;
        }
        public double getDoseKilo()
        {
        
            return this.doseKilo;
    
        }
    }

}
