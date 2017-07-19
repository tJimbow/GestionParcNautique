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

        public string Nom { get => _nom; set => _nom = value; }
        public string Descriptif { get => _descriptif; set => _descriptif = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public int Puissance { get => _puissance; set => _puissance = value; }
        public float PrixHT { get => _prixHt; set => _prixHt = value; }

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
