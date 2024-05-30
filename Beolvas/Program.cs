using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Beolvas;

var _context = new Context();

if (!_context.Emberek.Any())
{
    var sorok = File.ReadAllLines(@"c:\adata\7.csv").Skip(1);
    foreach (var a in sorok)
    {
        _context.Emberek.Add(new Emberek(a));
    }
_context.SaveChanges();
}

foreach (var item in _context.Emberek)
{
    Console.WriteLine(item);
}
