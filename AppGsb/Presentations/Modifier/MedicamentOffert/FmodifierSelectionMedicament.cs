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
    public partial class FmodifierSelectionMedicament : Form
    {
        int idVisiteur;
        int idRapport;
        List<medicament> lesMedicaments;
        public FmodifierSelectionMedicament(int IdVisiteur, int IdRapport,List<medicament> LesMedicaments)
        {
            InitializeComponent();
            idVisiteur = IdVisiteur;
            idRapport = IdRapport;
            lesMedicaments = LesMedicaments;
        }

        private void FmodifierSelectionMedicament_Load(object sender, EventArgs e)
        {
            cbMedicament.DisplayMember = "Text";
            cbMedicament.ValueMember = "Value";
            foreach (medicament unMedicament in lesMedicaments)
            {
                cbMedicament.Items.Add(new { Text = unMedicament.nom_commercial, Value = unMedicament.id_medicament });
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int idMedicament = (int)(cbMedicament.SelectedItem as dynamic).Value;
            offrir uneOffre = Domain.Services.serviceOffrir.getInstance().unOffrirParId(idVisiteur, idRapport, idMedicament);

            FmodifierMedicamentOffert FModifierMedicamentOffert = new FmodifierMedicamentOffert(idVisiteur, idRapport, idMedicament, uneOffre);
            this.Hide();
            DialogResult retour = FModifierMedicamentOffert.ShowDialog();
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
