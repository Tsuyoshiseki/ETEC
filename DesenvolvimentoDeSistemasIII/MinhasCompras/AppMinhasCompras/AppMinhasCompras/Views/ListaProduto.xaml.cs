using AppMinhasCompras.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
	ObservableCollection<Produto> lista = new ObservableCollection<Produto>();

	public ListaProduto()
	{
		InitializeComponent();

		lst_produtos.ItemsSource = lista;
	}

    protected async override void OnAppearing()
    {
		List<Produto> tmp = await App.Db.GetAll();

		tmp.ForEach(i => lista.Add(i));

    }
    private void Somar_Clicked(object sender, EventArgs e)
    {
       double soma = lista.Sum(i => i.Total);

		string msg = $"O total é {soma:C}";
		 
		DisplayAlert("Toral dos Produtos", msg, "OK");
    }
    private void Adicionar_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new Views.NovoProduto());

		} catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");
		}
	}

	private async void txt_search_TextChanged(object sender, TextChangedEventArgs e)
	{
        string q = e.NewTextValue;

		lista.Clear();

        List<Produto> tmp = await App.Db.Search(q);

        tmp.ForEach(i => lista.Add(i));

    }

    private void Remover_Clicked(object sender, EventArgs e)
    {

    }
}