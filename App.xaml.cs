using Tervisepaevik_Valeria_Daria.Models;

namespace Tervisepaevik_Valeria_Daria
{
    //public const string DATABASE_NAME = "Tervisepaevik.db";
    //public static KasutajadRepository database;
    //public static KasutajadRepository Database
    //{
    //    get
    //    {
    //        if (database == null)
    //        {
    //            database = new KasutajadRepository(
    //                Path.Combine(
    //                    Environment.GetFolderPath(Enviro0)))
    //        }
    //    }
    //}
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
