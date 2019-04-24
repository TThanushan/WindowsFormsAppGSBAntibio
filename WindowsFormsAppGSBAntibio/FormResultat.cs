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
using System.Net.Mail;
using System.Net;


namespace WindowsFormsAppGSBAntibio
{
    // Créer une seule table pour les trois tables antibiotiques, par prise et par kilo
    public partial class frmResultatRecherche : Form
    {
        List<Antibiotique> lesAntibiotiques;
        Categorie categorie;
        DataAntibio dataAntibio;
        public frmResultatRecherche(Categorie uneCategorie)
        {
            InitializeComponent();
            
            categorie = uneCategorie;
            lesAntibiotiques = DataAntibio.getAntibiotiquesUneCateg(uneCategorie);

            afficheLaListeDesAntibiotique(lesAntibiotiques);
        }

        private void txtPoids_TextChanged(object sender, EventArgs e)
        {

            afficherLaDosePrisePoids();
        }


        private void lstResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResultat.SelectedIndex != -1)
            {

                AfficherEtCacherPoids();
                afficherLaDose();
                afficherLesInfosAntibiotique();
            }
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

        private void afficherLesInfosAntibiotique()
        {
            lblLibelle.Text = "Libelle : " + antibiotiqueSelectionner().getLibelle();

            lblLibelleG.Text = "Libelle Groupe : " + antibiotiqueSelectionner().getLibelleG();

            lblUnite.Text = "Unite : " + antibiotiqueSelectionner().getUnite();

            lblNbParJour.Text = "Nombre par jour : " + antibiotiqueSelectionner().getNombre();
        }

        private void afficherLaDose()
        {
            if (antibiotiqueSelectionner() is AntibioParKilo)
            {
                afficherLaDosePrisePoids();
            }
            else
            {
                AntibioParPrise antibio = (AntibioParPrise)antibiotiqueSelectionner();
                lblDoseResultat.Text = "Dose : " + antibio.getDosePrise().ToString();
            }
        }

        private void afficherLaDosePrisePoids()
        {
            
            if (lstResultat.SelectedIndex != -1 && txtPoids.Text != "")
            {
                Antibiotique antibiotiqueChoisi = antibiotiqueSelectionner();

                int nouvelleDose = Convert.ToInt32(txtPoids.Text) * antibiotiqueChoisi.getNombre();

                lblDoseResultat.Text = "Dose total : " + Convert.ToString(nouvelleDose) + " " + antibiotiqueChoisi.getUnite();

            }
        
        }
        private Antibiotique antibiotiqueSelectionner()
        {
            return lesAntibiotiques[lstResultat.SelectedIndex];
        }

        private void txtPoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Empeche la saisie de lettre.
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr))
                e.Handled = true;
        }

        private List<Antibiotique> RetourneListeAntibioCorrespondant(String text)
        {
            List<Antibiotique> retour = new List<Antibiotique>();



            if (text != "")
            {
                foreach (Antibiotique a in this.lesAntibiotiques)
                {
                    if (text == a.getLibelle().Substring(0, text.Length))
                        retour.Add(a);

                }
            }
            else
                retour = this.lesAntibiotiques;

            return retour;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            List<Antibiotique> lesAntibiotiquesTemp = new List<Antibiotique>();

            lesAntibiotiquesTemp = RetourneListeAntibioCorrespondant(txtRecherche.Text);
 
            afficheLaListeDesAntibiotique(lesAntibiotiquesTemp);
        }

        private void afficheLaListeDesAntibiotique(List<Antibiotique> listeAntibio)
        {
            lstResultat.Items.Clear();
            foreach (Antibiotique antibiotique in listeAntibio)
            {
                lstResultat.Items.Add(antibiotique.getLibelle());
            }

            MontrerLaCasePoids(false);

        }

        private void txtDoseMoyEntree_TextChanged(object sender, EventArgs e)
        {
            DataAntibio dataAntibio = new DataAntibio();
            string unite = txtDoseMoyEntree.Text;
            double doseMoy = 0;
            doseMoy = dataAntibio.getMoyDosePrise(unite);

            lblDoseMoy.Text = "Dose moyenne prise : " + Convert.ToString(doseMoy);

            if (doseMoy != 0)
            {
                lblDoseMoy.Text = "Dose moyenne prise : " + Convert.ToString(doseMoy);
            }
            

        }

        private void btnEnvoyerMail_Click_1(object sender, EventArgs e)
        {
            String FROM = "GSB@gmail.com";
            String FROMNAME = "GSB";

            // Replace recipient@example.com with a "To" address. If your account 
            // is still in the sandbox, this address must be verified.
            String TO = txtMail.Text;

            // Replace smtp_username with your Amazon SES SMTP user name.
            String SMTP_USERNAME = "@gmail.com";

            // Replace smtp_password with your Amazon SES SMTP user name.
            String SMTP_PASSWORD = "";

            // If you're using Amazon SES in a region other than US West (Oregon), 
            // replace email-smtp.us-west-2.amazonaws.com with the Amazon SES SMTP  
            // endpoint in the appropriate AWS Region.
            String HOST = "smtp.gmail.com";

            // The port you will connect to on the Amazon SES SMTP endpoint. We
            // are choosing port 587 because we will use STARTTLS to encrypt
            // the connection.
            int PORT = 587;

            // The subject line of the email
            String SUBJECT =
                "TEST GSB ENVOIE MAIL Amazon SES test (SMTP interface accessed using C#)";

            // The body of the email
            String BODY =
                "<h1>Amazon SES Test</h1>" +
                "<p>This email was sent through the " +
                "<a href='https://aws.amazon.com/ses'>Amazon SES</a> SMTP interface " +
                "using the .NET System.Net.Mail library.</p>";

            // Create and build a new MailMessage object
            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(FROM, FROMNAME);
            message.To.Add(new MailAddress("thanushantharmabalan@gmail.com"));
            message.Subject = SUBJECT;
            message.Body = BODY;

            using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Pass SMTP credentials
                client.Credentials = new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                // Enable SSL encryption
                client.EnableSsl = true;

                // Try to send the message. Show status in console.
                try
                {
                    MessageBox.Show("Attempting to send email...", "test");
                    Console.WriteLine("Attempting to send email...");
                    client.Send(message);
                    Console.WriteLine("Email sent!");
                    MessageBox.Show("Email sent", "test");
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("The email was not sent.");
                    Console.WriteLine("Error message: " + ex.Message);
                }
            }
        }
    }
}
