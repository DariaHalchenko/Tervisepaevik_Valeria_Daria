using Tervisepaevik_Valeria_Daria.Models;
using Tervisepaevik_Valeria_Daria.ViewModels;

namespace Tervisepaevik_Valeria_Daria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DBListPage : ContentPage
    {
        public DBListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            kasutajadList.ItemsSource = App.Database.GetKasutajads();
            base.OnAppearing();
        }

        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Kasutajad selectedFriend)
            {
                RegistrationPage friendPage = new RegistrationPage();
                friendPage.BindingContext = new KasutajadViewModel(selectedFriend);
                await Navigation.PushAsync(friendPage);
            }
        }

        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            var viewModel = new KasutajadViewModel();
            RegistrationPage friendPage = new RegistrationPage();
            friendPage.BindingContext = viewModel;
            await Navigation.PushAsync(friendPage);
        }
    }
}