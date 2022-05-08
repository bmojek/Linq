using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Krzysztof Molenda, 1965-11-20; Jan Kowalski, 1987-01-01; Anna Abacka, 1972-05-20; Józef Kabacki, 2000-01-02; Kazimierz Moksa, 2001-01-02";
            var query = s.Split(';')
                        .Select(x => x.Trim())
                        .Select(x => x.Split(','))
                        .Select(x => (osoba: x[0].Split(' '), data: x[1]))
                        .Select(x => (nazwisko: x.osoba[1], imie: x.osoba[0], data : x.data))
                        .OrderBy(x => x.data)
                        .ThenBy(x => x.nazwisko)
                        .ThenBy(x => x.imie);

            foreach(var x in query)
            {
                Console.WriteLine(x);
            }

        }
    }
}
