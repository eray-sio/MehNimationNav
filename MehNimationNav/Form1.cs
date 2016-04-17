using backendPort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehNimationNav
{
    public partial class Form1 : Form
    {
        Navire unNavire;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCreerNavire_Click(object sender, EventArgs e)
        {
            unNavire = new Navire(
                Convert.ToString(this.txtQteFret.Text), 
                Convert.ToString(this.txtNomNavire.Text),
                Convert.ToString(this.txtLibelleFret.Text), 
                Convert.ToInt32(this.txtQteFret.Text)
           );
            this.lblNavireCree.Text = ("Votre Navire : \n" + ((char)13) +
                "NoLloyds : " +
                Convert.ToString(this.txtNoLloyds.Text) + ((char)13) +
                "Nom : : " +
                Convert.ToString(this.txtNomNavire.Text) + ((char)13) +
                "LibelleFret : " +
                Convert.ToString(this.txtLibelleFret.Text) + ((char)13) +
                "Quantité Fret : " +
                Convert.ToString(this.txtQteFret.Text));
                
                
           

        }

        private void txtNoLloyds_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNavireCree_Click(object sender, EventArgs e)
        {

        }
    }
}
