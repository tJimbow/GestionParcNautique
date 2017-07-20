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
    public partial class AddClientForm : Form
    {
        MenuReservation menuParent = new MenuReservation();
        public AddClientForm(MenuReservation prevMenu)
        {
            menuParent = prevMenu;
            InitializeComponent();
        }

        private void addClientForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.parcNautiqueDataSet1.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuClient menuClient = new MenuClient();
            menuClient.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            int client = 0;
            DataRowView drv = (DataRowView)clientBindingSource.Current;
            DataRow dr = drv.Row;
            try {
                client = int.Parse(dr.ItemArray[0].ToString());
                menuParent.chgeName(dr.ItemArray[1].ToString() + " " + dr.ItemArray[2].ToString());
                this.Close();
            }
            catch (Exception)
            {
                client = 0;
            }
        }
    }
}
