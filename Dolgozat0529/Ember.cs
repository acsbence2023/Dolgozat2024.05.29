using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat0529
{
    class Ember : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                People();
            }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; People(); }
        }

        private string varos;

        public string Varos
        {
            get { return varos; }
            set { varos = value; People(); }
        }

        private string munka;

        public string Munka
        {
            get { return munka; }
            set { munka = value; People(); }
        }
        public string Hobbi
        {
            get { return hobbi; }
            set { hobbi = value; People(); }
        }

        private string erdeklodes;

        private int kor;
        private string hobbi;

        public int Kor
        {
            get { return kor; }
            set { Kor = value;  People(); }
        }

        public Ember(string nev, int kor, string varos, string munka, string hobbi)
        {
            Nev = nev;
            Kor = kor;
            Varos = varos;
            Munka = munka;
            Hobbi = hobbi;
            
        }
        public Ember()
        {
        }

        public override string? ToString()
        {
            return Nev != null ? $"{Nev} - {Kor} - {Varos} - {Munka} - {Hobbi}" : "";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void People([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}