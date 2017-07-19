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
using System.Data.SqlClient;


namespace GestionParcNautique
{
    public partial class MenuEquipement : Form
    {
        public MenuEquipement()
        {
            InitializeComponent();
        }

        private void maj_datagridView()
        {
            BddConnexion connect = new BddConnexion();
            DataTable dt = new DataTable();
            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Equipement");
            if (incReader.HasRows)
            {
                dt.Load(incReader);
                dataEquipemts.DataSource = dt;

            }
            connect.deconnecter();
        }

        private void AddEquipement_Click(object sender, EventArgs e)
        {
            if(AddNom.Text != "" && AddPrixHT.Value.ToString() != "" && AddPuissance.Value.ToString() != "")
            {
                Equipement equipementToAdd = new Equipement(AddNom.Text, AddDescriptif.Text, (int)AddPuissance.Value, (int)AddPrixHT.Value, AddEtat.Text, true);
                LabelLog.Text = "Equipement ajouté";
                this.reinitValues();
                maj_datagridView();
            }
            else
            {
                LabelLog.Text = "Vous avez oublié de renseigner un champ";
            }
            
        }

        private void reinitValues()
        {
            AddNom.Text = "";
            AddPrixHT.Value = 0;
            AddPuissance.Value = 0;
            AddDescriptif.Text = "";
            AddEtat.Text = "";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MenuEquipement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'equipementParcNautique.Equipement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.equipementTableAdapter.Fill(this.equipementParcNautique.Equipement);

        }

        private void dataEquipemts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataEquipemts.Rows[rowIndex];
            BddConnexion connect = new BddConnexion();

            connect.connecter();
            SqlDataReader incReader = connect.getData("SELECT * FROM Equipement WHERE id = '" + row.Cells[0].Value + "'");
            Debug.Write(incReader);
            int count = 0;
            while (incReader.Read() && count != 1)
            {
                String nom = (string)incReader["nom"];
                String descriptif = (string)incReader["descriptif"];
                int puissance = (int)incReader["puissance"];
                float prixHT = float.Parse(incReader["prixHT"].ToString());
                String etat = (string)incReader["etat"];
                Equipement equip = new Equipement(nom, descriptif, puissance, prixHT, etat);
                SingleEquipement displayEquipement = new SingleEquipement();
                displayEquipement.loadData(equip.Etat, equip.Puissance, equip.PrixHT, equip.Descriptif, equip.Nom);
                displayEquipement.Show();
                count++;
            }
            connect.deconnecter();
        }

        private void MenuAccueil_Click(object sender, EventArgs e)
        {
            MenuAccueil menuAccueil = new MenuAccueil();
            this.Close();
            menuAccueil.Show();
        }
    }
}
