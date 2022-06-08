using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using MesExceptions;
using Utilitaires;

/*
 * App_name: AppGsb
 * Author : Islam
 * Date : 2022-05-07
 * Windows Forms : Liste
 */

namespace AppGsb.Presentations.Liste
{
    public partial class FlisterMedicament : Form
    {
        private DataTable mesMedicament = null;

        public FlisterMedicament(DataTable mesM)
        {
            InitializeComponent();
            mesMedicament = mesM;
        }

       

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flister_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                using (SqlConnection AppGsbEntities = new SqlConnection(ConfigurationManager.ConnectionStrings["AppGsbEntities"].ConnectionString))
                {
                    if (AppGsbEntities.State == ConnectionState.Closed)
                    {
                        AppGsbEntities.Open();
                    }
                    using(SqlDataAdapter da = new SqlDataAdapter("select * from medicament join famille on medicament.id_famille = famille.id_famille", AppGsbEntities))
                    {
                        //Fill data to datatable
                        da.Fill(mesMedicament);
                        dgMedicament.DataSource = mesMedicament;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            dgMedicament.DataSource = mesMedicament;
        }
        /*
        private void tbRecherche_TextChanged(object sender, EventArgs e)
        {
          

        }
        */

        /*private void tbRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Enter key
            {
                DataView dv = mesMedicament.DefaultView;
                //Filter datagridview using textbox
                dv.RowFilter = string.Format("lib_famille like '%{0}%'", tbRecherche.Text);
                dgMedicament.DataSource = dv.ToTable();
            }
        }*/
    }
}
