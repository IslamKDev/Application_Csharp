namespace AppGsb.Presentations.Recherche.Rapport
{
    partial class FrechercheRapportSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btRechercheDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btRecherchePraticien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(217, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Recherche d\'un rapport ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(62, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(509, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Selectionner si vous souhaiter faire une recherche par date de rapport :";
            // 
            // btRechercheDate
            // 
            this.btRechercheDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRechercheDate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btRechercheDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRechercheDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercheDate.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btRechercheDate.Location = new System.Drawing.Point(248, 147);
            this.btRechercheDate.Name = "btRechercheDate";
            this.btRechercheDate.Size = new System.Drawing.Size(227, 36);
            this.btRechercheDate.TabIndex = 55;
            this.btRechercheDate.Text = "Recherche par date";
            this.btRechercheDate.UseVisualStyleBackColor = true;
            this.btRechercheDate.Click += new System.EventHandler(this.btRechercheDate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(62, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Selectionner si vous souhaiter faire une recherche par particien :";
            // 
            // btRecherchePraticien
            // 
            this.btRecherchePraticien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRecherchePraticien.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btRecherchePraticien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecherchePraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecherchePraticien.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btRecherchePraticien.Location = new System.Drawing.Point(248, 250);
            this.btRecherchePraticien.Name = "btRecherchePraticien";
            this.btRecherchePraticien.Size = new System.Drawing.Size(227, 36);
            this.btRecherchePraticien.TabIndex = 57;
            this.btRecherchePraticien.Text = "Recherche par praticien";
            this.btRecherchePraticien.UseVisualStyleBackColor = true;
            this.btRecherchePraticien.Click += new System.EventHandler(this.btRecherchePraticien_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(62, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cliquer ici si vous souhaiter annuler :";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(311, 355);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 59;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AppGsb.Properties.Resources.loupe_1_;
            this.pictureBox1.Location = new System.Drawing.Point(184, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // FrechercheRapportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(704, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRecherchePraticien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRechercheDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrechercheRapportSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrechercheRapportSelection";
            this.Load += new System.EventHandler(this.FrechercheRapportSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRechercheDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRecherchePraticien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}