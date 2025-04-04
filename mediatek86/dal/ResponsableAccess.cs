using mediatek86.model;
using System.Collections.Generic;

namespace mediatek86.dal
{
    /// <summary>
    /// Accès aux données pour la table responsable
    /// </summary>
    public class ResponsableAccess : Access
    {
        /// <summary>
        /// Vérifie les identifiants de connexion (pwd hashé en SHA2-256 côté SQL)
        /// </summary>
        public bool VerifierConnexion(string login, string pwd)
        {
            string query = "SELECT COUNT(*) as nb FROM responsable WHERE login=@login AND pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@pwd",   pwd }
            };
            List<Dictionary<string, object>> result = bddManager.ReqSelect(query, parameters);
            return result.Count > 0 && System.Convert.ToInt32(result[0]["nb"]) > 0;
        }
    }
}

// Acc�s aux donn�es du responsable
