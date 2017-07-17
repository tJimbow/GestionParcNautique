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
    public partial class MenuClient : Form
    {
        public MenuClient()
        {
            InitializeComponent();
            MenuAccueil menuAccueil = new MenuAccueil();
            //this.OnFormClosing(menuAccueil.Show());
        }

        private void MenuClient_Load(object sender, EventArgs e)
        {
            
        }
    }
}
