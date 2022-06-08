namespace AppGsb.Presentations.Recherche
{
    partial class FrechercheRapport
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dg_rapport = new System.Windows.Forms.DataGridView();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rapport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(236, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Recherche d\'un rapport ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AppGsb.Properties.Resources.loupe_1_;
            this.pictureBox1.Location = new System.Drawing.Point(193, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // dg_rapport
            // 
            this.dg_rapport.AllowUserToOrderColumns = true;
            this.dg_rapport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dg_rapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rapport.Location = new System.Drawing.Point(37, 71);
            this.dg_rapport.Margin = new System.Windows.Forms.Padding(2);
            this.dg_rapport.Name = "dg_rapport";
            this.dg_rapport.RowHeadersWidth = 51;
            this.dg_rapport.RowTemplate.Height = 24;
            this.dg_rapport.Size = new System.Drawing.Size(716, 275);
            this.dg_rapport.TabIndex = 50;
            this.dg_rapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rapport_CellContentClick);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(459, 363);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 58;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btRetour
            // 
            this.btRetour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btRetour.Location = new System.Drawing.Point(242, 363);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(89, 36);
            this.btRetour.TabIndex = 68;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // FrechercheRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.dg_rapport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrechercheRapport";
            this.Text = "FrechercheRapport";
            this.Load += new System.EventHandler(this.FrechercheRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dg_rapport;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btRetour;
    }
}