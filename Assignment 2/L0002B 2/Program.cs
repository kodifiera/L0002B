
// Peter Panduro, 920101-5502
// L0002B
// Uppgift 2

using System;
using System.Collections.Generic;
using System.IO;

namespace L0002B_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesmen = new List<Salesman>();

            // Skapa en variabel som kan användas för att terminera input. Iterera tills true.
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Skriv in nästa person. Lämna tomt för att avsluta");
                Console.Write("Namn: ");
                string name = Console.ReadLine();
                // Om namn är tomt, sätt termineringsflaggan till true och breaka loopen. Annars hämta indata.
                if (name.Equals(""))
                {
                    Console.WriteLine("");
                    break;
                }
                string pNr = GetPNr();
                string district = GetDistrict();
                int articles = GetNumberOfArticles();
                int level = CalculateLevel(articles);
                // Skapa ett personobjekt med indata och lägg i en lista
                Salesman person = new Salesman(name, pNr, district, articles, level);
                salesmen.Add(person);
            }

            // Alla personer är lagda i listan. Sortera efter nivå och skriv ut med printfunktionen.
            salesmen.Sort((x, y) => x.level.CompareTo(y.level));
            PrintSalesmen(salesmen);

            Console.WriteLine("Tryck på valfri tangent för att avsluta");
            Console.ReadKey();
        }

        // Be om personnummer, verifiera att personnumret är troligt. Annars försök igen
        static string GetPNr()
        {
            while (true)
            {
                Console.Write("Personnummer: ");
                string pNr = Console.ReadLine();
                long value = 0;
                if (Int64.TryParse(pNr, out value) && pNr.Length == 10)
                {
                    return pNr;
                }
                else
                {
                    Console.WriteLine("Inte ett giltigt personnummer. Försök igen. (Format: ÅÅMMDDXXXX)");
                }
            }
        }

        // Be om distrikt
        static string GetDistrict()
        {
            while (true)
            {
                Console.Write("Distrikt: ");
                string district = Console.ReadLine();
                if (district.Equals(""))
                {
                    Console.WriteLine("Distrikt kan inte vara tomt");
                }
                else
                {
                    return district;
                }
            }
        }

        // Be om antal sålda artiklar. Säkerställ att det är ett heltal.
        static int GetNumberOfArticles()
        {
            while (true)
            {
                Console.Write("Antal sålda artiklar: ");
                string numberOfArticles = Console.ReadLine();
                if (Int32.TryParse(numberOfArticles, out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Inte ett giltigt heltal. Försök igen");
                }
            }
        }

        // Returnera nivå baserat på sålda artiklar
        static int CalculateLevel(int articles)
        {
            if (articles < 50)
            {
                return 1;
            }
            else if (articles < 100)
            {
                return 2;
            }
            else if (articles < 200)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        // Klass för att samla all data om en specifik säljare.
        private class Salesman
        {
            public string name, pNr, district;
            public int articles, level;
            public Salesman(string name, string pNr, string district, int articles, int level)
            {
                this.name = name;
                this.pNr = pNr;
                this.district = district;
                this.articles = articles;
                this.level = level;
            }
        }

        // Skriv ut information om alla säljare i listan till konsoll samt fil namngett med nuvarande tid och datum.
        static void PrintSalesmen(List<Salesman> salesmen)
        {
            // Hämta ut tid datum för detta ögonblick. Appenda .txt-suffix.
            string dt = DateTime.UtcNow.ToString("yyMMdd hhmmss") + ".txt";
            // Skapa en path till arbetsmappen.
            string path = Path.Combine(@"./", dt);
            // Öppna fil med filnamn i arbetsmappen.
            using (StreamWriter file = new StreamWriter(path, true))
            {
                // Initiera variabler som krävs för att kunna hålla reda på nuvarande nivå.
                int currentLevel = 0;
                int numberOfSalesmenInCurrentLevel = 0;
                // Iterera igenom alla säljare i säljarlistan
                foreach (Salesman person in salesmen)
                {
                    // Ny nivå jämfört med tidigare säljare, printa ut antal från förra nivån och återställ variablerna med nuvarande nivå.
                    if (person.level != currentLevel)
                    {
                        if (currentLevel != 0)
                        {
                            string x = $"Antal personer i nivå {currentLevel}: {numberOfSalesmenInCurrentLevel}\n";
                            Console.WriteLine(x);
                            file.WriteLine(x);
                        }
                        currentLevel = person.level;
                        numberOfSalesmenInCurrentLevel = 0;
                    }

                    // skriv ut all data om säljaren
                    string n = $"Namn: {person.name}";
                    Console.WriteLine(n);
                    file.WriteLine(n);
                    string p = $"Personnummer: {person.pNr}";
                    Console.WriteLine(p);
                    file.WriteLine(p);
                    string d = $"Distrikt: {person.district}";
                    Console.WriteLine(d);
                    file.WriteLine(d);
                    string a = $"Sålda artiklar: {person.articles}";
                    Console.WriteLine(a);
                    file.WriteLine(a);
                    string l = $"Nivå: {person.level}\n";
                    Console.WriteLine(l);
                    file.WriteLine(l);
                    // Lägg till +1 i antalet säljare på nuvarande säljnivå.
                    numberOfSalesmenInCurrentLevel++;
                }
                // Printa ut nivå och antal säljare i sista nivån som itererats eftersom detta inte fångas i foreach-loopen.
                if (currentLevel != 0)
                {
                    string y = $"Antal personer i nivå {currentLevel}: {numberOfSalesmenInCurrentLevel}\n";
                    Console.WriteLine(y);
                    file.WriteLine(y);
                }
            }
        }
    }
}
