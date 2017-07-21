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
    public partial class SingleClient : Form
    {
        MenuClient menu = new MenuClient();
        public SingleClient(MenuClient incMenu)
        {
            InitializeComponent();
            menu = incMenu;
        }
        public void loadData(int Id, String nom, String prenom, String adresse, String telephone, DateTime dateNaissance, int numPermisCotier)
        {
            obId.Text = Id.ToString();
            singleNom.Text = nom + " " +prenom;
            singleAdresse.Text = adresse;
            singleTelephone.Text = telephone;
            singleDateNaissance.Text = dateNaissance.ToLongDateString();
            singlePermisCotier.Text = numPermisCotier.ToString();
        }
        private void btnLeaveEquipement_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            String id = obId.Text;
            BddConnexion connect = new BddConnexion();
            connect.connecter();
            connect.request("DELETE FROM Client WHERE id = '" + id + "'");
            connect.deconnecter();
            menu.maj_datagridView();
            this.Close();
        }
    }
}
