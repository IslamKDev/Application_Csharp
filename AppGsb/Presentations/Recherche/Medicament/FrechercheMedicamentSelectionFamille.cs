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

namespace AppGsb.Presentations.Recherche.Medicament
{
    public partial class FrechercheMedicamentSelectionFamille : Form
    {
        private List<famille> LesFamilles;
        public FrechercheMedicamentSelectionFamille(List<famille> mesFamilles)
        {
            InitializeComponent();
            this.LesFamilles = mesFamilles;
        }

        private void FrechercheMedicamentSelectionFamille_Load(object sender, EventArgs e)
        {
            cbFamille.DisplayMember = "Text";
            cbFamille.ValueMember = "Value";

            foreach (famille uneFamille in LesFamilles)
            {
                cbFamille.Items.Add(new { Text = uneFamille.lib_famille, Value = uneFamille.id_famille });
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int IdFamille = (int)(cbFamille.SelectedItem as dynamic).Value;
            DataTable mesFamilles = Domain.Services.serviceFamille.getInstance().TableFamille(IdFamille);

            Presentations.Recherche.FrechercheMedicament FRechercheMedicament = new Presentations.Recherche.FrechercheMedicament(mesFamilles);
            this.Hide();
            DialogResult retour = FRechercheMedicament.ShowDialog();
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
