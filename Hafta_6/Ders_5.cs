using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_6
{
    internal class Ders_5
    {
        static void Main(string[] args)
        {
            int fak = 5;
            int carpim = 1;
            for(int i = 1; i <= fak; i++)
            {
                carpim = carpim * i;
            }
            Console.WriteLine(carpim);
        }
    }
}
