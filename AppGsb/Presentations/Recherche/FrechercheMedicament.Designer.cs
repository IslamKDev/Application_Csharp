namespace AppGsb.Presentations.Recherche
{
    partial class FrechercheMedicament
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
            this.components = new System.ComponentModel.Container();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.dg_medicament = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_medicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btAnnuler.Location = new System.Drawing.Point(487, 375);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(89, 36);
            this.btAnnuler.TabIndex = 66;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // dg_medicament
            // 
            this.dg_medicament.AllowUserToOrderColumns = true;
            this.dg_medicament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dg_medicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_medicament.Location = new System.Drawing.Point(24, 98);
            this.dg_medicament.Margin = new System.Windows.Forms.Padding(2);
            this.dg_medicament.Name = "dg_medicament";
            this.dg_medicament.RowHeadersWidth = 51;
            this.dg_medicament.RowTemplate.Height = 24;
            this.dg_medicament.Size = new System.Drawing.Size(743, 260);
            this.dg_medicament.TabIndex = 65;
            this.dg_medicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_medicament_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AppGsb.Properties.Resources.loupe_1_;
            this.pictureBox1.Location = new System.Drawing.Point(84, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(129, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "Recherche d\'un médicament par famille";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btRetour
            // 
            this.btRetour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btRetour.Location = new System.Drawing.Point(234, 375);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(89, 36);
            this.btRetour.TabIndex = 67;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // FrechercheMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.dg_medicament);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrechercheMedicament";
            this.Text = "FrechercheMedicament";
            this.Load += new System.EventHandler(this.FrechercheMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_medicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.DataGridView dg_medicament;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btRetour;
    }
}