using mediatek86.model;
using System.Collections.Generic;

namespace mediatek86.dal
{
    /// <summary>
    /// Accès aux données pour la table personnel
    /// </summary>
    public class PersonnelAccess : Access
    {
        /// <summary>
        /// Retourne tous les membres du personnel avec leur service
        /// </summary>
        public List<Personnel> GetAllPersonnel()
        {
            List<Personnel> listePersonnel = new List<Personnel>();
            string query = @"SELECT p.idpersonnel, p.nom, p.prenom, p.tel, p.mail,
                                    s.idservice, s.nomservice
                             FROM personnel p
                             JOIN service s ON p.idservice = s.idservice
                             ORDER BY p.nom, p.prenom;";
            List<Dictionary<string, object>> records = bddManager.ReqSelect(query);
            foreach (Dictionary<string, object> record in records)
            {
                Service service = new Service((int)record["idservice"], record["nomservice"].ToString());
                listePersonnel.Add(new Personnel(
                    (int)record["idpersonnel"],
                    record["nom"].ToString(),
                    record["prenom"].ToString(),
                    record["tel"].ToString(),
                    record["mail"].ToString(),
                    service
                ));
            }
            return listePersonnel;
        }

        /// <summary>
        /// Ajoute un membre du personnel
        /// </summary>
        public void AddPersonnel(Personnel personnel)
        {
            string query = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom",       personnel.Nom },
                { "@prenom",    personnel.Prenom },
                { "@tel",       personnel.Tel },
                { "@mail",      personnel.Mail },
                { "@idservice", personnel.LeService.IdService }
            };
            bddManager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Modifie un membre du personnel
        /// </summary>
        public void UpdatePersonnel(Personnel personnel)
        {
            string query = "UPDATE personnel SET nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idservice=@idservice WHERE idpersonnel=@id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom",       personnel.Nom },
                { "@prenom",    personnel.Prenom },
                { "@tel",       personnel.Tel },
                { "@mail",      personnel.Mail },
                { "@idservice", personnel.LeService.IdService },
                { "@id",        personnel.IdPersonnel }
            };
            bddManager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Supprime un membre du personnel (et ses absences par CASCADE)
        /// </summary>
        public void DeletePersonnel(int idPersonnel)
        {
            string query = "DELETE FROM personnel WHERE idpersonnel=@id;";
            bddManager.ReqUpdate(query, new Dictionary<string, object> { { "@id", idPersonnel } });
        }
    }
}
