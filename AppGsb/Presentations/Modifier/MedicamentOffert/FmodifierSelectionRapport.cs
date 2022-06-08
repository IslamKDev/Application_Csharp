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

namespace AppGsb.Presentations.Modifier.MedicamentOffert
{
    public partial class FmodifierSelectionRapport : Form
    {
        int idVisiteur;
        List<rapport_visite> lesRapports;
        public FmodifierSelectionRapport(int IdVisiteur, List<rapport_visite> unRapport)
        {
            InitializeComponent();
            idVisiteur = IdVisiteur;
            lesRapports = unRapport;
        }

        private void FmodifierSelectionRapport_Load(object sender, EventArgs e)
        {
            cbRapport.DisplayMember = "Text";
            cbRapport.ValueMember = "Value";
            foreach (rapport_visite unRapport in lesRapports)
            {
                cbRapport.Items.Add(new { Text = unRapport.bilan, Value = unRapport.id_rapport });
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int idRapport = (int)(cbRapport.SelectedItem as dynamic).Value;
            List<medicament> mesMedicaments = Domain.Services.serviceOffrir.getInstance().ListeDesOffrirParId(idVisiteur, idRapport);
            FmodifierSelectionMedicament FModifierSelectionMedicament = new FmodifierSelectionMedicament(idVisiteur, idRapport, mesMedicaments);
            this.Hide();
            DialogResult retour = FModifierSelectionMedicament.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
