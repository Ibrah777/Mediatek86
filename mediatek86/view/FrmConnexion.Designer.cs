namespace mediatek86.view
{
    partial class FrmConnexion
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitre
            this.lblTitre.AutoSize = false;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(0, 20);
            this.lblTitre.Size = new System.Drawing.Size(360, 30);
            this.lblTitre.Text = "MediaTek86 — Connexion";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(40, 75);
            this.lblLogin.Text = "Login :";

            // txtLogin
            this.txtLogin.Location = new System.Drawing.Point(130, 72);
            this.txtLogin.Size = new System.Drawing.Size(180, 23);
            this.txtLogin.Name = "txtLogin";

            // lblPwd
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(40, 115);
            this.lblPwd.Text = "Mot de passe :";

            // txtPwd
            this.txtPwd.Location = new System.Drawing.Point(130, 112);
            this.txtPwd.Size = new System.Drawing.Size(180, 23);
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Name = "txtPwd";

            // btnConnexion
            this.btnConnexion.Location = new System.Drawing.Point(80, 160);
            this.btnConnexion.Size = new System.Drawing.Size(90, 30);
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);

            // btnAnnuler
            this.btnAnnuler.Location = new System.Drawing.Point(190, 160);
            this.btnAnnuler.Size = new System.Drawing.Size(90, 30);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);

            // FrmConnexion
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.AcceptButton = this.btnConnexion;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
