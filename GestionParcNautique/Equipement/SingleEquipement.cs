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
    public partial class SingleEquipement : Form
    {
        MenuEquipement menu = new MenuEquipement();
        public SingleEquipement(MenuEquipement incMenu)
        {
            InitializeComponent();
            menu = incMenu;
        }
        
        public void loadData(int Id, String Etat, int Puissance, float PrixHT, String Description, String nom)
        {
            obId.Text = Id.ToString();
            singleNom.Text = nom;
            singleEtat.Text = Etat;
            singlePuissance.Text = Puissance.ToString();
            singleDescriptif.Text = Description;
            singlePrixHT.Text = PrixHT.ToString();
        }

        private void btnCloseEquipement_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupEquipement_Click(object sender, EventArgs e)
        {
            String id = obId.Text;
            BddConnexion connect = new BddConnexion();
            connect.connecter();
            connect.request("DELETE FROM Equipement WHERE id = '"+id+"'");
            connect.deconnecter();
            menu.maj_datagridView();
            this.Close();
        }
    }
}
