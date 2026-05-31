namespace mediatek86.model
{
    /// <summary>
    /// Classe représentant un motif d'absence
    /// </summary>
    public class Motif
    {
        /// <summary>Identifiant du motif</summary>
        public int IdMotif { get; set; }

        /// <summary>Libellé du motif</summary>
        public string LibelleMotif { get; set; }

        /// <summary>Constructeur vide</summary>
        public Motif() { }

        /// <summary>Constructeur avec paramètres</summary>
        public Motif(int idMotif, string libelleMotif)
        {
            IdMotif = idMotif;
            LibelleMotif = libelleMotif;
        }

        /// <summary>Affichage du libellé</summary>
        public override string ToString() => LibelleMotif;
    }
}
