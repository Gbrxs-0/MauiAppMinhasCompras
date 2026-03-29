using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class Relatorio : ContentPage
{
    public Relatorio()
    {
        InitializeComponent();
    }

    private async void OnFiltrarClicked(object sender, EventArgs e)
    {
        DateTime inicio = dt_inicio.Date;
        DateTime fim = dt_fim.Date;

        var lista = await App.Db.GetAll(); // usa seu banco

        var filtrados = lista
            .Where(p => p.DataCadastro >= inicio && p.DataCadastro <= fim)
            .ToList();

        listaProdutos.ItemsSource = filtrados;
    }
}