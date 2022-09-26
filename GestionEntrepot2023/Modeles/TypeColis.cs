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


        #endregion

        #region Constructeurs

        public TypeColis(int id, string description)
        {
            _Id = id;
            _description = description;
        }



        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _Id; set => _Id = value; }
        public string Description { get => _description; set => _description = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
