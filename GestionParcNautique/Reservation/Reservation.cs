using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Reservation
    {
        protected DateTime _debut;
        protected DateTime _fin;
        protected int _idClient;
        protected int _idEquipement;
        protected List<int> _listeEffectif;

        public Reservation(DateTime Debut, DateTime Fin, int IdClient, int IdEquipement, List<int> ListeEffectif, bool isNew = false)
        {
            this._debut = Debut;
            this._fin = Fin;
            this._idClient = IdClient;
            this._idEquipement = IdEquipement;
            this._listeEffectif = ListeEffectif;

            BddConnexion connect = new BddConnexion();

            if (isNew == true)
            {
                int idResa = connect.requestGetIdBack("INSERT INTO Reservation (dateDebut, dateFin, idClient, idEquipement) OUTPUT INSERTED.id VALUES ('" + Debut+ "','" + Fin + "','" + IdClient + "','" + IdEquipement + "')");
                Debug.Write(idResa);
                if (idResa != 0)
                {
                    foreach(int effectif in ListeEffectif)
                    {
                        connect.request("INSERT INTO DetailResaEffectif (idResa, idEffectif) VALUES ('" + idResa + "','" + effectif + "')");
                    }
                }
            }
        }
    }
}
