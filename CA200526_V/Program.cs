using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CA200526_V
{
    class Program
    {
        static List<Merkozes> _mLista;
        static void Main()
        {
            F02();
            F03();
            F04();
            F05();
            F06();
            F07();
            Console.ReadKey();
        }
        private static void F02()
        {
            _mLista = new List<Merkozes>();
            var sr = new StreamReader(@"..\..\res\eredmenyek.csv", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream) _mLista.Add(new Merkozes(sr.ReadLine()));
            sr.Close();
        }
        private static void F03()
        {
            Console.Write("3. feladat: ");
            Console.WriteLine($"Real Madrid: " +
                $"Hazai: {_mLista.Count(x => x.HCsapat == "Real Madrid")}, " +
                $"Idegen: {_mLista.Count(x => x.ICsapat == "Real Madrid")}");
        }
        private static void F04()
        {
            Console.Write("4. feladat: ");
            Console.WriteLine($"Volt döntetlen? " +
                $"{(_mLista.Any(x => x.IPont == x.HPont) ? "igen" : "nem")}");
        }
        private static void F05()
        {
            Console.Write("5. feladat: ");
            Console.WriteLine($"barcelonai csapat neve: " +
                $"{_mLista.Select(x => x.HCsapat).First(x => x.Contains("Barcelona"))}");
        }
        private static void F06()
        {
            Console.WriteLine("6. feladat:");
            _mLista.Where(x => x.Idopont == new DateTime(2004, 11, 21)).ToList()
                .ForEach(x => Console.WriteLine($"\t{x.HCsapat} - {x.ICsapat} ({x.HPont}:{x.IPont})"));
        }
        private static void F07()
        {
            Console.WriteLine("7. feladat:");
            _mLista.GroupBy(x => x.Helyszin)
                .Where(x => x.Count() > 20).ToList()
                .ForEach(s => Console.WriteLine($"\t{s.Key}: {s.Count()}"));
        }
    }
}
