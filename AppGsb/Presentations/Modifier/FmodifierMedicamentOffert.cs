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

namespace AppGsb.Presentations.Modifier
{
    public partial class FmodifierMedicamentOffert : Form
    {
        int idVisiteur;
        int idRapport;
        int idMedicament;
        offrir unOffrir;

        public FmodifierMedicamentOffert(int IdVisiteur, int IdRapport, int IdMedicament, offrir UnOffrir)
        {
            InitializeComponent();
            idVisiteur = IdVisiteur;
            idRapport = IdRapport;
            idMedicament = IdMedicament;
            unOffrir = UnOffrir;
        }
        #region nb Key Press
        //--------------------------------------------------------------------------------------------------------
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
        //---------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chn"></param>
        /// <param name="c"></param>
        /// <returns></returns>
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
        private void FmodifierMedicamentOffert_Load(object sender, EventArgs e)
        {
            tbQuantite.Text = unOffrir.qte_offerte.ToString();
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            
            unOffrir.qte_offerte =Int16.Parse(tbQuantite.Text);


            MessageBox.Show("Voulez vous modifier la quantité de ce médicament ?", "Modification", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Domain.Services.serviceOffrir.getInstance().MiseAjourDuModele();
            Domain.Services.serviceMedicament.getInstance().MiseAjourDuModele();
            Domain.Services.serviceRapport.getInstance().MiseAjourDuModele();
            Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
            MessageBox.Show("La quantité du medicament a etait modification", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
