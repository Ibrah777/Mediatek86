namespace mediatek86.model
{
    /// <summary>
    /// Classe représentant un service de la médiathèque
    /// </summary>
    public class Service
    {
        /// <summary>Identifiant du service</summary>
        public int IdService { get; set; }

        /// <summary>Nom du service</summary>
        public string NomService { get; set; }

        /// <summary>Constructeur vide</summary>
        public Service() { }

        /// <summary>Constructeur avec paramètres</summary>
        public Service(int idService, string nomService)
        {
            IdService = idService;
            NomService = nomService;
        }

        /// <summary>Affichage du nom du service</summary>
        public override string ToString() => NomService;
    }
}

// Mod�le repr�sentant un service
