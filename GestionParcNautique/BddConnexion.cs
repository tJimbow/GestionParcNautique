using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
                con.ConnectionString = "initial catalog= ParcNautique; data source = PORTABLEJIM;integrated security=true";
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

        public void request(String request)
        {
            try
            {
                this.connecter();
                SqlCommand command = new SqlCommand(request, con);
                command.ExecuteNonQuery();
                this.deconnecter();

            }
            catch (Exception ex)
            {
                Debug.Write("Erreur lors de la création de la requête : "+request);
                Debug.Write(ex.Message);
            }
        }

        public SqlDataReader getData(String request)
        {
            this.connecter();
            SqlCommand command = new SqlCommand(request, con);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public SqlDataReader Afficher(string requette)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = requette;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }
        
    }
}
