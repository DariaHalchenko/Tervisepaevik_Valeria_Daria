using Tervisepaevik_Valeria_Daria.Models;
using Tervisepaevik_Valeria_Daria.Views;

namespace Tervisepaevik_Valeria_Daria
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Tervisepaevik.db";
        public static KasutajadRepository database;
        public static KasutajadRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new KasutajadRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegistrationPage());
        }
    }
}
