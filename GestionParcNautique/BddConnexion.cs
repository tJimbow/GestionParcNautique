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
        //Methode pour se connecter
        public void connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "initial catalog= ParcNautique; data source = PORTABLEJIM;integrated security=true";
                con.Open();
            }

        }
        //Methode pour se déconnecter si la connexion existe
        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //Exécute une requête sql sans valeur de retour
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
        //Exécute une requête et récupère l'id de cette requête (adapté pour des INSERT)
        public int requestGetIdBack(String request)
        {
            int id = 0;
            try
            {
                this.connecter();
                SqlCommand command = new SqlCommand(request, con);
                id = int.Parse(command.ExecuteScalar().ToString());
                this.deconnecter();

            }
            catch (Exception ex)
            {
                Debug.Write("Erreur lors de la création de la requête : " + request);
                Debug.Write(ex.Message);
            }
            return id;
        }
        //Récupère toutes les  données d'une requête sql
        public SqlDataReader getData(String request)
        {
            this.connecter();
            SqlCommand command = new SqlCommand(request, con);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        //Obsolète
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
