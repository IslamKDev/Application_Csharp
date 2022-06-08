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

namespace AppGsb.Presentations.Recherche
{
    public partial class FrechercheRapport : Form
    {
        private DataTable mesRapports = null;
        public FrechercheRapport(DataTable lesRapports)
        {
            InitializeComponent();
            this.mesRapports = lesRapports;
        }

        private void FrechercheRapport_Load(object sender, EventArgs e)
        {
            dg_rapport.DataSource = mesRapports;
        }

        private void dg_rapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
