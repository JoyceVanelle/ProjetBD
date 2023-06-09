﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace ProjetBD
{
    internal class Singleton
    {


        MySqlConnection con;
        ObservableCollection<Compagnie> liste;
        static Singleton singleton = null;  // creation et initialisation d'un objet static gestionBD de la class GestionBD

        public Singleton()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=h2023_420416ri_eq9;Uid=2100781;Pwd=2100781;");
            liste = new ObservableCollection<Compagnie>();
        }
        public static Singleton getInstance()
        {
            if (singleton == null)
                singleton = new Singleton();

            return singleton;
        }

        public ObservableCollection<Compagnie> GetCompagnie()
        {
            liste.Clear();
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "Select * from compagnie";
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                  

                     liste.Add(new Compagnie()
                    {
                        Id_Compagnie = (int)r.GetInt32(0),
                        Nom = r.GetString(1),
                        Capacite_prod = r.GetDouble(2),
                        Prod_reelle = r.GetDouble(3),
                        Revenu_annuelle = r.GetDouble(4),
                        Prix_baril = r.GetDouble(5),
                    });


                    //lvliste.Items. System.Threading.Thread.Sleep(100);Add(r["id"] + " " + r["nom"] + " "+ r["prenom"] + " " + r["email"]);
                }

                r.Close();
                con.Close();


            }
            catch (MySqlException ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

            }
               return liste;

        }

        public void AjouterCompagnie(String nom, double capacite_prod, double  prod_reelle, double revenu_annuelle,  double prix_baril)
        {



            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "insert into compagnie(nom,capacite_prod ,prod_reelle,revenu_annuelle,prix_baril) " +
                "values(@nom,@capacite_prod,@prod_reelle,@revenu_annuelle,@prix_baril)";

                commande.Parameters.AddWithValue("@nom", nom);
                commande.Parameters.AddWithValue("@capacite_prod", capacite_prod);
                commande.Parameters.AddWithValue("@prod_reelle", prod_reelle);
                commande.Parameters.AddWithValue("@revenu_annuelle", revenu_annuelle);
                commande.Parameters.AddWithValue("@prix_baril", prix_baril);
              

                con.Open();
                commande.Prepare();
                int i = commande.ExecuteNonQuery();



                con.Close();
            }



            catch (MySqlException ex)
            {
                con.Close();
            }



        }



    }
}
