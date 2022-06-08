namespace AppGsb.Presentations.Liste
{
    partial class FlisterComposant
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
            this.dgComposant = new System.Windows.Forms.DataGridView();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgComposant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgComposant
            // 
            this.dgComposant.AllowUserToOrderColumns = true;
            this.dgComposant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComposant.Location = new System.Drawing.Point(12, 76);
            this.dgComposant.Name = "dgComposant";
            this.dgComposant.Size = new System.Drawing.Size(663, 314);
            this.dgComposant.TabIndex = 0;
            this.dgComposant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComposant_CellContentClick);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(320, 396);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 15;
            this.btAnnuler.Text = "Fermer";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lbListe
            // 
            this.lbListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListe.AutoSize = true;
            this.lbListe.BackColor = System.Drawing.Color.Transparent;
            this.lbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListe.ForeColor = System.Drawing.SystemColors.Control;
            this.lbListe.Location = new System.Drawing.Point(29, 9);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(646, 29);
            this.lbListe.TabIndex = 16;
            this.lbListe.Text = "Affichage de la liste des composants par medicaments";
            // 
            // FlisterComposant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(729, 439);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.dgComposant);
            this.Name = "FlisterComposant";
            this.Text = "FlisterComposant";
            this.Load += new System.EventHandler(this.FlisterComposant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgComposant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgComposant;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lbListe;
    }
}