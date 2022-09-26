using GestionEntrepot2023.VueModeles;

namespace GestionEntrepot2023.Vues;

public partial class DemarrageVue : ContentPage
{
	DemarrageVueModele vueModele;
    public DemarrageVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new DemarrageVueModele();
	}
}