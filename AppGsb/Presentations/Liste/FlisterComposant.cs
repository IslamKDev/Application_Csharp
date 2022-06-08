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
    public partial class FlisterComposant : Form
    {
        private DataTable mesComposants = null;
        public FlisterComposant(DataTable mesC)
        {
            InitializeComponent();
            mesComposants = mesC;
        }

        private void FlisterComposant_Load(object sender, EventArgs e)
        {
            dgComposant.DataSource = mesComposants;

        }

        private void dgComposant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
