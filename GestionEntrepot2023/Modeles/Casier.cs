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

        public Casier(int id, string description, int nbreDePlaces, int ligne, int colonne)
        {
            _id = id;
            _description = description;
            _NbreDePlaces = nbreDePlaces;
            _lesColis = new List<Colis>();
            _ligne = ligne;
            _colonne = colonne;
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
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

        #endregion
    }
}
