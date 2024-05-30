using Models;
using ClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


var _context = new Context();

if (!_context.Emberek.Any())
{
    var sorok = File.ReadAllLines(@"c:\adat\7.csv");
    foreach (var a in sorok)
    {
        _context.Emberek.Add(new Ember(a));
    }
_context.SaveChanges();
}

foreach (var item in _context.Emberek)
{
    Console.WriteLine(item);
}
