using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Tervisepaevik_Valeria_Daria.Models
{
    public class KasutajadRepository
    {
        SQLiteConnection database;

        public KasutajadRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Kasutajad>();
        }
        public IEnumerable<Kasutajad> GetKasutajads() 
        {
            return database.Table<Kasutajad>().ToList();
        }
        public Kasutajad GetKasutajads(int id)
        {
            return database.Get<Kasutajad>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Kasutajad>(id);
        }
        public int SaveItem(Kasutajad item)
        {
            if (item.Kasutajad_Id !=0)
            {
                database.Update(item);
                return item.Kasutajad_Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
