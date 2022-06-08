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


namespace AppGsb.Presentations.Supprimer
{
    public partial class FsupprimerSelectionRapport : Form
    {
        int idVisiteur;
        List<rapport_visite> lesRapports;
        public FsupprimerSelectionRapport(int unIdVisiteur, List<rapport_visite> unRapport)
        {
            InitializeComponent();
            lesRapports = unRapport;
            idVisiteur = unIdVisiteur;
        }

        private void FsupprimerSelectionRapport_Load(object sender, EventArgs e)
        {
            cbRapport.DisplayMember = "Text";
            cbRapport.ValueMember = "Value";
            foreach (rapport_visite unRapport in lesRapports)
            {
                cbRapport.Items.Add(new { Text = unRapport.bilan, Value = unRapport.id_rapport });
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {

            int idRapport = (int)(cbRapport.SelectedItem as dynamic).Value;
            List<medicament> mesMedicaments = Domain.Services.serviceOffrir.getInstance().ListeDesOffrirParId(idVisiteur, idRapport);
            FsupprimerMedicamentOffert FSupprimerMedicamentOffert = new FsupprimerMedicamentOffert(idVisiteur,idRapport, mesMedicaments);
            this.Hide();
            DialogResult retour = FSupprimerMedicamentOffert.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }     
        }
    }
}
