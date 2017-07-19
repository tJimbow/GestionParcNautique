using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Effectif
    {
        protected int _numSecuriteSocial;
        protected DateTime _dateEmbauche;
        protected DateTime _dateVisiteMedical;
        protected String _statutContrat;
        protected int _numPermisCotier;
        protected String _statutActivite;

        public Effectif(int NumSecuriteSocial, DateTime DateEmbauche, DateTime DateVisiteMedical, string StatutContrat, int NumPermisCotier, string StatutActivite)
        {
            this._numSecuriteSocial = NumSecuriteSocial;
            this._dateEmbauche = DateEmbauche;
            this._dateVisiteMedical = DateVisiteMedical;
            this._statutContrat = StatutContrat;
            this._numPermisCotier = NumPermisCotier;
            this._statutActivite = StatutActivite;
        }
    }
}
