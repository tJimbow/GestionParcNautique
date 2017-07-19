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
    public partial class SingleEffectif : Form
    {
        public SingleEffectif()
        {
            InitializeComponent();
        }
        public void loadData(int numSS, String nom, DateTime dateE, DateTime dateVM, String statutContrat, int numPermisCotier, String statutActivite)
        {
            singleNSS.Text = numSS.ToString();
            singleNom.Text = nom;
            singleDateE.Text = dateE.ToLongDateString();
            singleDateVM.Text = dateVM.ToLongDateString();
            singleContrat.Text = statutContrat;
            singlePermisCotier.Text = numPermisCotier.ToString();
            singleActivite.Text = statutActivite;
        }

        private void btnLeaveEquipement_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
