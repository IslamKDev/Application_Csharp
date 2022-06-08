namespace AppGsb.Presentations.Connexion
{
    partial class Fconnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lbConnexion = new System.Windows.Forms.Label();
            this.bt_valider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_motdepasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_login.Location = new System.Drawing.Point(272, 76);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(201, 20);
            this.tb_login.TabIndex = 8;
            // 
            // lbConnexion
            // 
            this.lbConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbConnexion.AutoSize = true;
            this.lbConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnexion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnexion.Location = new System.Drawing.Point(12, 20);
            this.lbConnexion.Name = "lbConnexion";
            this.lbConnexion.Size = new System.Drawing.Size(629, 31);
            this.lbConnexion.TabIndex = 9;
            this.lbConnexion.Text = "Connexion a l\'application Galaxy Swiss Bourdin";
            // 
            // bt_valider
            // 
            this.bt_valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valider.ForeColor = System.Drawing.Color.GreenYellow;
            this.bt_valider.Location = new System.Drawing.Point(115, 189);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(89, 36);
            this.bt_valider.TabIndex = 12;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(384, 189);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 13;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // tbMdp
            // 
            this.tbMdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMdp.Location = new System.Drawing.Point(272, 141);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(201, 20);
            this.tbMdp.TabIndex = 14;
            this.tbMdp.UseSystemPasswordChar = true;
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_login.Location = new System.Drawing.Point(180, 76);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(63, 20);
            this.lb_login.TabIndex = 15;
            this.lb_login.Text = "Login :";
            // 
            // lb_motdepasse
            // 
            this.lb_motdepasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_motdepasse.AutoSize = true;
            this.lb_motdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_motdepasse.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_motdepasse.Location = new System.Drawing.Point(111, 141);
            this.lb_motdepasse.Name = "lb_motdepasse";
            this.lb_motdepasse.Size = new System.Drawing.Size(132, 20);
            this.lb_motdepasse.TabIndex = 16;
            this.lb_motdepasse.Text = "Mot de passe  :";
            // 
            // Fconnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(653, 251);
            this.Controls.Add(this.lb_motdepasse);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.lbConnexion);
            this.Controls.Add(this.tb_login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fconnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fconnexion";
            this.Load += new System.EventHandler(this.Fconnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lbConnexion;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_motdepasse;
    }
}