using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Reservation
    {
        protected int _id;
        protected DateTime _debut;
        protected DateTime _fin;
        protected int _idClient;

        public Reservation(int Id, DateTime Debut, DateTime Fin, int IdClient)
        {
            this._id = Id;
            this._debut = Debut;
            this._fin = Fin;
            this._idClient = IdClient;
        }
    }
}
