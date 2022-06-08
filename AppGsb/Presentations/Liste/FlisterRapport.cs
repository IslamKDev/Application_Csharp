using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGsb.Presentations.Liste
{
    public partial class FlisterRapport : Form
    {
        private DataTable mesRapports = null;
        public FlisterRapport(DataTable mesRapp)
        {
            InitializeComponent();
            mesRapports = mesRapp;
        }

        private void FlisterRapport_Load(object sender, EventArgs e)
        {
            dgRapport.DataSource = mesRapports;
        }

        private void dgRapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
