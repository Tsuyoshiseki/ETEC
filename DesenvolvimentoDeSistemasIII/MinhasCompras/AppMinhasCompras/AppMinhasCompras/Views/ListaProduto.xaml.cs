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
		try
		{
            lista.Clear();

			List<Produto> tmp = await App.Db.GetAll();

			tmp.ForEach(i => lista.Add(i));
        }
        catch (Exception ex)
        {

            await DisplayAlert("Ops", ex.Message, "OK");
        }

    }



    private void Somar_Clicked(object sender, EventArgs e)
    {
        try
        {
            string categoriaSelecionada = pickerCategoria.SelectedItem?.ToString() ?? "Todos";

            var listaFiltrada = categoriaSelecionada == "Todos"
            ? lista
            : lista.Where(p => p.Categoria == categoriaSelecionada);

            double soma = listaFiltrada.Sum(p => p.Total);

            string msg = $"O total da categoria '{categoriaSelecionada}' é {soma:C}";

            DisplayAlert("Total dos Produtos", msg, "OK");
        
        }catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");
        }
    }



    private void Adicionar_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new Views.NovoProduto());

        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }
    }



	private async void txt_search_TextChanged(object sender, TextChangedEventArgs e)
	{
		try
		{
            lst_produtos.IsRefreshing = true;

            string q = e.NewTextValue;

            lista.Clear();

            List<Produto> tmp = await App.Db.Search(q);

            tmp.ForEach(i => lista.Add(i));
        }
        catch (Exception ex)
        {

            await DisplayAlert("Ops", ex.Message, "OK");
        }
        finally
        {
            lst_produtos.IsRefreshing = false;

        }

    }



    private async void Remover_Clicked(object sender, EventArgs e)
    {
		try
		{
            MenuItem selecionado = sender as MenuItem;

            Produto p = selecionado.BindingContext as Produto;

            bool confirm = await DisplayAlert("Tem certeza?", $"Remover {p. Descricao}?", "Sim", "Não");

            if (confirm)
            {
                await App.Db.Delete(p.Id);
                lista.Remove(p);
            }
        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }

    }

    private void lst_produtos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        try
        {
            Produto p = e.SelectedItem as Produto;

            Navigation.PushAsync(new Views.EditarProduto
            {
                BindingContext = p,
            });
        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Refreshing(object sender, EventArgs e)
    {
        try
        {
            lista.Clear();

            List<Produto> tmp = await App.Db.GetAll();

            tmp.ForEach(i => lista.Add(i));
        }
        catch (Exception ex)
        {

            await DisplayAlert("Ops", ex.Message, "OK");

        }   
        finally
        {
            lst_produtos.IsRefreshing = false;
        }
    }

    private async void ToolbarItem_Relatorio_Clicked(object sender, EventArgs e)
    {
        var gastosPorCategoria = lista
            .GroupBy(p => p.Categoria)
            .Select(g => new { Categoria = g.Key, Total = g.Sum(p => p.Total) })
            .ToList();

        string relatorio = "";
        foreach (var item in gastosPorCategoria)
        {
            relatorio += $"{item.Categoria}: {item.Total:C}\n";
        }

        await DisplayAlert("Relatório de Compras", relatorio, "OK");
    }

    private void pickerCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        string categoriaSelecionada = pickerCategoria.SelectedItem?.ToString()??"Todos";

        if (categoriaSelecionada == "Todos")
        {
            lst_produtos.ItemsSource = lista;
        }
        else
        {
            var filtrados = lista.Where(p => p.Categoria == categoriaSelecionada).ToList();
            lst_produtos.ItemsSource = filtrados;
        }
    }

}