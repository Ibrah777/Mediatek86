using mediatek86.bddmanager;
using System.Configuration;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe mère des classes DAL — fournit l'accès au BddManager
    /// </summary>
    public class Access
    {
        /// <summary>Chaîne de connexion lue depuis App.config</summary>
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["mediatek86"].ConnectionString;

        /// <summary>Instance du gestionnaire de BDD</summary>
        protected readonly BddManager bddManager = BddManager.GetInstance(connectionString);
    }
}
