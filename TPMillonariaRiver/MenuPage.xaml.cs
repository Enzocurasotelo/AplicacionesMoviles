namespace TPMillonariaRiver;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private async void IrDesarrollador(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DesarrolladorPage());
    }

    private async void IrServicio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicioPage());
    }

    private async void CerrarSesion(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
