using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class DetailResaEffectif
    {
        protected int _id;
        protected int _numSecuEffectif;
        protected int _idReservation;

        public DetailResaEffectif(int Id, int NumSecuEffectif, int IdReservation)
        {
            this._id = Id;
            this._numSecuEffectif = NumSecuEffectif;
            this._idReservation = IdReservation;
        }

    }
}
