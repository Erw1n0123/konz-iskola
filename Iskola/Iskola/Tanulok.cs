using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    public class Tanulok
    {
        public Tanulok(string line)
        {
            kezdes = line.Split(';')[0];
            osztaly = char.Parse( line.Split(';')[1]);
            nev = line.Split(';')[2];
        }

        public string kezdes { get; }
        public char osztaly { get; }
        public string nev { get; }
    }
}
