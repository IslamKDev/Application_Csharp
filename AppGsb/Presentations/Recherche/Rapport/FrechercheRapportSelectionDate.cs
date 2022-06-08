using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using MesExceptions;
using Utilitaires;

namespace AppGsb.Presentations.Recherche.Rapport
{
    public partial class FrechercheRapportSelectionDate : Form
    {
        private List<rapport_visite> LesRapports;
        public FrechercheRapportSelectionDate(List<rapport_visite> mesRapports)
        {
            InitializeComponent();
            this.LesRapports = mesRapports;
        }

        private void FrechercheRapportDate_Load(object sender, EventArgs e)
        {
            cbDate.DisplayMember = "Text";
            cbDate.ValueMember = "Value";

            foreach (rapport_visite unRapport in LesRapports)
            {
                cbDate.Items.Add(new { Text = unRapport.date_rapport, Value = unRapport.date_rapport });
            }
        }
        #region Bouton Valider & Annuler
        private void bt_valider_Click(object sender, EventArgs e)
        {
            DateTime date_rapport = (DateTime)(cbDate.SelectedItem as dynamic).Value;
            DataTable mesRapports = Domain.Services.serviceRapport.getInstance().ListeDesRapportsParDate(date_rapport);
            
            Presentations.Recherche.FrechercheRapport FRechercheRapport = new Presentations.Recherche.FrechercheRapport(mesRapports);
            this.Hide();
            DialogResult retour = FRechercheRapport.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
