using mediatek86.model;
using System;
using System.Collections.Generic;

namespace mediatek86.dal
{
    /// <summary>
    /// Accès aux données pour la table absence
    /// </summary>
    public class AbsenceAccess : Access
    {
        /// <summary>
        /// Retourne les absences d'un personnel, ordre chronologique inverse
        /// </summary>
        public List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            List<Absence> absences = new List<Absence>();
            string query = @"SELECT a.idabsence, a.datedebut, a.datefin,
                                    m.idmotif, m.libelle
                             FROM absence a
                             JOIN motif m ON a.idmotif = m.idmotif
                             WHERE a.idpersonnel = @idpersonnel
                             ORDER BY a.datedebut DESC;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel }
            };
            List<Dictionary<string, object>> records = bddManager.ReqSelect(query, parameters);
            foreach (Dictionary<string, object> record in records)
            {
                Motif motif = new Motif((int)record["idmotif"], record["libelle"].ToString());
                absences.Add(new Absence(
                    (int)record["idabsence"],
                    Convert.ToDateTime(record["datedebut"]),
                    Convert.ToDateTime(record["datefin"]),
                    motif,
                    idPersonnel
                ));
            }
            return absences;
        }

        /// <summary>
        /// Ajoute une absence — vérifie les chevauchements
        /// </summary>
        public bool AddAbsence(Absence absence)
        {
            if (ChevauchementsExistants(absence.IdPersonnel, absence.DateDebut, absence.DateFin, 0))
                return false;

            string query = "INSERT INTO absence (datedebut, datefin, idmotif, idpersonnel) VALUES (@debut, @fin, @idmotif, @idpersonnel);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@debut",       absence.DateDebut.ToString("yyyy-MM-dd") },
                { "@fin",         absence.DateFin.ToString("yyyy-MM-dd") },
                { "@idmotif",     absence.LeMotif.IdMotif },
                { "@idpersonnel", absence.IdPersonnel }
            };
            bddManager.ReqUpdate(query, parameters);
            return true;
        }

        /// <summary>
        /// Modifie une absence — vérifie les chevauchements (en excluant l'absence elle-même)
        /// </summary>
        public bool UpdateAbsence(Absence absence)
        {
            if (ChevauchementsExistants(absence.IdPersonnel, absence.DateDebut, absence.DateFin, absence.IdAbsence))
                return false;

            string query = "UPDATE absence SET datedebut=@debut, datefin=@fin, idmotif=@idmotif WHERE idabsence=@id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@debut",   absence.DateDebut.ToString("yyyy-MM-dd") },
                { "@fin",     absence.DateFin.ToString("yyyy-MM-dd") },
                { "@idmotif", absence.LeMotif.IdMotif },
                { "@id",      absence.IdAbsence }
            };
            bddManager.ReqUpdate(query, parameters);
            return true;
        }

        /// <summary>
        /// Supprime une absence
        /// </summary>
        public void DeleteAbsence(int idAbsence)
        {
            bddManager.ReqUpdate("DELETE FROM absence WHERE idabsence=@id;",
                new Dictionary<string, object> { { "@id", idAbsence } });
        }

        /// <summary>
        /// Vérifie si un créneau chevauche une absence existante pour ce personnel
        /// </summary>
        private bool ChevauchementsExistants(int idPersonnel, DateTime debut, DateTime fin, int idExclure)
        {
            string query = @"SELECT COUNT(*) as nb FROM absence
                             WHERE idpersonnel = @idpersonnel
                             AND idabsence <> @idexclure
                             AND NOT (datefin < @debut OR datedebut > @fin);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel },
                { "@idexclure",   idExclure },
                { "@debut",       debut.ToString("yyyy-MM-dd") },
                { "@fin",         fin.ToString("yyyy-MM-dd") }
            };
            List<Dictionary<string, object>> result = bddManager.ReqSelect(query, parameters);
            return result.Count > 0 && Convert.ToInt32(result[0]["nb"]) > 0;
        }
    }
}
