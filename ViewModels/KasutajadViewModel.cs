using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Tervisepaevik_Valeria_Daria.Models;

namespace Tervisepaevik_Valeria_Daria.ViewModels
{
    public class KasutajadViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Kasutajad kasutaja;

        public KasutajadViewModel()
        {
            kasutaja = new Kasutajad();
        }

        public int Kasutajad_Id
        {
            get { return kasutaja.Kasutajad_Id; }
            set
            {
                if (kasutaja.Kasutajad_Id != value)
                {
                    kasutaja.Kasutajad_Id = value;
                    OnPropertyChanged(nameof(Kasutajad_Id));
                }
            }
        }

        public string Nimi
        {
            get { return kasutaja.Nimi; }
            set
            {
                if (kasutaja.Nimi != value)
                {
                    kasutaja.Nimi = value;
                    OnPropertyChanged(nameof(Nimi));
                }
            }
        }

        public int Vanus
        {
            get { return kasutaja.Vanus; }
            set
            {
                if (kasutaja.Vanus != value)
                {
                    kasutaja.Vanus = value;
                    OnPropertyChanged(nameof(Vanus));
                }
            }
        }

        public string Email
        {
            get { return kasutaja.Email; }
            set
            {
                if (kasutaja.Email != value)
                {
                    kasutaja.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public string Parool
        {
            get { return kasutaja.Parool; }
            set
            {
                if (kasutaja.Parool != value)
                {
                    kasutaja.Parool = value;
                    OnPropertyChanged(nameof(Parool));
                }
            }
        }

        public double Kaal
        {
            get { return kasutaja.Kaal; }
            set
            {
                if (kasutaja.Kaal != value)
                {
                    kasutaja.Kaal = value;
                    OnPropertyChanged(nameof(Kaal));
                }
            }
        }

        public double Pikkus
        {
            get { return kasutaja.Pikkus; }
            set
            {
                if (kasutaja.Pikkus != value)
                {
                    kasutaja.Pikkus = value;
                    OnPropertyChanged(nameof(Pikkus));
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(Nimi) &&
                       Vanus > 0 &&
                       IsValidEmail(Email) &&
                       !string.IsNullOrEmpty(Parool) &&
                       Kaal > 0 &&
                       Pikkus > 0;
            }
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
