using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGsb.Presentations.Supprimer
{
    public partial class FsupprimerMedicamentOffert : Form
    {
        int idVisiteur;
        int idRapport;
        List<medicament> lesMedicaments;
        public FsupprimerMedicamentOffert(int IdVisiteur, int  IdRapport, List<medicament> LesMedicaments)
        {
            InitializeComponent();
            idVisiteur = IdVisiteur;
            idRapport = IdRapport;
            lesMedicaments = LesMedicaments;
        }

        private void FsupprimerMedicamentOffert_Load(object sender, EventArgs e)
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
            int idMedicament= (int)(cbMedicament.SelectedItem as dynamic).Value;
            offrir uneOffre = Domain.Services.serviceOffrir.getInstance().unOffrirParId(idVisiteur, idRapport, idMedicament);

            MessageBox.Show("Voulez vous supprimer ce composant ?", "Suppresion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Domain.Services.serviceOffrir.getInstance().SupprimerMedicamentOffrir(uneOffre);
            Domain.Services.serviceOffrir.getInstance().MiseAjourDuModele();
            Domain.Services.serviceMedicament.getInstance().MiseAjourDuModele();
            Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
            MessageBox.Show("Le composant a etait supprimer", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
