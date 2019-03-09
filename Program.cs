using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwsw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Liczby();
        }
        static void Liczby()
        {
            List<int> unikalne = new List<int>();
            Console.WriteLine("Obliczanie unikalnych cyfr.");
            Console.WriteLine("Podaj liczbe cyfr, ktore zostana sprawdzone:");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            while (ilosc > 0)
            {
                int cyfra = Convert.ToInt32(Console.ReadLine());
                if (!unikalne.Contains(cyfra))
                    unikalne.Add(cyfra);
                ilosc--;
            }
            Console.WriteLine("Ilosc unikatowych cyfr to " + unikalne.Count);
            Console.ReadKey();
        }
    }
}
