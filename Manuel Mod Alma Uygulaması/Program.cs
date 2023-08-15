using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuel_Mod_Alma_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Sayı = 0;
                int Bölen = 0;
                int Bölüm = 0;
                int Kalan = 0;

                Console.WriteLine("Mod Alma Uygulanması");
                Console.Write("Modu Alınacak Sayıyı Giriniz =");
                Sayı = Convert.ToInt32(Console.ReadLine());
                Console.Write("Modu Giriniz =");
                Bölen=Convert.ToInt32((Console.ReadLine()));
                Bölüm = Sayı / Bölen;
                Kalan = Sayı-(Bölüm * Bölen);
                Console.WriteLine("{0} in {1} Bölümünün sonucu {2} Kalan ise(MOD) {3}", Sayı, Bölen, Bölüm, Kalan);


            }

        }
    }
}
