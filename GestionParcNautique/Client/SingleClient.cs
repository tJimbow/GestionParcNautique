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
        public SingleClient()
        {
            InitializeComponent();
        }
        public void loadData(String nom, String prenom, String adresse, String telephone, DateTime dateNaissance, int numPermisCotier)
        {
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
    }
}
