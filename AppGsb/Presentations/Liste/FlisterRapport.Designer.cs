namespace AppGsb.Presentations.Liste
{
    partial class FlisterRapport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgRapport = new System.Windows.Forms.DataGridView();
            this.lbListe = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRapport
            // 
            this.dgRapport.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRapport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRapport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRapport.Location = new System.Drawing.Point(12, 60);
            this.dgRapport.Name = "dgRapport";
            this.dgRapport.Size = new System.Drawing.Size(695, 324);
            this.dgRapport.TabIndex = 0;
            this.dgRapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRapport_CellContentClick);
            // 
            // lbListe
            // 
            this.lbListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbListe.AutoSize = true;
            this.lbListe.BackColor = System.Drawing.Color.Transparent;
            this.lbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListe.ForeColor = System.Drawing.SystemColors.Control;
            this.lbListe.Location = new System.Drawing.Point(127, 0);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(441, 31);
            this.lbListe.TabIndex = 17;
            this.lbListe.Text = "Affichage de la liste des rapports";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(293, 391);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 18;
            this.btAnnuler.Text = "Fermer";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FlisterRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(719, 439);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.dgRapport);
            this.Name = "FlisterRapport";
            this.Text = "FlisterRapport";
            this.Load += new System.EventHandler(this.FlisterRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRapport;
        private System.Windows.Forms.Label lbListe;
        private System.Windows.Forms.Button btAnnuler;
    }
}