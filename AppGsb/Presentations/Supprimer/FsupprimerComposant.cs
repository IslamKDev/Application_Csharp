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
    public partial class FsupprimerComposant : Form
    {
        int idMedicaments;
        List<composant> lesComposants;
        
        public FsupprimerComposant(int unIdMedicaments, List<composant> MesComposants)
        {
            InitializeComponent();
            idMedicaments = unIdMedicaments;
            lesComposants = MesComposants;
        }

        private void FsupprimerComposant_Load(object sender, EventArgs e)
        {
            cbComposant.DisplayMember = "Text";
            cbComposant.ValueMember = "Value";
            foreach (composant unComposant in lesComposants)
            {
                cbComposant.Items.Add(new { Text = unComposant.lib_composant, Value = unComposant.id_composant });
            }
            //cbMedicament.SelectedIndex = 0;
            //cbComposant.SelectedIndex = 0;
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            //String temp = "";
            int idComposant = (int)(cbComposant.SelectedItem as dynamic).Value;
            constituer unConstitue = Domain.Services.serviceConstituer.getInstance().ConstituerParId(idMedicaments, idComposant);
            
                
            //if (temp != "")
            {
                //unConstitue.qte_composant = Decimal.Parse(temp);

                MessageBox.Show("Voulez vous supprimer ce composant ?", "Suppresion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Domain.Services.serviceConstituer.getInstance().SupprimerConstituer(unConstitue);
                Domain.Services.serviceConstituer.getInstance().MiseAjourDuModele();
                Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Le composant a etait supprimer", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //else
            {
                MessageBox.Show("Erreur de suppression d'un composant", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void cbMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
