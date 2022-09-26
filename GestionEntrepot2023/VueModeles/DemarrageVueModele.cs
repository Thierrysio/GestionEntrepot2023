using GestionEntrepot2023.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntrepot2023.VueModeles
{
    public class DemarrageVueModele
    {
        Entrepot entrepot01 = new Entrepot(0, "Entrepot 01", 2);

        Casier casier01 = new Casier(0, "Casier 01", 9, 0, 0);
        Casier casier02 = new Casier(0, "Casier 02", 9, 0, 1);

        TypeColis typecolis01 = new TypeColis(0, "petit colis");
        TypeColis typecolis02 = new TypeColis(0, "moyen colis");
        TypeColis typecolis03 = new TypeColis(0, "gros colis");

    }
}
