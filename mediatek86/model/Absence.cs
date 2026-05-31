using System;

namespace mediatek86.model
{
    /// <summary>
    /// Classe représentant une absence d'un membre du personnel
    /// </summary>
    public class Absence
    {
        /// <summary>Identifiant de l'absence</summary>
        public int IdAbsence { get; set; }

        /// <summary>Date de début</summary>
        public DateTime DateDebut { get; set; }

        /// <summary>Date de fin</summary>
        public DateTime DateFin { get; set; }

        /// <summary>Motif de l'absence</summary>
        public Motif LeMotif { get; set; }

        /// <summary>Identifiant du personnel concerné</summary>
        public int IdPersonnel { get; set; }

        /// <summary>Constructeur vide</summary>
        public Absence() { }

        /// <summary>Constructeur avec paramètres</summary>
        public Absence(int idAbsence, DateTime dateDebut, DateTime dateFin, Motif leMotif, int idPersonnel)
        {
            IdAbsence = idAbsence;
            DateDebut = dateDebut;
            DateFin = dateFin;
            LeMotif = leMotif;
            IdPersonnel = idPersonnel;
        }
    }
}
