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
    public partial class FrechercheComposant : Form
    {
        private DataTable mesComposants = null;
        public FrechercheComposant(DataTable lesRapports)
        {
            InitializeComponent();
            this.mesComposants = lesRapports;
        }

        private void dg_composant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrechercheComposant_Load(object sender, EventArgs e)
        {
            dg_composant.DataSource = mesComposants;
        }
    }
}
