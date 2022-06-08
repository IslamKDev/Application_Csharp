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

namespace AppGsb.Presentations.Modifier.Composant
{
    public partial class FmodifierSelectionComposant : Form
    {
        private int idMedicament;
        private List<composant> mesComposants;

        public FmodifierSelectionComposant(int idMe,List<composant> mesCo)
        {
            InitializeComponent();
            idMedicament = idMe;
            mesComposants = mesCo;

        }

        private void FmodifierSelectionComposant_Load(object sender, EventArgs e)
        {
            cbComposant.DisplayMember = "Text";
            cbComposant.ValueMember = "Value";
            foreach (composant unComposant in mesComposants)
            {
                cbComposant.Items.Add(new { Text = unComposant.lib_composant, Value = unComposant.id_composant });
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            int idComposant = (int)(cbComposant.SelectedItem as dynamic).Value;
            constituer mesConstituer = Domain.Services.serviceConstituer.getInstance().ConstituerParId(idMedicament, idComposant);
            FmodifierComposant FModifierComposant = new FmodifierComposant(idMedicament, idComposant, mesConstituer);
            this.Hide();
            DialogResult retour = FModifierComposant.ShowDialog();
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
