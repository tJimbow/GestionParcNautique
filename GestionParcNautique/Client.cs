using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Client
    {
        protected int _id;
        protected String _nom;
        protected String _prenom;
        protected String _adresse;
        protected int _telephone;
        protected DateTime _dateNaissance;
        protected int _numPermisCotier;

        public Client(int Id, string Nom, string Prenom, string Adresse, int Telephone, DateTime DateNaissance, int NumPermisCotier)
        {
            this._id = Id;
            this._nom = Nom;
            this._prenom = Prenom;
            this._adresse = Adresse;
            this._telephone = Telephone;
            this._dateNaissance = DateNaissance;
            this._numPermisCotier = NumPermisCotier;
        }
    }
}
