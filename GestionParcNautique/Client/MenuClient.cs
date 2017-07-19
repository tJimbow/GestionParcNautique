using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcNautique
{
    public partial class MenuClient : Form
    {
        public MenuClient()
        {
            InitializeComponent();
            MenuAccueil menuAccueil = new MenuAccueil();
            //this.OnFormClosing(menuAccueil.Show());
        }

        private void maj_datagridView()
        {
            BddConnexion connect = new BddConnexion();
            DataTable dt = new DataTable();
            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Client");
            if (incReader.HasRows)
            {
                dt.Load(incReader);
                dataClients.DataSource = dt;

            }
            connect.deconnecter();
        }
        private void MenuClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.parcNautiqueDataSet.Client);

        }
        private void reinitValues()
        {
            AddNom.Text = "";
            AddPrenom.Text = "";
            AddAdresse.Text = "";
            AddTelephone.Text = "";
            AddDateNaissance.Value = DateTime.Now;
            AddNumPermisCotier.Value = 0;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (AddNom.Text != "" && AddPrenom.Text != "" && AddAdresse.Text != "" && AddTelephone.Text != "" && AddDateNaissance.Text != "")
            {
                Client clientToAdd = new Client(AddNom.Text, AddPrenom.Text, AddAdresse.Text, AddTelephone.Text, AddDateNaissance.Value, (int)AddNumPermisCotier.Value, true);
                LabelLog.Text = "Client ajouté";
                this.reinitValues();
                maj_datagridView();
            }
            else
            {
                LabelLog.Text = "Vous avez oublié de renseigner un champ";
            }

        }

        private void dataClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataClients.Rows[rowIndex];
            BddConnexion connect = new BddConnexion();

            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Client WHERE id = '" + row.Cells[0].Value + "'");
            Debug.Write(incReader);
            int count = 0;
            while (incReader.Read() && count != 1)
            {
                String nom = (string)incReader["nom"];
                String prenom = (string)incReader["prenom"];
                String adresse = (string)incReader["adresse"];
                String telephone = (string)incReader["telephone"];
                DateTime date = DateTime.Parse(incReader["dateNaissance"].ToString());
                int numPermisCotier = int.Parse(incReader["numPermisCotier"].ToString());
                SingleClient displayClient = new SingleClient();
                displayClient.loadData(nom, prenom, adresse, telephone, date, numPermisCotier);
                displayClient.Show();
                count++;
            }
            connect.deconnecter();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            MenuAccueil menuAccueil = new MenuAccueil();
            this.Close();
            menuAccueil.Show();
        }
    }
}