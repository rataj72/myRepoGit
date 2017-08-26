using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> TestujacaFunkcja(int n)
            {
                return x => x > n;
            }

            void WiekszeNizN(int x)
            {
                var funkcja = TestujacaFunkcja(50);

                Console.WriteLine(funkcja(x));
            }

            WiekszeNizN(100);

            Console.ReadKey();
        }
    }
}
