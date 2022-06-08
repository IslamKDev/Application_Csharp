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

namespace AppGsb.Presentations.Ajouter
{
    public partial class FajouterComposant : Form
    {
        private List<medicament> lesMedicaments;
        private List<composant> lesComposants;
        private constituer unConstitue;
        public FajouterComposant(List<medicament> LesM, List<composant> LesC, constituer unC)
        {
            InitializeComponent();
            lesMedicaments = LesM;
            lesComposants = LesC;
            unConstitue = unC;
        }

        private void FajouterComposant_Load(object sender, EventArgs e)
        {
            cbMedicament.DisplayMember = "Text";
            cbMedicament.ValueMember = "Value";
            cbComposant.DisplayMember = "Text";
            cbComposant.ValueMember = "Value";

            foreach (medicament unMedicament in lesMedicaments)
            {
                cbMedicament.Items.Add(new { Text = unMedicament.nom_commercial, Value = unMedicament.id_medicament });
            }

            foreach (composant unComposant in lesComposants)
            {
                cbComposant.Items.Add(new { Text = unComposant.lib_composant, Value = unComposant.id_composant });
            }
            cbMedicament.SelectedIndex = 0;
            cbComposant.SelectedIndex = 0;

        }
        #region nbKeyPress
        //-------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                var controller = (TextBox)sender;
                String text = controller.Text;

                if (NombreOccurence(text, '.') == 1)
                {
                    if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
        }

        int NombreOccurence(String chn, char c)
        {
            int cnt = 0;
            foreach (char car in chn)
            {
                if (c == car) cnt++;
            }
            return cnt;
        }
        #endregion
        private void bt_valider_Click(object sender, EventArgs e)
        {
            String temp = "";
            int v = (int)(cbMedicament.SelectedItem as dynamic).Value;
            int c = (int)(cbComposant.SelectedItem as dynamic).Value;
            unConstitue.id_medicament = v;
            unConstitue.id_composant = c;   
            // unRapport.id_etat =
            temp = tbQuantite.Text;
            if (temp != "")
            {
                unConstitue.qte_composant = Decimal.Parse(temp);
                /*MessageBox.Show("Votre Composant a bien était ajouter", "Ajouter un Composant", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            else
            {
                    MessageBox.Show("Erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbQuantite.Focus();
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbQuantite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

