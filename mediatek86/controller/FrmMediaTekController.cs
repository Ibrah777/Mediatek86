using mediatek86.dal;
using mediatek86.model;
using System;
using System.Collections.Generic;

namespace mediatek86.controller
{
    /// <summary>
    /// Contrôleur principal — fait le lien entre les vues et les classes DAL
    /// </summary>
    public class FrmMediaTekController
    {
        private readonly ResponsableAccess responsableAccess = new ResponsableAccess();
        private readonly PersonnelAccess personnelAccess = new PersonnelAccess();
        private readonly ServiceAccess serviceAccess = new ServiceAccess();
        private readonly AbsenceAccess absenceAccess = new AbsenceAccess();
        private readonly MotifAccess motifAccess = new MotifAccess();

        // ── CONNEXION ─────────────────────────────────────────────────
        /// <summary>Vérifie les identifiants du responsable</summary>
        public bool VerifierConnexion(string login, string pwd)
        {
            return responsableAccess.VerifierConnexion(login, pwd);
        }

        // ── PERSONNEL ─────────────────────────────────────────────────
        /// <summary>Retourne tous les membres du personnel</summary>
        public List<Personnel> GetAllPersonnel()
        {
            return personnelAccess.GetAllPersonnel();
        }

        /// <summary>Retourne tous les services</summary>
        public List<Service> GetAllServices()
        {
            return serviceAccess.GetAllServices();
        }

        /// <summary>Ajoute un membre du personnel</summary>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>Modifie un membre du personnel</summary>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>Supprime un membre du personnel</summary>
        public void DeletePersonnel(int idPersonnel)
        {
            personnelAccess.DeletePersonnel(idPersonnel);
        }

        // ── ABSENCES ──────────────────────────────────────────────────
        /// <summary>Retourne les absences d'un personnel</summary>
        public List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            return absenceAccess.GetAbsencesByPersonnel(idPersonnel);
        }

        /// <summary>Retourne tous les motifs d'absence</summary>
        public List<Motif> GetAllMotifs()
        {
            return motifAccess.GetAllMotifs();
        }

        /// <summary>Ajoute une absence — retourne false si chevauchement</summary>
        public bool AddAbsence(Absence absence)
        {
            return absenceAccess.AddAbsence(absence);
        }

        /// <summary>Modifie une absence — retourne false si chevauchement</summary>
        public bool UpdateAbsence(Absence absence)
        {
            return absenceAccess.UpdateAbsence(absence);
        }

        /// <summary>Supprime une absence</summary>
        public void DeleteAbsence(int idAbsence)
        {
            absenceAccess.DeleteAbsence(idAbsence);
        }
    }
}
