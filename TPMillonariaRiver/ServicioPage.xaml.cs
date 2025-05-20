namespace TPMillonariaRiver;

public partial class ServicioPage : ContentPage
{
    public ServicioPage()
    {
        InitializeComponent();
    }

    private async void Volver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
