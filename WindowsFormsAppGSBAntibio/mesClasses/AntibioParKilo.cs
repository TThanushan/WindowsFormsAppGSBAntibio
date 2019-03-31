using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class AntibioParKilo : Antibiotique
    {
    private int doseKilo;
    public AntibioParKilo(String pLibelle, String pLibelleG, String pUnite, Categorie pCategorie, int pDoseKilo, int pNombre) : base(pLibelle, pLibelleG, pUnite, pCategorie, pNombre)
    {        
        this.doseKilo = pDoseKilo;
    }
    public int getDoseKilo()
    {
        return this.doseKilo;
    }
}

}
