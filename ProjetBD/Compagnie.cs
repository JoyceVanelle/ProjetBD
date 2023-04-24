using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBD
{
    internal class Compagnie
    {
        int id_Compagnie;
        String nom;
        double capacite_prod;
        double prod_reelle;
        double revenu_annuelle;
        double prix_baril;

        public Compagnie()
        {
            this.nom = "";
            this.capacite_prod = 0;
            this.prod_reelle = 0;
            this .revenu_annuelle = 0;
            this.prix_baril = 0;

        }

        public Compagnie( int Id_Compagnie ,string nom, double capacite_prod, double prod_reelle, double revenu_annuelle, double prix_baril)
        {
            this.Id_Compagnie = id_Compagnie;
            this.Nom = nom;
            this.Capacite_prod = capacite_prod;
            this.Prod_reelle = prod_reelle;
            this.Revenu_annuelle = revenu_annuelle;
            this.Prix_baril = prix_baril;
        }
        public int Id_Compagnie { get => id_Compagnie; set => id_Compagnie = value; }
        public string Nom { get => nom; set => nom = value; }
        public double Capacite_prod { get => capacite_prod; set => capacite_prod = value; }
        public double Prod_reelle { get => prod_reelle; set => prod_reelle = value; }
        public double Revenu_annuelle { get => revenu_annuelle; set => revenu_annuelle = value; }
        public double Prix_baril { get => prix_baril; set => prix_baril = value; }
        

        public override string ToString()
        {

            return nom + " " + capacite_prod + " " + prod_reelle + " " + Revenu_annuelle + " " + Prix_baril; 
         }
    }

   

}
