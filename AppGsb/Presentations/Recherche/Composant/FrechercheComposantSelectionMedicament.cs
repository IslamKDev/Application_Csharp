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

namespace AppGsb.Presentations.Recherche.Composant
{
    public partial class FrechercheComposantSelectionMedicament : Form
    {
         private List<medicament> mesMedicaments;
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Constructeur de la classe FrechercheComposantSelectionMedicament
        /// </summary>
        /// <param name="lesMedicaments"></param>
        public FrechercheComposantSelectionMedicament(List<medicament> lesMedicaments)
        {
            InitializeComponent();
            this.mesMedicaments = lesMedicaments;
        }

        private void FrechercheComposantSelectionMedicament_Load(object sender, EventArgs e)
        {
            cbMedicament.DisplayMember = "Text";
            cbMedicament.ValueMember = "Value";

            foreach (medicament unMedicament in mesMedicaments)
            {
                cbMedicament.Items.Add(new { Text = unMedicament.nom_commercial, Value = unMedicament.id_medicament });
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int idMedicament = (int)(cbMedicament.SelectedItem as dynamic).Value;
           
            DataTable mesComposants = Domain.Services.serviceComposant.getInstance().ListeDesComposantsParMedicaments(idMedicament);

            Presentations.Recherche.FrechercheComposant FRechercheComposant = new Presentations.Recherche.FrechercheComposant(mesComposants);
            this.Hide();
            DialogResult retour = FRechercheComposant.ShowDialog();
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
