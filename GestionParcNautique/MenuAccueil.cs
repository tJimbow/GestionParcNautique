using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcNautique
{
    public partial class MenuAccueil : Form
    {
        public MenuAccueil()
        {
            InitializeComponent();
        }

        private void btnGestaEquip_Click(object sender, EventArgs e)
        {
            MenuEquipement menuEquipement = new MenuEquipement();
            menuEquipement.Show();
            this.Hide();
        }

        private void btnGestaEffectif_Click(object sender, EventArgs e)
        {
            MenuEffectif menuEffectif = new MenuEffectif();
            menuEffectif.Show();
            this.Hide();
        }

        private void btnGestaResa_Click(object sender, EventArgs e)
        {
            MenuReservation menuResa = new MenuReservation();
            menuResa.Show();
            this.Hide();
        }

        private void btnGestaClient_Click(object sender, EventArgs e)
        {
            MenuClient menuClient = new MenuClient();
            menuClient.Show();
            this.Hide();
        }
        private void BntQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
