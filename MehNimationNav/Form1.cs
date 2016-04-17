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
            // Condition pour savoir si un des champs est Vide ! 
            if (string.IsNullOrEmpty(this.txtNoLloyds.Text) &&
                  string.IsNullOrEmpty(this.txtNomNavire.Text) &&
                  string.IsNullOrEmpty(this.txtLibelleFret.Text) &&
                  string.IsNullOrEmpty(this.txtQteFret.Text)) MessageBox.Show("Merci de renseigner TOUS les champs !");
            else
            {
                // Instanciation d'un nouveau Navire
                unNavire = new Navire(
                    Convert.ToString(this.txtNoLloyds.Text),
                    Convert.ToString(this.txtNomNavire.Text),
                    Convert.ToString(this.txtLibelleFret.Text),
                    Convert.ToInt32(this.txtQteFret.Text)
                );

                // On remplace le text du Label par les Valeurs qu'on a fourni lors de l'instanciation du Navire
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
        }

        private void txtNoLloyds_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNavireCree_Click(object sender, EventArgs e)
        {

        }

        private void txtValiderPort_Click(object sender, EventArgs e)
        {
            List<Stockage> Stockages = new List<Stockage>();
            Stockages.Add(new Stockage(Convert.ToInt32(this.txtStockageCapa.Text)));

            foreach (var item in Stockages)
            {
                this.comboBox1.Items.Add(this.txtStockageCapa.Text);
}
        }



        private void txtStockageCapa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitAnimation_Click(object sender, EventArgs e)
        {
            // TODO Gestion d'animations 
            // Generation de PictureBox pour chaque Stockage Créé
            // Deplacement De PictureBox en PictureBox
        }
    }
}
