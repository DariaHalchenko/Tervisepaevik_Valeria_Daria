namespace Tervisepaevik_Valeria_Daria.Views;

public partial class RegistrationPage : ContentPage
{
	Label lbl_nimi, lbl_vanus, lbl_email, lbl_parool, lbl_kaal, lbl_pikkus;
	Entry e_nimi, e_vanus, e_email, e_parool, e_kaal, e_pikkus;
	Button btn_salvesta;
	public RegistrationPage()
	{
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
    }
}