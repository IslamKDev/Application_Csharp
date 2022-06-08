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
    public partial class FrechercheRapportSelectionPraticien : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private List<praticien> mesPraticiens;
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Le Constructeur de la classe fille "FrechercheRapportSelectionPraticien"
        /// </summary>
        /// <param name="LesPraticiens"></param>
        public FrechercheRapportSelectionPraticien(List<praticien> LesPraticiens)
        {
            InitializeComponent();
            this.mesPraticiens = LesPraticiens;
        }
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrechercheRapportSelectionPraticien_Load(object sender, EventArgs e)
        {
            cbPraticien.DisplayMember = "Text";
            cbPraticien.ValueMember = "Value";

            foreach (praticien unPraticien in mesPraticiens)
            {
                cbPraticien.Items.Add(new { Text = unPraticien.prenom_praticien + " " + unPraticien.nom_praticien, Value = unPraticien.id_praticien });
            }
        }
        //--------------------------------------------------------------------------------------------
        private void cbPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region Bouton Valider & Annuler
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// Bouton Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_valider_Click(object sender, EventArgs e)
        {
            int idPraticien = (int)(cbPraticien.SelectedItem as dynamic).Value;
            DataTable mesRapports = Domain.Services.serviceRapport.getInstance().ListeDesRapportsParPraticien(idPraticien);
            Presentations.Recherche.FrechercheRapport FRechercheRapport = new Presentations.Recherche.FrechercheRapport(mesRapports);
            this.Hide();
            DialogResult retour = FRechercheRapport.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------
        #endregion
    }
}
