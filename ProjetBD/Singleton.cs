using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBD
{
    internal class Singleton
    {


        MySqlConnection con;
        //ObservableCollection<trajet> liste;
        static Singleton singleton = null;  // creation et initialisation d'un objet static gestionBD de la class GestionBD

        public Singleton()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;h2023_420416ri_eq9;Uid=2100781;Pwd=2100781;");
           // liste = new ObservableCollection<trajet>();
        }
        public static Singleton getInstance()
        {
            if (singleton == null)
                singleton = new Singleton();

            return singleton;
        }

    }
}
