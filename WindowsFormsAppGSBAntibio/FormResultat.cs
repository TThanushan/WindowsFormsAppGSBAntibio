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
    public partial class frmResultatRecherche : Form
    {
        List<Antibiotique> lesAntibiotiques;
        public frmResultatRecherche(Categorie categorie)
        {
            InitializeComponent();
            lesAntibiotiques = DataAntibio.getAntibiotiquesUneCateg(categorie);
            foreach(Antibiotique antibiotique in lesAntibiotiques)
            {
                lstResultat.Items.Add(antibiotique.getLibelle());
            }

            MontrerLaCasePoids(false);

        }

        private void txtPoids_TextChanged(object sender, EventArgs e)
        {
            afficherLaDosePrisePoids();
        }

        private void lstResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherEtCacherPoids();
            afficherLaDosePrisePoids();
        }
        private void MontrerLaCasePoids(bool cacher)
        {
            if (cacher)
            { 
                txtPoids.Show();
                lblPoids.Show();
            }
            else
            {
                txtPoids.Hide();
                lblPoids.Hide();
            }
}
        private void AfficherEtCacherPoids()
        {
            if (antibiotiqueSelectionner() is AntibioParKilo)
            {
                MontrerLaCasePoids(true);
            }
            else
            {
                MontrerLaCasePoids(false);
            }


        }
        private void afficherLaDose()
        { 
            
        }
        private void afficherLaDosePrisePoids()
        {
            
            if (lstResultat.SelectedIndex != -1 && txtPoids.Text != "")
            {
                Antibiotique antibiotiqueChoisi = antibiotiqueSelectionner();

                int nouvelleDose = Convert.ToInt32(txtPoids.Text) * antibiotiqueChoisi.getNombre();

                lblDoseResultat.Text = Convert.ToString(nouvelleDose) + " " + antibiotiqueChoisi.getUnite();
            }
        
        }
        private Antibiotique antibiotiqueSelectionner()
        {
            return lesAntibiotiques[lstResultat.SelectedIndex];
        }

    }
}
