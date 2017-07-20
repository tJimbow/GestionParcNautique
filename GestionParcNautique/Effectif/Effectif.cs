using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Effectif
    {
        private int _numSecuriteSocial;
        private DateTime _dateEmbauche;
        private DateTime _dateVisiteMedical;
        private String _statutContrat;
        private int _numPermisCotier;
        private String _statutActivite;
        private String _nom;

        public int NumSecuriteSocial { get => _numSecuriteSocial; set => _numSecuriteSocial = value; }
        public DateTime DateEmbauche { get => _dateEmbauche; set => _dateEmbauche = value; }
        public DateTime DateVisiteMedical { get => _dateVisiteMedical; set => _dateVisiteMedical = value; }
        public string StatutContrat { get => _statutContrat; set => _statutContrat = value; }
        public int NumPermisCotier { get => _numPermisCotier; set => _numPermisCotier = value; }
        public string StatutActivite { get => _statutActivite; set => _statutActivite = value; }
        public string Nom { get => _nom; set => _nom = value; }

        public Effectif(int numSecuriteSocial, String nom, DateTime dateEmbauche, DateTime dateVisiteMedical, string statutContrat, int numPermisCotier, string statutActivite, bool isNew = false)
        {
            NumSecuriteSocial = numSecuriteSocial;
            DateEmbauche = dateEmbauche;
            DateVisiteMedical = dateVisiteMedical;
            StatutContrat = statutContrat;
            NumPermisCotier = numPermisCotier;
            StatutActivite = statutActivite;
            Nom = nom;
            BddConnexion connect = new BddConnexion();
            if (isNew)
            {
                connect.request("INSERT INTO Effectif (numSecuriteSocial, nom, dateEmbauche, dateVisiteMedical, statutContrat, numPermisCotier, statutActivite) VALUES ('" + NumSecuriteSocial + "','" + Nom + "','" + DateEmbauche + "','" + DateVisiteMedical + "','" + StatutContrat + "','" + NumPermisCotier + "','" + StatutActivite + "')");
            }
        }

        public bool hasLicence(int id = 0)
        {
            BddConnexion connect = new BddConnexion();
            if (id != 0)
            {
                connect.connecter();
                SqlDataReader incReader = connect.getData("SELECT * FROM Effectif WHERE numSecuriteSocial = '" + id + "'");
                int count = 0;
                while (incReader.Read() && count != 1)
                {
                    int numPermisCotier = int.Parse(incReader["numPermisCotier"].ToString());
                    if(numPermisCotier != 0)
                    {
                        return true;
                    }
                    count++;
                }
                connect.deconnecter();
            }
            return false;
        }
    }
}