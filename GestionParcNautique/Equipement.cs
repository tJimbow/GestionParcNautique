using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Equipement
    {
        protected int _id;
        protected String _nom;
        protected String _descriptif;
        protected int _puissance;
        protected String _etat;
        protected float _prixHt;

        public Equipement(int Id, String Nom, String Descriptif, int Puissance, String Etat, int PrixHT)
        {
            _id = Id;
            _nom = Nom;
            _descriptif = Descriptif;
            _puissance = Puissance;
            _etat = Etat;
            _prixHt = PrixHT;
        }
    }
}
