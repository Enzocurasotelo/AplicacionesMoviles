namespace TPMillonariaRiver;

public partial class DesarrolladorPage : ContentPage
{
    public DesarrolladorPage()
    {
        InitializeComponent();
    }

    private async void Volver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
