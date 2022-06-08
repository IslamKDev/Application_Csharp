namespace AppGsb.Presentations.Liste
{
    partial class FlisterMedicament
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
            this.lbListe = new System.Windows.Forms.Label();
            this.dgMedicament = new System.Windows.Forms.DataGridView();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListe
            // 
            this.lbListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListe.AutoSize = true;
            this.lbListe.BackColor = System.Drawing.Color.Transparent;
            this.lbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListe.ForeColor = System.Drawing.SystemColors.Control;
            this.lbListe.Location = new System.Drawing.Point(33, 9);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(633, 31);
            this.lbListe.TabIndex = 3;
            this.lbListe.Text = "Affichage de la liste des médicament par famille";
            // 
            // dgMedicament
            // 
            this.dgMedicament.AllowUserToOrderColumns = true;
            this.dgMedicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedicament.Location = new System.Drawing.Point(22, 86);
            this.dgMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.dgMedicament.Name = "dgMedicament";
            this.dgMedicament.RowHeadersWidth = 51;
            this.dgMedicament.RowTemplate.Height = 24;
            this.dgMedicament.Size = new System.Drawing.Size(663, 309);
            this.dgMedicament.TabIndex = 4;
            this.dgMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedicament_CellContentClick);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(304, 400);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 14;
            this.btAnnuler.Text = "Fermer";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // tbRecherche
            // 
            this.tbRecherche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRecherche.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbRecherche.Location = new System.Drawing.Point(22, 47);
            this.tbRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecherche.Multiline = true;
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(387, 33);
            this.tbRecherche.TabIndex = 15;
            this.tbRecherche.Text = "Barre de Recherche ...";
            // 
            // FlisterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(719, 439);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.dgMedicament);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.lbListe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlisterMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flister";
            this.Load += new System.EventHandler(this.Flister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListe;
        private System.Windows.Forms.DataGridView dgMedicament;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.TextBox tbRecherche;
    }
}