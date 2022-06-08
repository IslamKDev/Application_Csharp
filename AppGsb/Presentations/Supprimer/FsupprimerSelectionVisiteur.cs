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

namespace AppGsb.Presentations.Supprimer
{
    public partial class FsupprimerSelectionVisiteur : Form
    {
        private List<visiteur> mesVisiteurs;
        public FsupprimerSelectionVisiteur(List <visiteur> unVisiteur)
        {
            InitializeComponent();
            mesVisiteurs = unVisiteur;
        }

        private void FsupprimerMedicamentOffert_Load(object sender, EventArgs e)
        {
            cbVisiteur.DisplayMember = "Text";
            cbVisiteur.ValueMember = "Value";

            foreach (visiteur unVisiteur in mesVisiteurs)
            {
                cbVisiteur.Items.Add(new { Text = unVisiteur.prenom_visiteur + " " + unVisiteur.nom_visiteur, Value = unVisiteur.id_visiteur });
            }

        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int idVisiteur = (int)(cbVisiteur.SelectedItem as dynamic).Value;
            List<rapport_visite> mesRapports = Domain.Services.serviceRapport.getInstance().ListeDesRapportsParId(idVisiteur);
            FsupprimerSelectionRapport FSupprimerSelectionRapport = new FsupprimerSelectionRapport(idVisiteur, mesRapports);
            this.Hide();
            DialogResult retour = FSupprimerSelectionRapport.ShowDialog();
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
