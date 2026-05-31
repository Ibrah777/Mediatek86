namespace mediatek86.model
{
    /// <summary>
    /// Classe représentant le responsable (connexion)
    /// </summary>
    public class Responsable
    {
        /// <summary>Login du responsable</summary>
        public string Login { get; set; }

        /// <summary>Mot de passe hashé (SHA2-256)</summary>
        public string Pwd { get; set; }

        /// <summary>Constructeur vide</summary>
        public Responsable() { }

        /// <summary>Constructeur avec paramètres</summary>
        public Responsable(string login, string pwd)
        {
            Login = login;
            Pwd = pwd;
        }
    }
}
