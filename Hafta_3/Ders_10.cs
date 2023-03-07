using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3
{
    internal class Ders_10
    {
        static void Main(string[] args)
        {
            Console.Write("Yaşınızı Giriniz: ");
            int yas =  Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Cinsiyetinizi Giriniz: (E/K): ");
            string cinsiyet = Console.ReadLine();
            if (yas >= 20 && cinsiyet == "E")
            {
                Console.WriteLine("Askere Gidebilir.");
            }
            else if(yas <= 20 &&  cinsiyet == "E") 
            {
                Console.WriteLine("Askere Gidemezsiniz ama "+(20-yas)+" yıl sonra gidebilirsiniz");
            }
            else
            {
                    Console.WriteLine("Askere Gidemez");
            }
        }
    }
}
