using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGsb.Presentations.Recherche
{
    public partial class FrechercheMedicament : Form
    {
        private DataTable mesMedicaments = null;
        public FrechercheMedicament(DataTable lesMedicaments)
        {
            InitializeComponent();
            this.mesMedicaments = lesMedicaments;
        }

        private void FrechercheMedicament_Load(object sender, EventArgs e)
        {
            dg_medicament.DataSource = mesMedicaments;
        }

        private void dg_medicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRetour_Click(object sender, EventArgs e)
        {
           
        }
    }
}
