using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntrepot2023.Modeles
{

    [Table("Casier")]
    public class Casier
    {
        #region Attributs

        private int _id;
        private string _description;
        private int _NbreDePlaces;
        private List<Colis> _lesColis;
        private int _ligne;
        private int _colonne;

        #endregion

        #region Constructeurs

        public Casier()
        {

        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int NbreDePlaces { get => _NbreDePlaces; set => _NbreDePlaces = value; }
        [OneToMany]
        public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }

        [ForeignKey(typeof(Entrepot))]
        public int EntrepotIdId { get; set; }
        public int Ligne { get => _ligne; set => _ligne = value; }
        public int Colonne { get => _colonne; set => _colonne = value; }
        #endregion

        #region Methodes
        public Casier AjoutCasier(string description,int nbreDePlaces)
        {
            this.ID = 0;
            this.Description = description;
            this.NbreDePlaces = nbreDePlaces;
            this.LesColis = new List<Colis>();

            return this;
        }
        #endregion
    }
}
