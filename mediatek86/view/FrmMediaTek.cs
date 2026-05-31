using mediatek86.controller;
using mediatek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mediatek86.view
{
    /// <summary>
    /// Fenêtre principale — gestion du personnel et des absences
    /// </summary>
    public partial class FrmMediaTek : Form
    {
        private readonly FrmMediaTekController controller = new FrmMediaTekController();
        private List<Personnel> lesPersonnels;
        private List<Service> lesServices;
        private List<Absence> lesAbsences;
        private List<Motif> lesMotifs;
        private Personnel personnelSelectionne = null;

        /// <summary>Constructeur</summary>
        public FrmMediaTek()
        {
            InitializeComponent();
        }

        // ── CHARGEMENT ────────────────────────────────────────────────
        private void FrmMediaTek_Load(object sender, EventArgs e)
        {
            ChargerServices();
            ChargerMotifs();
            ChargerPersonnel();
        }

        private void ChargerServices()
        {
            lesServices = controller.GetAllServices();
            cboService.DataSource = new List<Service>(lesServices);
            cboService.DisplayMember = "NomService";
            cboService.ValueMember = "IdService";
        }

        private void ChargerMotifs()
        {
            lesMotifs = controller.GetAllMotifs();
            cboMotif.DataSource = new List<Motif>(lesMotifs);
            cboMotif.DisplayMember = "LibelleMotif";
            cboMotif.ValueMember = "IdMotif";
        }

        private void ChargerPersonnel()
        {
            lesPersonnels = controller.GetAllPersonnel();
            dgvPersonnel.DataSource = null;
            dgvPersonnel.Rows.Clear();
            dgvPersonnel.Columns.Clear();
            dgvPersonnel.Columns.Add("colNom", "Nom");
            dgvPersonnel.Columns.Add("colPrenom", "Prénom");
            dgvPersonnel.Columns.Add("colTel", "Téléphone");
            dgvPersonnel.Columns.Add("colMail", "Mail");
            dgvPersonnel.Columns.Add("colService", "Service");
            foreach (Personnel p in lesPersonnels)
                dgvPersonnel.Rows.Add(p.Nom, p.Prenom, p.Tel, p.Mail, p.LeService.NomService);
            if (dgvPersonnel.Rows.Count > 0)
                dgvPersonnel.Rows[0].Selected = true;
        }

        private void ChargerAbsences(int idPersonnel)
        {
            lesAbsences = controller.GetAbsencesByPersonnel(idPersonnel);
            dgvAbsences.DataSource = null;
            dgvAbsences.Rows.Clear();
            dgvAbsences.Columns.Clear();
            dgvAbsences.Columns.Add("colDebut", "Date début");
            dgvAbsences.Columns.Add("colFin", "Date fin");
            dgvAbsences.Columns.Add("colMotif", "Motif");
            foreach (Absence a in lesAbsences)
                dgvAbsences.Rows.Add(a.DateDebut.ToString("dd/MM/yyyy"), a.DateFin.ToString("dd/MM/yyyy"), a.LeMotif.LibelleMotif);
            if (dgvAbsences.Rows.Count > 0)
                dgvAbsences.Rows[0].Selected = true;
        }

        // ── SÉLECTION PERSONNEL ───────────────────────────────────────
        private void dgvPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0) return;
            int idx = dgvPersonnel.SelectedRows[0].Index;
            if (idx >= lesPersonnels.Count) return;
            Personnel p = lesPersonnels[idx];
            txtNom.Text = p.Nom;
            txtPrenom.Text = p.Prenom;
            txtTel.Text = p.Tel;
            txtMail.Text = p.Mail;
            cboService.SelectedValue = p.LeService.IdService;
            // Désactiver le panneau absences quand on change de personnel
            grpAbsences.Enabled = false;
            lblPersonnelAbsences.Text = "";
            dgvAbsences.Rows.Clear();
        }

        // ── BOUTONS PERSONNEL ─────────────────────────────────────────
        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            if (!SaisiePersonnelValide()) return;
            Service svc = (Service)cboService.SelectedItem;
            Personnel p = new Personnel(0, txtNom.Text.Trim(), txtPrenom.Text.Trim(),
                txtTel.Text.Trim(), txtMail.Text.Trim(), svc);
            controller.AddPersonnel(p);
            ChargerPersonnel();
        }

        private void btnModifierPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0) return;
            if (!SaisiePersonnelValide()) return;
            DialogResult res = MessageBox.Show("Confirmer la modification ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            Personnel p = lesPersonnels[dgvPersonnel.SelectedRows[0].Index];
            p.Nom = txtNom.Text.Trim();
            p.Prenom = txtPrenom.Text.Trim();
            p.Tel = txtTel.Text.Trim();
            p.Mail = txtMail.Text.Trim();
            p.LeService = (Service)cboService.SelectedItem;
            controller.UpdatePersonnel(p);
            ChargerPersonnel();
        }

        private void btnSupprimerPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0) return;
            Personnel p = lesPersonnels[dgvPersonnel.SelectedRows[0].Index];
            DialogResult res = MessageBox.Show(
                $"Supprimer {p.Prenom} {p.Nom} et toutes ses absences ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            controller.DeletePersonnel(p.IdPersonnel);
            grpAbsences.Enabled = false;
            ChargerPersonnel();
        }

        private void btnGererAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0) return;
            personnelSelectionne = lesPersonnels[dgvPersonnel.SelectedRows[0].Index];
            lblPersonnelAbsences.Text = $"Personnel : {personnelSelectionne.Prenom} {personnelSelectionne.Nom}";
            grpAbsences.Enabled = true;
            ChargerAbsences(personnelSelectionne.IdPersonnel);
        }

        // ── SÉLECTION ABSENCE ─────────────────────────────────────────
        private void dgvAbsences_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count == 0 || lesAbsences == null) return;
            int idx = dgvAbsences.SelectedRows[0].Index;
            if (idx >= lesAbsences.Count) return;
            Absence a = lesAbsences[idx];
            dtpDateDebut.Value = a.DateDebut;
            dtpDateFin.Value = a.DateFin;
            cboMotif.SelectedValue = a.LeMotif.IdMotif;
        }

        // ── BOUTONS ABSENCES ──────────────────────────────────────────
        private void btnAjouterAbs_Click(object sender, EventArgs e)
        {
            if (personnelSelectionne == null) return;
            if (!SaisieAbsenceValide()) return;
            Motif motif = (Motif)cboMotif.SelectedItem;
            Absence a = new Absence(0, dtpDateDebut.Value.Date, dtpDateFin.Value.Date, motif, personnelSelectionne.IdPersonnel);
            if (!controller.AddAbsence(a))
            {
                MessageBox.Show("Une absence est déjà programmée sur ce créneau.", "Conflit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ChargerAbsences(personnelSelectionne.IdPersonnel);
        }

        private void btnModifierAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count == 0 || lesAbsences == null) return;
            if (!SaisieAbsenceValide()) return;
            DialogResult res = MessageBox.Show("Confirmer la modification ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            Absence a = lesAbsences[dgvAbsences.SelectedRows[0].Index];
            a.DateDebut = dtpDateDebut.Value.Date;
            a.DateFin = dtpDateFin.Value.Date;
            a.LeMotif = (Motif)cboMotif.SelectedItem;
            if (!controller.UpdateAbsence(a))
            {
                MessageBox.Show("Une absence est déjà programmée sur ce créneau.", "Conflit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ChargerAbsences(personnelSelectionne.IdPersonnel);
        }

        private void btnSupprimerAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count == 0 || lesAbsences == null) return;
            DialogResult res = MessageBox.Show("Supprimer cette absence ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            Absence a = lesAbsences[dgvAbsences.SelectedRows[0].Index];
            controller.DeleteAbsence(a.IdAbsence);
            ChargerAbsences(personnelSelectionne.IdPersonnel);
        }

        // ── VALIDATION ────────────────────────────────────────────────
        private bool SaisiePersonnelValide()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text)
                || string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Nom, prénom et mail sont obligatoires.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool SaisieAbsenceValide()
        {
            if (dtpDateFin.Value.Date < dtpDateDebut.Value.Date)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
