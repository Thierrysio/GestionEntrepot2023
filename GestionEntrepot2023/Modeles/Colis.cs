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

        public Colis()
        {
        
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int Ligne { get => _ligne; set => _ligne = value; }
        public int Colonne { get => _colonne; set => _colonne = value; }
        [ForeignKey(typeof(Casier))]
        public int CasierId { get; set; }

        [ForeignKey(typeof(TypeColis))]
        public int TypeColisId { get; set; }

        [ManyToOne(nameof(TypeColisId))]
        public TypeColis LeTypeColis { get => _leTypeColis; set => _leTypeColis = value; }

        #endregion

        #region Methodes
        public Colis AjoutColis(string description,TypeColis leTypeColis)
        {
            this.ID = 0;
            this.Description = description;
            this.LeTypeColis = leTypeColis;
            return this;    
        }
        #endregion
    }
}
