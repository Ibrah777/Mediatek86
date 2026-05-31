using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace mediatek86.bddmanager
{
    /// <summary>
    /// Singleton : connexion à la base de données et exécution des requêtes
    /// </summary>
    public class BddManager
    {
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static BddManager instance = null;

        /// <summary>
        /// objet de connexion à la BDD
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Constructeur privé — ouvre la connexion
        /// </summary>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Retourne l'instance unique (pattern Singleton)
        /// </summary>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
                instance = new BddManager(stringConnect);
            return instance;
        }

        /// <summary>
        /// Exécution d'un SELECT — retourne une liste de dictionnaires
        /// </summary>
        public List<Dictionary<string, object>> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parameters is null))
                foreach (KeyValuePair<string, object> p in parameters)
                    command.Parameters.Add(new MySqlParameter(p.Key, p.Value));
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Dictionary<string, object> record = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    record[reader.GetName(i)] = reader.GetValue(i);
                records.Add(record);
            }
            reader.Close();
            return records;
        }

        /// <summary>
        /// Exécution d'une requête INSERT, UPDATE ou DELETE
        /// </summary>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parameters is null))
                foreach (KeyValuePair<string, object> p in parameters)
                    command.Parameters.Add(new MySqlParameter(p.Key, p.Value));
            command.Prepare();
            command.ExecuteNonQuery();
        }
    }
}
