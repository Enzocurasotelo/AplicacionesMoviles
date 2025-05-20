namespace TPMillonariaRiver;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string pass = txtPassword.Text;

        if (usuario == "admin" && pass == "1234")
        {
            await Navigation.PushAsync(new MenuPage());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}
