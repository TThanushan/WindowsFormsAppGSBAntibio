using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WindowsFormsAppGSBAntibio.mesClasses
{
    public class DataAntibio
    {
        static private List<Antibiotique> lesAntibiotiques;
        static private List<Categorie> lesCategories;

        static public void initialiser()
        {
            recupCategorie();
            recupAntibiotique();

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
            double doseTotal = 0;
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
            
            //Recupere les antibioParKilo
            HttpResponseMessage response = client.GetAsync("http://127.0.0.1:81/antibio/apiAntibiotiqueKilo.php").Result;
            string fileJsonString = await response.Content.ReadAsStringAsync();
            string[] antibiotiquesList = fileJsonString.Split(',');

            List<AntibioParKilo> lesAntibioParKilo = decoupeJsonEnAntibioParKilo(antibiotiquesList);
            
            //Recupere les antibioParPrise
            response = client.GetAsync("http://127.0.0.1:81/antibio/apiAntibiotiquePrise.php").Result;
            fileJsonString = await response.Content.ReadAsStringAsync();
            antibiotiquesList = fileJsonString.Split(',');

            List<AntibioParPrise> lesAntibioParPrise = decoupeJsonEnAntibioParPrise(antibiotiquesList);

            assigneListeAntibio(lesAntibioParKilo, lesAntibioParPrise);
        }

        public static void assigneListeAntibio(List<AntibioParKilo> listeKilo, List<AntibioParPrise> listePrise)
        {

            foreach(AntibioParKilo antibio in listeKilo)
            {
                lesAntibiotiques.Add(antibio);
            }


            foreach(AntibioParPrise antibio in listePrise)
            {
                lesAntibiotiques.Add(antibio);
            }
        }

        public static List<AntibioParPrise> decoupeJsonEnAntibioParPrise(string[] antiboList)
        {
            List<AntibioParPrise> listeRetour = new List<AntibioParPrise>();

            int ligne = 0;
            char[] caractAEnlever = { '\"', '}', '{', ']', '[' };

            for (int i = 0; i < antiboList.Count() / 6; i++)
            {

                //libelle
                string[] nomEtValeur = antiboList[0 + ligne].Split(':');
                string libelle = nomEtValeur[1].Trim(caractAEnlever);

                //libelleG
                nomEtValeur = antiboList[1 + ligne].Split(':');
                string libelleG = nomEtValeur[1].Trim(caractAEnlever);

                //doseKilo
                nomEtValeur = antiboList[2 + ligne].Split(':');
                //Pour convertir le string en decimal, il faut remplacer le point par une virgule. Ex : 6.00 => 6,00
                string dosePriseFormater = nomEtValeur[1].Replace('.', ',');

                double dosePrise = Convert.ToDouble(dosePriseFormater.Trim(caractAEnlever));

                //unite
                nomEtValeur = antiboList[3 + ligne].Split(':');
                string unite = nomEtValeur[1].Trim(caractAEnlever);

                //nombre
                nomEtValeur = antiboList[4 + ligne].Split(':');
                int nombre = Convert.ToInt32(nomEtValeur[1].Trim(caractAEnlever));

                //categorie
                nomEtValeur = antiboList[5 + ligne].Split(':');
                Categorie categorie = new Categorie(nomEtValeur[1].Trim(caractAEnlever));

                listeRetour.Add(new AntibioParPrise(libelle, libelleG, unite, categorie, dosePrise, nombre));

                ligne += 6;
            }

            return listeRetour;
        }

        public static List<AntibioParKilo> decoupeJsonEnAntibioParKilo(string[] antiboList)
        {
            List<AntibioParKilo> listeRetour = new List<AntibioParKilo>();

            int ligne = 0;
            char[] caractAEnlever = { '\"', '}', '{', ']', '[' };

            for (int i = 0; i < antiboList.Count()/6; i++)
            {

                //libelle
                string[] nomEtValeur = antiboList[0 + ligne].Split(':');
                string libelle = nomEtValeur[1].Trim(caractAEnlever);

                //libelleG
                nomEtValeur = antiboList[1 + ligne].Split(':');
                string libelleG = nomEtValeur[1].Trim(caractAEnlever);

                //doseKilo
                nomEtValeur = antiboList[2 + ligne].Split(':');
                //Pour convertir le string en decimal, il faut remplacer le point par une virgule. Ex : 6.00 => 6,00
                string doseKiloFormater = nomEtValeur[1].Replace('.', ',');

                double doseKilo = Convert.ToDouble(doseKiloFormater.Trim(caractAEnlever));
                
                //unite
                nomEtValeur = antiboList[3 + ligne].Split(':');
                string unite = nomEtValeur[1].Trim(caractAEnlever);
                
                //nombre
                nomEtValeur = antiboList[4 + ligne].Split(':');
                int nombre = Convert.ToInt32(nomEtValeur[1].Trim(caractAEnlever));
                
                //categorie
                nomEtValeur = antiboList[5 + ligne].Split(':');
                Categorie categorie =  new Categorie(nomEtValeur[1].Trim(caractAEnlever));
                
                listeRetour.Add(new AntibioParKilo(libelle, libelleG, unite, categorie, doseKilo, nombre));

                ligne += 6;
            }
            
            return listeRetour;
        }
        

        public bool estUnAntibioParKilo(String unite)
        {
            return unite.Contains("/kg");
        }


    }
}
     
