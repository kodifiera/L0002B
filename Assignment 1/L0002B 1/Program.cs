
// Peter Panduro, 920101-5502
// L0002B
// Inlämningsuppgift 1

using System;

namespace L0002B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera alla subValues som 0.
            int thousands = 0, fiveHundreds = 0, hundreds = 0, fifties = 0, twenties = 0, tens = 0, fives = 0, twos = 0, ones = 0;
            // Metoder för att printa ut och hämta pris och betald summa.
            int price = AskPrice();
            int payed = AskPayed();
            // Differensen som value, och dubbelkolla att resultatet är positivt.
            int value = payed - price;
            if (value < 0)
            {
                Console.WriteLine("Kunden har inte betalat tillräckligt mycket");
            }
            else
            {
                // Bryt upp summan som delmängder.
                thousands = GetSubValue(value, 1000, out value);
                fiveHundreds = GetSubValue(value, 500, out value);
                hundreds = GetSubValue(value, 100, out value);
                fifties = GetSubValue(value, 50, out value);
                twenties = GetSubValue(value, 20, out value);
                tens = GetSubValue(value, 10, out value);
                fives = GetSubValue(value, 5, out value);
                twos = GetSubValue(value, 2, out value);
                ones = value;

                // Printa ut alla delmängder som inte är noll.
                Console.WriteLine("Växel tillbaka");
                if (thousands > 0) Console.WriteLine($"Tusenlappar: {thousands}");
                if (fiveHundreds > 0) Console.WriteLine($"Femhundralappar: {fiveHundreds}");
                if (hundreds > 0) Console.WriteLine($"Hundralappar: {hundreds}");
                if (fifties > 0) Console.WriteLine($"Femtiolappar: {fifties}");
                if (twenties > 0) Console.WriteLine($"Tjugolappar: {twenties}");
                if (tens > 0) Console.WriteLine($"Tior: {tens}");
                if (fives > 0) Console.WriteLine($"Femkronor: {fives}");
                if (twos > 0) Console.WriteLine($"Tvåkronor: {twos}");
                if (ones > 0) Console.WriteLine($"Enkronor: {ones}");
            }
            // Behåll fönstret aktivt tills användaren avslutar. Annars hinner man inte läsa infon ovan.
            Console.WriteLine("Tryck på valfri tangent för att avsluta");
            Console.ReadKey();
        }

        // Fråga hur mycket varorna kostar och returnera värdet om det är ett giltigt heltalsvärde.
        static int AskPrice()
        {
            // Loop för att fråga igen om input inte är giltigt heltal.
            while (true)
            {
                Console.WriteLine("Ange pris:");
                string input = Console.ReadLine();
                int value = 0;
                if (Int32.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Värdet är inte ett giltigt nummer. Försök igen.");
                }
            }
        }

        // Fråga hur mycket kunden betalt och returnera värdet om det är ett giltigt heltalsvärde.
        static int AskPayed()
        {
            while (true)
            {
                Console.WriteLine("Betalt:");
                string input = Console.ReadLine();
                int value = 0;
                if (Int32.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Värdet är inte ett giltigt nummer. Försök igen.");
                }
            }
        }

        // Returnera hur många antal av ett visst värde (subValue) som finns i value. Subtrahera det från ursprungsvärdet och skicka tillbaka som newValue.
        static int GetSubValue(int value, int subValue, out int newValue)
        {
            newValue = value;
            int returnValue = 0;
            if (value >= subValue)
            {
                returnValue = value / subValue;
                newValue = value - returnValue * subValue;
            }
            return returnValue;
        }
    }
}
