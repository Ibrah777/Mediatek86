namespace mediatek86.view
{
    partial class FrmMediaTek
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            // Panel gauche — Personnel
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grpInfosPersonnel = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.btnAjouterPerso = new System.Windows.Forms.Button();
            this.btnModifierPerso = new System.Windows.Forms.Button();
            this.btnSupprimerPerso = new System.Windows.Forms.Button();
            this.btnGererAbsences = new System.Windows.Forms.Button();
            // Panel droit — Absences
            this.grpAbsences = new System.Windows.Forms.GroupBox();
            this.lblPersonnelAbsences = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grpInfosAbsence = new System.Windows.Forms.GroupBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();

            this.grpPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grpInfosPersonnel.SuspendLayout();
            this.grpAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grpInfosAbsence.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitre ────────────────────────────────────────────────────────
            this.lblTitre.AutoSize = false;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(0, 8);
            this.lblTitre.Size = new System.Drawing.Size(1100, 30);
            this.lblTitre.Text = "MediaTek86 — Gestion du personnel";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── grpPersonnel ────────────────────────────────────────────────────
            this.grpPersonnel.Location = new System.Drawing.Point(10, 45);
            this.grpPersonnel.Size = new System.Drawing.Size(520, 620);
            this.grpPersonnel.Text = "Personnel";
            this.grpPersonnel.Controls.Add(this.dgvPersonnel);
            this.grpPersonnel.Controls.Add(this.grpInfosPersonnel);
            this.grpPersonnel.Controls.Add(this.btnAjouterPerso);
            this.grpPersonnel.Controls.Add(this.btnModifierPerso);
            this.grpPersonnel.Controls.Add(this.btnSupprimerPerso);
            this.grpPersonnel.Controls.Add(this.btnGererAbsences);

            // dgvPersonnel
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonnel.Location = new System.Drawing.Point(10, 20);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(500, 200);
            this.dgvPersonnel.SelectionChanged += new System.EventHandler(this.dgvPersonnel_SelectionChanged);

            // grpInfosPersonnel
            this.grpInfosPersonnel.Location = new System.Drawing.Point(10, 230);
            this.grpInfosPersonnel.Size = new System.Drawing.Size(500, 185);
            this.grpInfosPersonnel.Text = "Informations";
            this.grpInfosPersonnel.Controls.Add(this.lblNom);
            this.grpInfosPersonnel.Controls.Add(this.txtNom);
            this.grpInfosPersonnel.Controls.Add(this.lblPrenom);
            this.grpInfosPersonnel.Controls.Add(this.txtPrenom);
            this.grpInfosPersonnel.Controls.Add(this.lblTel);
            this.grpInfosPersonnel.Controls.Add(this.txtTel);
            this.grpInfosPersonnel.Controls.Add(this.lblMail);
            this.grpInfosPersonnel.Controls.Add(this.txtMail);
            this.grpInfosPersonnel.Controls.Add(this.lblService);
            this.grpInfosPersonnel.Controls.Add(this.cboService);

            int lx = 10; int tx = 110; int tw = 180;
            this.lblNom.AutoSize = true; this.lblNom.Location = new System.Drawing.Point(lx, 28); this.lblNom.Text = "Nom :";
            this.txtNom.Location = new System.Drawing.Point(tx, 25); this.txtNom.Size = new System.Drawing.Size(tw, 23); this.txtNom.Name = "txtNom";
            this.lblPrenom.AutoSize = true; this.lblPrenom.Location = new System.Drawing.Point(lx, 60); this.lblPrenom.Text = "Prénom :";
            this.txtPrenom.Location = new System.Drawing.Point(tx, 57); this.txtPrenom.Size = new System.Drawing.Size(tw, 23); this.txtPrenom.Name = "txtPrenom";
            this.lblTel.AutoSize = true; this.lblTel.Location = new System.Drawing.Point(lx, 92); this.lblTel.Text = "Téléphone :";
            this.txtTel.Location = new System.Drawing.Point(tx, 89); this.txtTel.Size = new System.Drawing.Size(tw, 23); this.txtTel.Name = "txtTel";
            this.lblMail.AutoSize = true; this.lblMail.Location = new System.Drawing.Point(lx, 124); this.lblMail.Text = "Mail :";
            this.txtMail.Location = new System.Drawing.Point(tx, 121); this.txtMail.Size = new System.Drawing.Size(tw, 23); this.txtMail.Name = "txtMail";
            this.lblService.AutoSize = true; this.lblService.Location = new System.Drawing.Point(lx, 156); this.lblService.Text = "Service :";
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Location = new System.Drawing.Point(tx, 153); this.cboService.Size = new System.Drawing.Size(tw, 23); this.cboService.Name = "cboService";

            this.btnAjouterPerso.Location = new System.Drawing.Point(10, 425); this.btnAjouterPerso.Size = new System.Drawing.Size(110, 28); this.btnAjouterPerso.Text = "Ajouter"; this.btnAjouterPerso.Click += new System.EventHandler(this.btnAjouterPerso_Click);
            this.btnModifierPerso.Location = new System.Drawing.Point(130, 425); this.btnModifierPerso.Size = new System.Drawing.Size(110, 28); this.btnModifierPerso.Text = "Modifier"; this.btnModifierPerso.Click += new System.EventHandler(this.btnModifierPerso_Click);
            this.btnSupprimerPerso.Location = new System.Drawing.Point(250, 425); this.btnSupprimerPerso.Size = new System.Drawing.Size(110, 28); this.btnSupprimerPerso.Text = "Supprimer"; this.btnSupprimerPerso.Click += new System.EventHandler(this.btnSupprimerPerso_Click);
            this.btnGererAbsences.Location = new System.Drawing.Point(10, 465); this.btnGererAbsences.Size = new System.Drawing.Size(200, 28); this.btnGererAbsences.Text = "Gérer les absences →"; this.btnGererAbsences.Click += new System.EventHandler(this.btnGererAbsences_Click);

            // ── grpAbsences ─────────────────────────────────────────────────────
            this.grpAbsences.Location = new System.Drawing.Point(545, 45);
            this.grpAbsences.Size = new System.Drawing.Size(540, 620);
            this.grpAbsences.Text = "Absences";
            this.grpAbsences.Enabled = false;
            this.grpAbsences.Controls.Add(this.lblPersonnelAbsences);
            this.grpAbsences.Controls.Add(this.dgvAbsences);
            this.grpAbsences.Controls.Add(this.grpInfosAbsence);
            this.grpAbsences.Controls.Add(this.btnAjouterAbs);
            this.grpAbsences.Controls.Add(this.btnModifierAbs);
            this.grpAbsences.Controls.Add(this.btnSupprimerAbs);

            this.lblPersonnelAbsences.AutoSize = false;
            this.lblPersonnelAbsences.Location = new System.Drawing.Point(10, 18);
            this.lblPersonnelAbsences.Size = new System.Drawing.Size(520, 20);
            this.lblPersonnelAbsences.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPersonnelAbsences.Text = "";
            this.lblPersonnelAbsences.Name = "lblPersonnelAbsences";

            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbsences.Location = new System.Drawing.Point(10, 40);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(520, 200);
            this.dgvAbsences.SelectionChanged += new System.EventHandler(this.dgvAbsences_SelectionChanged);

            this.grpInfosAbsence.Location = new System.Drawing.Point(10, 250);
            this.grpInfosAbsence.Size = new System.Drawing.Size(520, 140);
            this.grpInfosAbsence.Text = "Informations absence";
            this.grpInfosAbsence.Controls.Add(this.lblDateDebut);
            this.grpInfosAbsence.Controls.Add(this.dtpDateDebut);
            this.grpInfosAbsence.Controls.Add(this.lblDateFin);
            this.grpInfosAbsence.Controls.Add(this.dtpDateFin);
            this.grpInfosAbsence.Controls.Add(this.lblMotif);
            this.grpInfosAbsence.Controls.Add(this.cboMotif);

            this.lblDateDebut.AutoSize = true; this.lblDateDebut.Location = new System.Drawing.Point(10, 28); this.lblDateDebut.Text = "Date début :";
            this.dtpDateDebut.Location = new System.Drawing.Point(110, 25); this.dtpDateDebut.Size = new System.Drawing.Size(150, 23); this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblDateFin.AutoSize = true; this.lblDateFin.Location = new System.Drawing.Point(10, 65); this.lblDateFin.Text = "Date fin :";
            this.dtpDateFin.Location = new System.Drawing.Point(110, 62); this.dtpDateFin.Size = new System.Drawing.Size(150, 23); this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblMotif.AutoSize = true; this.lblMotif.Location = new System.Drawing.Point(10, 100); this.lblMotif.Text = "Motif :";
            this.cboMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotif.Location = new System.Drawing.Point(110, 97); this.cboMotif.Size = new System.Drawing.Size(200, 23); this.cboMotif.Name = "cboMotif";

            this.btnAjouterAbs.Location = new System.Drawing.Point(10, 405); this.btnAjouterAbs.Size = new System.Drawing.Size(110, 28); this.btnAjouterAbs.Text = "Ajouter"; this.btnAjouterAbs.Click += new System.EventHandler(this.btnAjouterAbs_Click);
            this.btnModifierAbs.Location = new System.Drawing.Point(130, 405); this.btnModifierAbs.Size = new System.Drawing.Size(110, 28); this.btnModifierAbs.Text = "Modifier"; this.btnModifierAbs.Click += new System.EventHandler(this.btnModifierAbs_Click);
            this.btnSupprimerAbs.Location = new System.Drawing.Point(250, 405); this.btnSupprimerAbs.Size = new System.Drawing.Size(110, 28); this.btnSupprimerAbs.Text = "Supprimer"; this.btnSupprimerAbs.Click += new System.EventHandler(this.btnSupprimerAbs_Click);

            // ── FrmMediaTek ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.grpPersonnel);
            this.Controls.Add(this.grpAbsences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMediaTek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86 — Gestion du personnel";
            this.Load += new System.EventHandler(this.FrmMediaTek_Load);

            this.grpPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grpInfosPersonnel.ResumeLayout(false);
            this.grpInfosPersonnel.PerformLayout();
            this.grpAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grpInfosAbsence.ResumeLayout(false);
            this.grpInfosAbsence.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.GroupBox grpInfosPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Button btnAjouterPerso;
        private System.Windows.Forms.Button btnModifierPerso;
        private System.Windows.Forms.Button btnSupprimerPerso;
        private System.Windows.Forms.Button btnGererAbsences;
        private System.Windows.Forms.GroupBox grpAbsences;
        private System.Windows.Forms.Label lblPersonnelAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grpInfosAbsence;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnSupprimerAbs;
    }
}
