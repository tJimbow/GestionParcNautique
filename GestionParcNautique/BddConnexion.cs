using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class BddConnexion
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();

        public object ConectionState { get; private set; }

        public void connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "initial catalog= employes; data source = DESKTOP-AJB7V2S;integrated security=true";
                con.Open();
            }

        }
        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlDataReader Afficher(string requette)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = requette;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }

        public string Requette()
        {
            string requette = "SELECT idsalarie,nom,prenom FROM salaries";
            return requette;
        }
    }
}
