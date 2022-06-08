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
    public partial class FajouterRapport : Form
    {
        private List<praticien> lesPraticiens;
        private List<visiteur> lesVisiteurs;
        private rapport_visite unRapport;
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LesPraticiens"></param>
        /// <param name="LesVisiteurs"></param>
        /// <param name="UnRapport"></param>
        public FajouterRapport(List<praticien> LesPraticiens, List<visiteur> LesVisiteurs, rapport_visite UnRapport )
        {
            InitializeComponent();
            lesPraticiens = LesPraticiens;
            lesVisiteurs = LesVisiteurs;
            unRapport = UnRapport;
        }
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FajouterRapport_Load(object sender, EventArgs e)
        {
            cbPraticien.DisplayMember = "Text";
            cbPraticien.ValueMember = "Value";
            cbVisiteur.DisplayMember = "Text";
            cbVisiteur.ValueMember = "Value";

            foreach(praticien unPraticien in lesPraticiens )
            {
                cbPraticien.Items.Add(new { Text = unPraticien.nom_praticien, Value = unPraticien.id_praticien });
            }

            foreach(visiteur unVisiteur in lesVisiteurs )
            {
                cbVisiteur.Items.Add(new { Text = unVisiteur.nom_visiteur, Value = unVisiteur.id_visiteur });
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_valider_Click(object sender, EventArgs e)
        {
            String temp = "";
            int v = (int)(cbPraticien.SelectedItem as dynamic).Value;
            unRapport.id_praticien = v;
            // unRapport.id_etat =
            temp = tbMotif.Text;
            if (temp != "")
            {
                unRapport.motif = temp;
                temp = tbBilan.Text;
                if (temp != "")
                {
                    unRapport.bilan = temp;
                    unRapport.date_rapport = dtDateRapport.Value;

                    if (temp != "")
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtDateRapport.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMotif.Focus();
                }
            }
            else
            {
                MessageBox.Show("Erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBilan.Focus();
            }

        }
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //--------------------------------------------------------------------------------------------------------------
    }
}
