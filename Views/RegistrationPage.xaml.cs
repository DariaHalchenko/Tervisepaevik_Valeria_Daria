using Tervisepaevik_Valeria_Daria.Models;

namespace Tervisepaevik_Valeria_Daria.Views;

public partial class RegistrationPage : ContentPage
{
	Label lbl_nimi, lbl_vanus, lbl_email, lbl_parool, lbl_kaal, lbl_pikkus;
	Entry e_nimi, e_vanus, e_email, e_parool, e_kaal, e_pikkus;
	Button btn_salvesta, btn_kustuta, btn_exit, btn_List;
    StackLayout sl;
	public RegistrationPage()
	{
        this.BindingContext = new Kasutajad();
        lbl_nimi = new Label { Text = "Nimi: " };
        lbl_vanus = new Label { Text = "Vanus: " };
        lbl_email = new Label { Text = "Email: " };
        lbl_parool = new Label { Text = "Parool: " };
        lbl_kaal = new Label { Text = "Kaal: " };
        lbl_pikkus = new Label { Text = "Pikkus: " };

        e_nimi = new Entry { Text = "Sisestage oma nimi", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)) };
        e_vanus = new Entry { Text = "Sisestage oma vanus", Keyboard = Keyboard.Numeric, 
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)) };
        e_email = new Entry { Text = "Sisestage oma e-posti aadress", Keyboard= Keyboard.Email,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)) };
        e_parool = new Entry { Text = "Sisestage parool", IsPassword = true };
        e_kaal = new Entry { Text= "Sisestage kaal",Keyboard = Keyboard.Numeric,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)) };
        e_pikkus = new Entry { Text = "Sisestage oma pikkus", Keyboard = Keyboard.Numeric,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)) };

        btn_salvesta = new Button
        {
            Text = "Salvesta"
        };
        btn_salvesta.Clicked += Btn_salvesta_Clicked;
        btn_kustuta = new Button
        {
            Text = "Kustuta"
        };
        btn_kustuta.Clicked += Btn_kustuta_Clicked;
        btn_exit = new Button
        {
            Text = "Exit"
        };
        btn_exit.Clicked += Btn_exit_Clicked;
        btn_List = new Button
        {
            Text = "List"
        };
        btn_List.Clicked += Btn_List_Clicked; ;
        sl = new StackLayout
        {
            Children = { lbl_nimi, e_nimi, lbl_vanus, e_vanus, lbl_email, e_email, lbl_parool, e_parool, lbl_kaal, e_kaal, lbl_pikkus, e_pikkus,
            btn_salvesta, btn_kustuta, btn_exit, btn_List}
        };
        Content = sl;
    }

    private void Btn_List_Clicked(object? sender, EventArgs e)
    {
        this.Navigation.PushAsync(new DBListPage());
    }

    private void Btn_exit_Clicked(object? sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }

    private void Btn_kustuta_Clicked(object? sender, EventArgs e)
    {
        var kasutajad = (Kasutajad)BindingContext;
        App.Database.DeleteItem(kasutajad.Id);
        this.Navigation.PopAsync();
    }

    private void Btn_salvesta_Clicked(object? sender, EventArgs e)
    {
        var kasutajad = (Kasutajad)BindingContext;
        if (kasutajad!= null && !String.IsNullOrEmpty(kasutajad.Nimi))
        {
            App.Database.SaveItem(kasutajad);
        }
        this.Navigation.PopAsync();
    }
}