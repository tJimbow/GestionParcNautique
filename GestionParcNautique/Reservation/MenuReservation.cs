using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcNautique
{
    public partial class MenuReservation : Form
    {
        public MenuReservation()
        {
            InitializeComponent();
        }

        private void MenuReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.parcNautiqueDataSet1.Client);
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Equipement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.equipementTableAdapter.Fill(this.parcNautiqueDataSet1.Equipement);
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Effectif'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.effectifTableAdapter.Fill(this.parcNautiqueDataSet1.Effectif);
        }

        public void chgeName(String name)
        {
            Debug.Write(name);
            this.addedClient.Text = name;
        }
        public void addIdClient(int id)
        {
            this.idAddedClient.Text = id.ToString();
        }
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            MenuClient menuClient = new MenuClient();
            menuClient.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm client = new AddClientForm(this);
            client.Show();
        }
    }
}
