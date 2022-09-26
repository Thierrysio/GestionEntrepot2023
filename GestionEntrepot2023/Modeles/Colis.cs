using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntrepot2023.Modeles
{
    [Table("Colis")]
    public class Colis
    {
        #region Attributs

        private int _id;
        private string _description;
        private int _ligne;
        private int _colonne;
        private TypeColis _leTypeColis;


        #endregion

        #region Constructeurs

        public Colis(int id = 0, string description = null, int ligne = 0, int colonne = 0, TypeColis leTypeColis = null)
        {
            _id = id;
            _description = description;
            _ligne = ligne;
            _colonne = colonne;
            _leTypeColis = leTypeColis;
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int Ligne { get => _ligne; set => _ligne = value; }
        public int Colonne { get => _colonne; set => _colonne = value; }
        [ForeignKey(typeof(TypeColis))]
        public int TypeColisId { get; set; }

        [ManyToOne(nameof(TypeColisId))]
        public TypeColis LeTypeColis { get => _leTypeColis; set => _leTypeColis = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
