using mediatek86.controller;
using System;
using System.Windows.Forms;

namespace mediatek86.view
{
    /// <summary>
    /// Fenêtre de connexion du responsable
    /// </summary>
    public partial class FrmConnexion : Form
    {
        private readonly FrmMediaTekController controller = new FrmMediaTekController();

        /// <summary>Constructeur</summary>
        public FrmConnexion()
        {
            InitializeComponent();
        }

        /// <summary>Clic sur Connexion — vérifie les identifiants</summary>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (controller.VerifierConnexion(txtLogin.Text.Trim(), txtPwd.Text))
            {
                FrmMediaTek frmMediaTek = new FrmMediaTek();
                this.Hide();
                frmMediaTek.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.", "Erreur de connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Clear();
                txtPwd.Focus();
            }
        }

        /// <summary>Clic sur Annuler — ferme l'application</summary>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
