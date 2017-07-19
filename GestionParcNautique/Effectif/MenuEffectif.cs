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
    public partial class MenuEffectif : Form
    {
        public MenuEffectif()
        {
            InitializeComponent();
        }
        private void maj_datagridView()
        {
            BddConnexion connect = new BddConnexion();
            DataTable dt = new DataTable();
            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Effectif");
            if (incReader.HasRows)
            {
                dt.Load(incReader);
                dataEffectifs.DataSource = dt;

            }
            connect.deconnecter();
        }
        private void reinitValues()
        {
            AddNom.Text = "";
            AddStatutContrat.Text = "";
            AddDateEmbauche.Value = DateTime.Now;
            AddDateVisiteMedical.Value = DateTime.Now;
            AddNumPermisCotier.Value = 0;
            AddNumSecuriteSocial.Value = 0;
            AddStatutActivite.Text = "";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MenuEffectif_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Effectif'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.effectifTableAdapter.Fill(this.parcNautiqueDataSet1.Effectif);
            // TODO: cette ligne de code charge les données dans la table 'parcNautiqueDataSet1.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.parcNautiqueDataSet1.Client);

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            MenuAccueil menuAccueil = new MenuAccueil();
            this.Close();
            menuAccueil.Show();
        }

        private void AddEffectif_Click(object sender, EventArgs e)
        {
            if (AddNom.Text != "" && AddStatutContrat.Text != "" && AddNumSecuriteSocial.Text != "")
            {
                Effectif effectifToAdd = new Effectif((int)AddNumSecuriteSocial.Value, AddNom.Text, AddDateEmbauche.Value, AddDateVisiteMedical.Value, AddStatutContrat.Text, (int)AddNumPermisCotier.Value, AddStatutActivite.Text, true);
                LabelLog.Text = "Effectif ajouté";
                this.reinitValues();
                maj_datagridView();
            }
            else
            {
                LabelLog.Text = "Vous avez oublié de renseigner un champ";
            }
        }

        private void dataEffectifs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataEffectifs.Rows[rowIndex];
            BddConnexion connect = new BddConnexion();

            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Effectif WHERE numSecuriteSocial = '" + row.Cells[0].Value + "'");
            Debug.Write(incReader);
            int count = 0;
            while (incReader.Read() && count != 1)
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
                count++;
            }
            connect.deconnecter();
        }
    }
}
