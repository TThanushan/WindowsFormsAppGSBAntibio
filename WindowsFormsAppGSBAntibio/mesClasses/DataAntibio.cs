using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class DataAntibio
    {
        static private List<Antibiotique> lesAntibiotiques;
        static private List<Categorie> lesCategories;

        static public void initialiser()
        {
            recupCategorie();
            /*
            DataAntibio.lesCategories = new List<Categorie>();
            Categorie uneCategorie1 = new Categorie("Aminoglycosides");

            DataAntibio.lesCategories.Add(uneCategorie1);
            Categorie uneCategorie2 = new Categorie("AntiFongiques");

            DataAntibio.lesCategories.Add(uneCategorie2);
            Categorie uneCategorie3 = new Categorie("Antiviraux");

            DataAntibio.lesCategories.Add(uneCategorie3);
            Categorie uneCategorie4 = new Categorie("Carbapénèmes");

            DataAntibio.lesCategories.Add(uneCategorie4);
            Categorie uneCategorie5 = new Categorie("Céphalosporines");

            DataAntibio.lesCategories.Add(uneCategorie5);
            Categorie uneCategorie6 = new Categorie("Macrolides");

            DataAntibio.lesCategories.Add(uneCategorie6);
            Categorie uneCategorie7 = new Categorie("Pénicillines");

            DataAntibio.lesCategories.Add(uneCategorie7);
            Categorie uneCategorie8 = new Categorie("Quinolones");

            DataAntibio.lesCategories.Add(uneCategorie8);
            Categorie uneCategorie9 = new Categorie("Sulfamidés");

            DataAntibio.lesCategories.Add(uneCategorie9);
            Categorie uneCategorie10 = new Categorie("Autres");

            DataAntibio.lesCategories.Add(uneCategorie10);

            DataAntibio.lesAntibiotiques = new List<Antibiotique>();

            AntibioParKilo unAntibioParKilo;
            unAntibioParKilo = new AntibioParKilo("Amikacine", "Amiklin", "mg", uneCategorie1, 15, 2);
            DataAntibio.lesAntibiotiques.Add(unAntibioParKilo);

            unAntibioParKilo = new AntibioParKilo("Gentamicine", "Garamycine", "mg", uneCategorie1, 6, 1);
            DataAntibio.lesAntibiotiques.Add(unAntibioParKilo);

            AntibioParPrise unAntibioParPrise = new AntibioParPrise("Fluconazole", "Diflucan", "mg", uneCategorie2, 300, 1);
            DataAntibio.lesAntibiotiques.Add(unAntibioParPrise);
            */

        }
        static public List<Categorie> getLesCategories()
        {
            return DataAntibio.lesCategories;
        }
        static public List<Antibiotique> getAntibiotiquesUneCateg(Categorie c)
        {
            List<Antibiotique> retour = new List<Antibiotique>();
            foreach(Antibiotique antibiotique in DataAntibio.lesAntibiotiques)
            {
                if (antibiotique.getCategorie().getLibelle() == c.getLibelle())
                {
                    retour.Add(antibiotique);
                }
            }
            return retour;
        }

        public List<AntibioParPrise> getAntibioParPrises()
        {
            List<AntibioParPrise> retour = new List<AntibioParPrise>();
            foreach(Antibiotique antibio in lesAntibiotiques)
            {
                if (antibio is AntibioParPrise)
                    retour.Add((AntibioParPrise)antibio);
            }
            return retour;
        }

        public double getMoyDosePrise(String unite)
        {
            List<AntibioParPrise> antibioParPrises = getAntibioParPrises();
            int doseTotal = 0;
            double doseMoy = 0;
            foreach(AntibioParPrise antibio in antibioParPrises)
            {
                if(antibio.getUnite() == unite)
                    doseTotal += antibio.getDosePrise();
            }

            doseMoy = doseTotal / antibioParPrises.Count();
            return doseMoy;
        }

        //Récupère les catégories.
        public static async void recupCategorie()
        {
            lesCategories = new List<Categorie>();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("http://127.0.0.1:81/antibio/apiCategorie.php").Result;
            string fileJsonString = await response.Content.ReadAsStringAsync();
            string[] categoriesList = fileJsonString.Split(',');
            foreach (string categorie in categoriesList)
            {
                string[] ligne = categorie.Split(':');
                char[] caractAEnlever = { '\"', '}', '{', ']', '[' };
                String libelle = ligne[1]; // récupère la valeur
                libelle = libelle.Trim(caractAEnlever);
                Categorie c = new Categorie(libelle);
                lesCategories.Add(c);
            }




        }

        //Récupère les antibiotiques.
        public static async void recupAntibiotique()
        {
            lesAntibiotiques = new List<Antibiotique>();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("http://127.0.0.1:81/antibio/apiAntibiotique.php").Result;
            string fileJsonString = await response.Content.ReadAsStringAsync();
            string[] categoriesList = fileJsonString.Split(',');

            foreach (string categorie in categoriesList)
            {
                string[] ligne = categorie.Split(':');
                char[] caractAEnlever = { '\"', '}', '{', ']', '[' };
                String libelle = ligne[1]; // récupère la valeur
                libelle = libelle.Trim(caractAEnlever);
                Categorie c = new Categorie(libelle);
                lesCategories.Add(c);
            }
        }


    }
}
     
