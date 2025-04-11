using Tervisepaevik_Valeria_Daria.Models;
using Tervisepaevik_Valeria_Daria.ViewModels;

namespace Tervisepaevik_Valeria_Daria.Views;

public partial class RegistrationPage : ContentPage
{
	Label lbl_nimi, lbl_vanus, lbl_email, lbl_parool, lbl_kaal, lbl_pikkus;
	Entry e_nimi, e_vanus, e_email, e_parool, e_kaal, e_pikkus;
	Button btn_salvesta, btn_kustuta, btn_exit, btn_List;
    StackLayout sl;
	public RegistrationPage()
	{
        var viewModel = new KasutajadViewModel();
        this.BindingContext = viewModel;

        lbl_nimi = new Label { Text = "Nimi: " };
        lbl_vanus = new Label { Text = "Vanus: " };
        lbl_email = new Label { Text = "Email: " };
        lbl_parool = new Label { Text = "Parool: " };
        lbl_kaal = new Label { Text = "Kaal: " };
        lbl_pikkus = new Label { Text = "Pikkus: " };

        e_nimi = new Entry
        {
            Placeholder = "Sisestage oma nimi",
        };
        e_nimi.SetBinding(Entry.TextProperty, nameof(KasutajadViewModel.Nimi), BindingMode.TwoWay);

        e_vanus = new Entry
        {
            Placeholder = "Sisestage oma vanus",
            Keyboard = Keyboard.Numeric,
        };
        e_vanus.SetBinding(Entry.TextProperty, nameof(KasutajadViewModel.VanusString), BindingMode.TwoWay);

        e_email = new Entry
        {
            Placeholder = "Sisestage oma e-posti aadress",
            Keyboard = Keyboard.Email,
        };
        e_email.SetBinding(Entry.TextProperty, nameof(KasutajadViewModel.Email), BindingMode.TwoWay);

        e_parool = new Entry
        {
            Placeholder = "Sisestage parool",
            IsPassword = true
        };
        e_parool.SetBinding(Entry.TextProperty, nameof(KasutajadViewModel.Parool), BindingMode.TwoWay);

        e_kaal = new Entry
        {
            Placeholder = "Sisestage kaal",
            Keyboard = Keyboard.Numeric,
        };
        e_kaal.SetBinding(Entry.TextProperty, nameof(KasutajadViewModel.Kaal), BindingMode.TwoWay);

        e_pikkus = new Entry
        {
            Placeholder = "Sisestage oma pikkus",
            Keyboard = Keyboard.Numeric,
        };
        e_pikkus.SetBinding(Entry.TextProperty, nameof(KasutajadViewModel.Pikkus), BindingMode.TwoWay);


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
        if (BindingContext is KasutajadViewModel viewModel)
        {
            if (viewModel.IsValid)
            {
                var kasutaja = new Kasutajad
                {
                    Id = viewModel.Kasutajad_Id,
                    Nimi = viewModel.Nimi,
                    Vanus = viewModel.Vanus,
                    Email = viewModel.Email,
                    Parool = viewModel.Parool,
                    Kaal = viewModel.Kaal,
                    Pikkus = viewModel.Pikkus
                };

                App.Database.SaveItem(kasutaja);
                this.Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Viga", "Palun täitke kõik väljad korrektselt", "OK");
            }
        }
    }
}