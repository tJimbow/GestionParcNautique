using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class DetailResaEquipement
    {
        protected int _id;
        protected int _idEquipement;
        protected int _idReservation;
        protected int _quantite;

        public DetailResaEquipement(int Id, int IdEquipement, int IdReservation, int Quantite)
        {
            this._id = Id;
            this._idEquipement = IdEquipement;
            this._idReservation = IdReservation;
            this._quantite = Quantite;
        }
    }
}
