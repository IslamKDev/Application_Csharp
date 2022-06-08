using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * App_name: AppGsb
 * Author : Islam
 * Date : 2022-05-07
 * Windows Forms : Connexion
 */

namespace AppGsb.Presentations.Connexion
{
    public partial class Fconnexion : Form
    {
        private String[] credential;
        //--------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public Fconnexion()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tab"></param>
        public Fconnexion(String[] tab)
        {
            InitializeComponent();
            credential = tab;
        }
        //----------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fconnexion_Load(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------
        /// <summary>
        /// Bouton Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_valider_Click(object sender, EventArgs e)
        {
            credential[0] = tb_login.Text;

            if (credential[0] == "")
            {
                tb_login.Focus();
            }
            else
            {
                credential[1] = tbMdp.Text;
                if (credential[1] == "")
                {
                    tbMdp.Focus();
                }
            }
        }
        //---------------------------------------------------------------
        /// <summary>
        /// Bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------

    }
}
