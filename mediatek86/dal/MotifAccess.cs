using mediatek86.model;
using System.Collections.Generic;

namespace mediatek86.dal
{
    /// <summary>
    /// AccÃ¨s aux donnÃ©es pour la table motif
    /// </summary>
    public class MotifAccess : Access
    {
        /// <summary>
        /// Retourne tous les motifs d'absence
        /// </summary>
        public List<Motif> GetAllMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            string query = "SELECT idmotif, libelle FROM motif ORDER BY libelle;";
            List<Dictionary<string, object>> records = bddManager.ReqSelect(query);
            foreach (Dictionary<string, object> record in records)
            {
                motifs.Add(new Motif(
                    (int)record["idmotif"],
                    record["libelle"].ToString()
                ));
            }
            return motifs;
        }
    }
}

// Accès aux données des motifs
