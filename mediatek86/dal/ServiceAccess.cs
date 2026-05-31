using mediatek86.model;
using System.Collections.Generic;

namespace mediatek86.dal
{
    /// <summary>
    /// Accès aux données pour la table service
    /// </summary>
    public class ServiceAccess : Access
    {
        /// <summary>
        /// Retourne tous les services
        /// </summary>
        public List<Service> GetAllServices()
        {
            List<Service> services = new List<Service>();
            string query = "SELECT idservice, nomservice FROM service ORDER BY nomservice;";
            List<Dictionary<string, object>> records = bddManager.ReqSelect(query);
            foreach (Dictionary<string, object> record in records)
            {
                services.Add(new Service(
                    (int)record["idservice"],
                    record["nomservice"].ToString()
                ));
            }
            return services;
        }
    }
}
