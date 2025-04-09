using Tervisepaevik_Valeria_Daria.Models;

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
            Kasutajad selectedFriend = (Kasutajad)e.SelectedItem;
            RegistrationPage friendPage = new RegistrationPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }

        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            Kasutajad friend = new Kasutajad();
            RegistrationPage friendPage = new RegistrationPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }
    }
}