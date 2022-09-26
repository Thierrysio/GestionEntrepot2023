using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntrepot2023.Modeles
{
    [Table("Entrepot")]
    public class Entrepot
    {
        #region Attributs
        
        private int _id;
        private string _designation;
        private int _nbreDeCasiers;
        private List<Casier> _lesCasiers;

        #endregion

        #region Constructeurs

        public Entrepot()
        {

        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int ID { get => _id; set => _id = value; }
        public string Designation { get => _designation; set => _designation = value; }
        public int NbreDeCasiers { get => _nbreDeCasiers; set => _nbreDeCasiers = value; }
        [OneToMany]
        public List<Casier> LesCasiers { get => _lesCasiers; set => _lesCasiers = value; }

        #endregion

        #region Methodes

        public  Entrepot AjoutEntrepot(string designation, int nbreDeCasiers)
        {
            this.ID = 0;
            this.Designation = designation;
            this.NbreDeCasiers = nbreDeCasiers;
            this.LesCasiers = new List<Casier>();

            return this;
        }

        #endregion
    }
}
