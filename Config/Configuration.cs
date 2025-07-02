using GestionMaison;
using System;
using System.Configuration;

namespace VenteMaison
{
    class Configuration
    {
        private static Database _instance;

        public static string GetConnexion()
        {
            if (_instance == null)
            {
                // Lire les paramètres depuis App.config
                string server = ConfigurationManager.AppSettings["db_server"];
                string db = ConfigurationManager.AppSettings["db_name"];
                string user = ConfigurationManager.AppSettings["db_user"];
                string password = ConfigurationManager.AppSettings["db_password"];

                _instance = new Database(server, db, user, password);
                _instance.OpenConnection();
            }

            return _instance.valeurconnexion();
        }

        public static Database GetDatabaseInstance()
        {
            if (_instance == null)
            {
                string server = ConfigurationManager.AppSettings["db_server"];
                string db = ConfigurationManager.AppSettings["db_name"];
                string user = ConfigurationManager.AppSettings["db_user"];
                string password = ConfigurationManager.AppSettings["db_password"];

                _instance = new Database(server, db, user, password);
                _instance.OpenConnection();
            }

            return _instance;
        }
    }
}