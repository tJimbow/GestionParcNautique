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
    public partial class MenuReservation : Form
    {
        public MenuReservation()
        {
            InitializeComponent();
        }

        private void MenuReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Effectif'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.effectifTableAdapter.Fill(this.parcNautiqueDataSet1.Effectif);
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.parcNautiqueDataSet1.Client);
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Equipement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.equipementTableAdapter.Fill(this.parcNautiqueDataSet1.Equipement);
        }
        private void DisplayReservation()
        {
            BddConnexion connect = new BddConnexion();
            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Reservation, DetailResaEffectif, Equipement ORDER BY id");
            while (incReader.Read())
            {
                String nom = (string)incReader["nom"];
                int numSS = int.Parse(incReader["numSecuriteSocial"].ToString());
                DateTime dateE = DateTime.Parse(incReader["dateEmbauche"].ToString());
                DateTime dateVM = DateTime.Parse(incReader["dateVisiteMedical"].ToString());
                String statutContrat = (string)incReader["statutContrat"];
                int numPermisCotier = int.Parse(incReader["numPermisCotier"].ToString());
                String statutActivite = (string)incReader["statutActivite"];
                SingleEffectif displayEffectif = new SingleEffectif();
                displayEffectif.loadData(numSS, nom, dateE, dateVM, statutContrat, numPermisCotier, statutActivite);
                displayEffectif.Show();
            }
            connect.deconnecter();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEquipement = 0;
            DataRowView drv = (DataRowView)equipementBindingSource.Current;
            DataRow dr = drv.Row;
            List<int> needAccompagnateur = new List<int>();
            Equipement equipement = new Equipement();
            needAccompagnateur = equipement.getEquipementAcc();
            bool verifIsInList = false;
            try
            {
                idEquipement = int.Parse(dr.ItemArray[0].ToString());
                for(int i=0; i<= needAccompagnateur.Count-1; i++)
                {
                    if (needAccompagnateur[i] == idEquipement)
                    {
                        verifIsInList = true;
                    }
                }
                if (verifIsInList)
                {
                    Debug.Write("in");
                    this.effectifGridView.DataSource = this.effectifBindingSource;
                    this.effectifBindingSource.DataMember = "Effectif";
                    this.effectifBindingSource.DataSource = this.parcNautiqueDataSet1;
                    this.effectifTableAdapter.Fill(this.parcNautiqueDataSet1.Effectif);
                }
                else
                {
                    Debug.Write("out");
                    this.effectifGridView.DataSource = null;
                    this.effectifGridView.Rows.Clear();
                }
            }
            catch (Exception)
            {
                idEquipement = 0;
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if(addedClient.Text == "Aucun client sélectionné")
            {
                MessageError.Text = "Veuillez saisir un client !";
            }
            else
            {
                DataRowView drvEquipement = (DataRowView)equipementBindingSource.Current;
                DataRow drEquipement = drvEquipement.Row;
                int numEquipSelec = int.Parse(drEquipement.ItemArray[0].ToString());

                int numClientSelec = int.Parse(idAddedClient.Text);

                List<int> needAccompagnateur = new List<int>();
                foreach(DataGridViewCell cell in effectifGridView.SelectedCells)
                {
                    needAccompagnateur.Add(int.Parse(cell.Value.ToString()));
                }
                DateTime dateDebut = addDateDebut.Value;
                DateTime dateFin = addDateFin.Value;

                Reservation reservation = new Reservation(dateDebut, dateFin, numClientSelec, numEquipSelec, needAccompagnateur, true);

            }
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            MenuAccueil menuAccueil = new MenuAccueil();
            this.Close();
            menuAccueil.Show();
        }
    }
}
