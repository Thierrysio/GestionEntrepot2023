using GestionEntrepot2023.Services;
using GestionEntrepot2023.Vues;

namespace GestionEntrepot2023;

public partial class App : Application
{
    static GestionDatabase database;
    public App()
	{
		InitializeComponent();

		MainPage = new DemarrageVue();
	}
    public static GestionDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new GestionDatabase();
            }
            return database;
        }
    }
}
