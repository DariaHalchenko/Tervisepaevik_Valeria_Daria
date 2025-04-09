namespace Tervisepaevik_Valeria_Daria;

public partial class StartPage : ContentPage
{
    Button btn_registreerimine, btn_login;
    StackLayout sl;
    public StartPage()
    {
        Title = "TERVISEPÄEVIK";
        btn_registreerimine = new Button
        {
            Text = "Registreerimine",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.Coral
        };
        btn_registreerimine.Clicked += Btn_registreerimine_Clicked;

        btn_login = new Button
        {
            Text = "Login",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.Coral
        };
        btn_login.Clicked += Btn_login_Clicked;

        sl = new StackLayout
        {
            Children = { btn_login, btn_registreerimine }
        };
        Content = sl;
    }

    private async void Btn_login_Clicked(object? sender, EventArgs e)
    {
        bool valik = await DisplayAlert("Registreerimine", "Kas soovite registreeruda?", "Jah", "Ei");
        //await DisplayAlert("Registreerimine", "Teie valik on: " + (valik ? "Jah" : "Ei"), "OK");
        await Navigation.PushAsync(new RegistrationPage());
    }

    private async void Btn_registreerimine_Clicked(object? sender, EventArgs e)
    {
        bool valik = await DisplayAlert("Login", "Kas soovite sisse logida?", "Jah", "Ei");
        //await DisplayAlert("Login", "Teie valik on: " + (valik ? "Jah" : "Ei"), "OK");
        await Navigation.PushAsync(new LoginPage());
    }
}
