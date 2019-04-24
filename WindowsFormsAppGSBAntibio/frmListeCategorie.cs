using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppGSBAntibio.mesClasses;

namespace WindowsFormsAppGSBAntibio
{
    public partial class frmListeCategorie : Form
    {
        List<Categorie> lesCategories;

        public frmListeCategorie()
        {
            InitializeComponent();
        }

        private void frmListeCategorie_Load(object sender, EventArgs e)
        {
            MontrerLaListeAntibioComplete();
        }

        private void lstCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmResultatRecherche formResultat = new frmResultatRecherche(lesCategories[lstCategorie.SelectedIndex]);
            formResultat.Show();
        }


        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            /* if(txtRecherche.Text == "")
            {
                MontrerLaListeAntibioComplete();
            }
            else
            {
                String saisie = txtRecherche.Text;

            }*/
        }


        private void MontrerLaListeAntibioComplete()
        {
            DataAntibio.initialiser();
            lesCategories = DataAntibio.getLesCategories();
            foreach (Categorie c in lesCategories)
            {
                lstCategorie.Items.Add(c.getLibelle().ToUpper());
            }

        }
    }
}
