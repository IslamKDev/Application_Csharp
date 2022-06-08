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

namespace AppGsb.Presentations.Modifier
{
    public partial class FmodifierComposant : Form
    {
        int idMedicament;
        int idComposant;
        constituer unConst;
        //-----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LesMedicaments"></param>
        /// <param name="LesComposants"></param>
        /// <param name="UnConst"></param>
        public FmodifierComposant(int IdMedicament, int IdComposant, constituer UnConst)
        {
            InitializeComponent();
            this.idMedicament = IdMedicament;
            this.idComposant = IdComposant;
            this.unConst = UnConst;
        }
        //----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmodifierComposant_Load(object sender, EventArgs e)
        {
            tbQuantite.Text = unConst.qte_composant.ToString();
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
        #region Test
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
        private void cbMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            Boolean trouve = false;

            int id = Int16.Parse(cbMedicament.Text);

            while(index < lesMedicaments.Count && !trouve)
            {
                if(id == lesMedicaments.ElementAtOrDefault(index).id_medicament)
                {
                    trouve = true;
                    unConst = lesConstituers.ElementAtOrDefault(index);
                    cbComposant.SelectedIndex = unConst.id_composant -1; 
                    tbQuantite.Text = unConst.qte_composant.ToString();
                    
                }
                index++;
            }
        }
       
        private void cbComposant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */
        #endregion
        #region Bouton 
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_valider_Click(object sender, EventArgs e)
        {
          
            unConst.qte_composant = Int16.Parse(tbQuantite.Text);


            MessageBox.Show("Voulez vous modifier la quantité de ce composant ?", "Modification", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Domain.Services.serviceConstituer.getInstance().MiseAjourDuModele();
            Domain.Services.serviceComposant.getInstance().MiseAjourDuModele();
            Domain.Services.serviceMedicament.getInstance().MiseAjourDuModele();
            Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
            MessageBox.Show("La quantité du composant a etait modification", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
