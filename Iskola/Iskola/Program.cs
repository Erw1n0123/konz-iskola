using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    public class Program
    {
        public static string Azonosito(Tanulok tanulo)
        {
            string ev = tanulo.kezdes[tanulo.kezdes.Length - 1].ToString();
            string vezetek = tanulo.nev[0].ToString().ToLower() + tanulo.nev[1] + tanulo.nev[2];
            string kereszt = (tanulo.nev.Split(' ')[1])[0].ToString().ToLower() + (tanulo.nev.Split(' ')[1])[1] + (tanulo.nev.Split(' ')[1])[2];
            return ev + tanulo.osztaly + vezetek + kereszt;
        }
        static void Main(string[] args)
        {
            List<Tanulok> list = new List<Tanulok>();
            StreamReader r = new StreamReader("nevek.txt");
            while (!r.EndOfStream)
            {
                list.Add(new Tanulok(r.ReadLine()));
            }
            r.Close();

            Console.WriteLine("3. feladat");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.kezdes};{item.osztaly};{item.nev}");
            }
            Console.WriteLine("Az összes tanuló száma: " + list.Count);


            Console.WriteLine($"4. feladat\nelső tanuló: {Azonosito(list[0])}\nutolsó tanuló: {Azonosito(list[list.Count - 1])}");

            StreamWriter w = new StreamWriter("azonositok.txt");
            foreach (var item in list)
            {
                w.WriteLine(item.nev + " → " + Azonosito(item));
            }
            w.Close();

            Console.ReadKey();
        }
    }
}
