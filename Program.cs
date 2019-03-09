using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pwsw_01
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("1. Unikalne liczby.");
            Console.WriteLine("2. Dziury binarne.");
            Console.WriteLine("3. Dzialanie na zbiorach.");
            Console.WriteLine("0. Wyjscie.");
            int odpowiedz = Convert.ToInt32(Console.ReadLine());
            switch (odpowiedz)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Liczby();
                    break;
                case 2:
                    Binarne();
                    break;
                case 3:
                    Zbiory();
                    break;
                default:
                    Console.WriteLine("Niewlasciwy wybor!");
                    break;                
            }
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
            Main();
        }
        static void Zbiory()
        {
            HashSet<int> zbiorA = new HashSet<int>();
            HashSet<int> zbiorB = new HashSet<int>();
            int wielkoscZbioru, wielkoscZbioru2;
            Console.WriteLine("Podaj wielkosc zbiorow: ");
            wielkoscZbioru = Convert.ToInt32(Console.ReadLine());
            wielkoscZbioru2 = wielkoscZbioru;
            Console.WriteLine("Podaj elementy zbioru A:");
            while(wielkoscZbioru > 0)
            {
                zbiorA.Add(Convert.ToInt32(Console.ReadLine()));
                wielkoscZbioru--;
            }
            Console.WriteLine("Podaj elementy zbioru B:");
            while (wielkoscZbioru2 > 0)
            {
                zbiorB.Add(Convert.ToInt32(Console.ReadLine()));
                wielkoscZbioru2--;
            }
            HashSet<int> suma = new HashSet<int>(zbiorA);
            HashSet<int> roznica = new HashSet<int>(zbiorA);
            HashSet<int> wspolna = new HashSet<int>(zbiorA);
            HashSet<int> symetryczna = new HashSet<int>(zbiorA);
            suma.UnionWith(zbiorB);            
            roznica.ExceptWith(zbiorB);            
            wspolna.IntersectWith(zbiorB);            
            symetryczna.SymmetricExceptWith(zbiorB);
            Console.WriteLine("Suma zbiorow: ");
            DisplaySet(suma);
            Console.WriteLine("Roznica A i B: ");
            DisplaySet(roznica);
            Console.WriteLine("Czesc wspolna zbiorow: ");
            DisplaySet(wspolna);
            Console.WriteLine("Roznica symetryczna zbiorow :");
            DisplaySet(symetryczna);
            Console.ReadKey();
            Main();
        }
        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
        static void Binarne()
        {
            string podane = "001001000000010101";
            string dziury = @"\G(10+1)";
            Match match = Regex.Match(podane, dziury);
            Console.WriteLine(match);
            Main();
        }
    }
}
