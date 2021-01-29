
// Peter Panduro, 9201015592
// L0002B
// Uppgift 3

using System;
namespace L0002B_3
{
    public class Person
    {
        readonly public string givenName, familyName, pNr;
        public Person(string givenName, string familyName, string pNr)
        {
            if (!PNrControl(pNr))
            {
                throw new Exception();
            }
            this.givenName = givenName;
            this.familyName = familyName;            
            this.pNr = pNr;
        }

        public static bool PNrControl(string personNummer)
        {
            int sum = 0;
            for (int i = 0; i < personNummer.Length; i++)
            {
                int temp = (personNummer[i] - '0') << (1 - (i & 1));
                if (temp > 9) temp -= 9;
                sum += temp;
            }
            return (sum % 10) == 0;
        }

        public static string GetGender(string pNr)
        {
            int x;
            if (!Int32.TryParse(pNr[8].ToString(), out x))
            {
                throw new Exception();
            }
            return x % 2 == 0 ? "kvinna" : "man";
        }
    }
}
