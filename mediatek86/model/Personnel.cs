namespace mediatek86.model
{
    /// <summary>
    /// Classe représentant un membre du personnel de la médiathèque
    /// </summary>
    public class Personnel
    {
        /// <summary>Identifiant du personnel</summary>
        public int IdPersonnel { get; set; }

        /// <summary>Nom</summary>
        public string Nom { get; set; }

        /// <summary>Prénom</summary>
        public string Prenom { get; set; }

        /// <summary>Téléphone</summary>
        public string Tel { get; set; }

        /// <summary>Adresse mail</summary>
        public string Mail { get; set; }

        /// <summary>Service d'affectation</summary>
        public Service LeService { get; set; }

        /// <summary>Constructeur vide</summary>
        public Personnel() { }

        /// <summary>Constructeur avec paramètres</summary>
        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail, Service leService)
        {
            IdPersonnel = idPersonnel;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            LeService = leService;
        }

        /// <summary>Affichage nom prénom</summary>
        public override string ToString() => Nom + " " + Prenom;
    }
}
