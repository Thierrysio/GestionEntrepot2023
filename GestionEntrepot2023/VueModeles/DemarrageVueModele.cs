using GestionEntrepot2023.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntrepot2023.VueModeles
{
    public class DemarrageVueModele
    {
        public DemarrageVueModele()
        {
            this.InitialiserLesDonnees();


        }
        private async void InitialiserLesDonnees()
        {
            TypeColis typecolis1 = new TypeColis().AjoutTypeColis("petit colis", 1);
            TypeColis typecolis2 = new TypeColis().AjoutTypeColis("moyen colis", 2);
            TypeColis typecolis3 = new TypeColis().AjoutTypeColis("gros colis", 3);

            Entrepot entrepot1 =new Entrepot().AjoutEntrepot("entrepot 01",2);

            Casier casier1 = new Casier().AjoutCasier("casier 01", 9);
            Casier casier2 = new Casier().AjoutCasier("casier 02", 9);

            Colis colis1 = new Colis().AjoutColis("colis 01",typecolis2);

            entrepot1.LesCasiers.Add(casier1);
            entrepot1.LesCasiers.Add(casier2);

            

            casier1.LesColis.Add(colis1);

            await App.Database.DeleteItemsAsync<Entrepot>();
            await App.Database.DeleteItemsAsync<Casier>();
            await App.Database.DeleteItemsAsync<Colis>();
            await App.Database.DeleteItemsAsync<TypeColis>();


            await App.Database.SaveItemAsync<Entrepot>(entrepot1);
            await App.Database.SaveItemAsync<Casier>(casier1);
            await App.Database.SaveItemAsync<Casier>(casier2);
            await App.Database.SaveItemAsync<Colis>(colis1);
            await App.Database.SaveItemAsync<TypeColis>(typecolis1);
            await App.Database.SaveItemAsync<TypeColis>(typecolis2);
            await App.Database.SaveItemAsync<TypeColis>(typecolis3);

            await App.Database.MiseAJourItemRelation(entrepot1);
            await App.Database.MiseAJourItemRelation(casier1);
            await App.Database.MiseAJourItemRelation(casier2);
            await App.Database.MiseAJourItemRelation(colis1);

            var mDB = App.Database.GetItemAvecRelations(colis1);
            TypeColis resultat = mDB.Result.LeTypeColis;

            ObservableCollection<Casier> MaListe = App.Database.GetItemsAsync<Casier>();


        }

    }
}
