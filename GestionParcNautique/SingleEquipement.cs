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
        public SingleEquipement()
        {
            InitializeComponent();
        }
        
        public void loadData(String Etat, int Puissance, float PrixHT, String Description, String nom)
        {
            singleNom.Text = nom;
            singleEtat.Text = Etat;
            singlePuissance.Text = Puissance.ToString();
            singleDescriptif.Text = Description;
            singlePrixHT.Text = PrixHT.ToString();
        }
    }
}
