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
    public partial class FrechercheRapportSelection : Form
    {
      
        public FrechercheRapportSelection()
        {
            InitializeComponent();
        }

        private void FrechercheRapportSelection_Load(object sender, EventArgs e)
        {

        }

        private void btRechercheDate_Click(object sender, EventArgs e)
        {
            List<rapport_visite> lesDates = Domain.Services.serviceRapport.getInstance().ListeDate();

            FrechercheRapportSelectionDate FRechercheRapportSelectionDate = new FrechercheRapportSelectionDate(lesDates);
            this.Hide();
            DialogResult retour = FRechercheRapportSelectionDate.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }
        }

        private void btRecherchePraticien_Click(object sender, EventArgs e)
        {
            List<praticien> mesPraticiens = Domain.Services.servicePraticien.getInstance().ListedesPraticiens();

            FrechercheRapportSelectionPraticien FRechercheRapportSelectionPraticien = new FrechercheRapportSelectionPraticien(mesPraticiens);
            this.Hide();
            DialogResult retour = FRechercheRapportSelectionPraticien.ShowDialog();
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
