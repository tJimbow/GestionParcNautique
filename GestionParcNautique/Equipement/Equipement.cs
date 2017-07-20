using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionParcNautique
{
    class Equipement
    {
        private String _nom;
        protected String _descriptif;
        protected int _puissance;
        protected String _etat;
        protected float _prixHt;
        private List<int> equipementAcc = new List<int>();

        public string Nom { get => _nom; set => _nom = value; }
        public string Descriptif { get => _descriptif; set => _descriptif = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public int Puissance { get => _puissance; set => _puissance = value; }
        public float PrixHT { get => _prixHt; set => _prixHt = value; }
        public List<int> EquipementAcc { get => equipementAcc; set => equipementAcc = value; }

        public List<int> getEquipementAcc()
        {
            equipementAcc.Add(12);
            equipementAcc.Add(13);
            equipementAcc.Add(16);
            equipementAcc.Add(17);
            return EquipementAcc;
        }

        public Equipement()
        {

        }

        public Equipement(String nom, String descriptif, int puissance, float prixHT, String etat = "Fonctionnel", bool isNew = false)
        {
            Nom = nom;
            Descriptif = descriptif;
            Puissance = puissance;
            Etat = etat;
            PrixHT = prixHT;

            BddConnexion connect = new BddConnexion();
            if (isNew)
            {
                connect.request("INSERT INTO Equipement (nom, descriptif, puissance, prixHT, etat) VALUES ('" + Nom + "','" + Descriptif + "','" + Puissance + "','" + PrixHT + "','" + Etat + "')");
            }
        }
    }
}
