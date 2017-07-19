using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcNautique
{
    class Client
    {
        private String nom;
        private String prenom;
        private String adresse;
        private String telephone;
        private DateTime dateNaissance;
        private int numPermisCotier;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public int NumPermisCotier { get => numPermisCotier; set => numPermisCotier = value; }

        public Client(string Nom, string Prenom, string Adresse, string Telephone, DateTime DateNaissance, int NumPermisCotier = 0, bool isNew = false)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.Telephone = Telephone;
            this.DateNaissance = DateNaissance;
            this.NumPermisCotier = NumPermisCotier;

            BddConnexion connect = new BddConnexion();
            if (isNew)
            {
                connect.request("INSERT INTO Client (nom, prenom, adresse, telephone, dateNaissance, numPermisCotier) VALUES ('" + Nom + "','" + Prenom + "','" + Adresse + "','" + Telephone + "','" + DateNaissance + "','" + NumPermisCotier + "')");
            }
        }
    }
}
