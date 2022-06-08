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
 * Windows Forms : Accueil
 */

namespace AppGsb.Presentations.Accueil
{
    public partial class Faccueil : Form
    {
        
        public Faccueil()
        {
            InitializeComponent();
            lbHeure.Text = DateTime.Now.ToString("HH");
            lbMinute.Text = DateTime.Now.ToString("mm");
            lbDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
           
        }

        private void Faccueil_Load(object sender, EventArgs e)
        {

        }


    }
}
