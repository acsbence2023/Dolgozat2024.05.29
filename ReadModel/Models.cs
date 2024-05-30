using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    public class Ember
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Varos { get; set; }
        public string Munka { get; set; }
        public string Erdeklodes { get; set; }

        public Ember() { }

        public Ember(string sor)
        {
            var a = sor.Split(",");
            Nev = a[0];
            Kor = Convert.ToInt32(a[1]);
            Varos = a[2];
            Munka = a[3];
            Erdeklodes = a[4];
        }

        public override string ToString()
        {
            return $"{Nev} - {Kor} - {Varos} - {Munka} - {Erdeklodes}";
        }
    }
}