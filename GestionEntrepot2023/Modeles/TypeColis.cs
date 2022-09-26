using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntrepot2023.Modeles
{
    [Table("TypeColis")]
    public class TypeColis
    {
        #region Attributs

        private int _Id;
        private string _description;
        private int _taille;

        #endregion

        #region Constructeurs

        public TypeColis()
        {

        }



        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int ID { get => _Id; set => _Id = value; }
        public string Description { get => _description; set => _description = value; }
        public int Taille { get => _taille; set => _taille = value; }
        #endregion

        #region Methodes
        public TypeColis AjoutTypeColis(string description,int taille)
        {
            this.ID = 0;
            this.Description = description;
            this.Taille = taille;
            return this;    
        }
        #endregion
    }
}
