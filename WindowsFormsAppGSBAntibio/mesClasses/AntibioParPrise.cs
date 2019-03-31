using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class AntibioParPrise : Antibiotique
    {
    private int dosePrise;
    public AntibioParPrise(String pLibelle, String pLibelleG, String pUnite, Categorie pCategorie, int pDosePrise, int pNombre) : base(pLibelle, pLibelleG, pUnite, pCategorie, pNombre)
    {
        this.dosePrise = pDosePrise;
    }
    public int getDosePrise()
    {
        return this.dosePrise;
    }

}
}
