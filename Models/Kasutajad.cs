using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Tervisepaevik_Valeria_Daria.Models
{
    [Table("Kasutajad")]
    public class Kasutajad
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Kasutajad_Id { get; set; }
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Email { get; set; }
        public string Parool { get; set; }
        public double Kaal {  get; set; }
        public double Pikkus { get; set; }

    }
}
