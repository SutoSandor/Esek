using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esek
{
    class Program
    {
        private static int megszamol(string[] tomb)
        {
            int x = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i][0] == 'E')
                {
                    x++;
                }
            }
            return x;
        }
        private static string[] nevek = new string[] { "Erzsébet", "Jóska", "Antal", "Gábor", "Zoltán", "Katalin", "Mária", "Eszter" };
        static void Main(string[] args)
        {
            Console.WriteLine("E-vel kezdődő nevek száma: " +megszamol(nevek));
            Console.ReadKey();
        }
        
    }
}
