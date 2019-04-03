using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elemanSayilari = new int[] { 3, 4, 2 };
            Etki ekip = new DuzEtki();
            int hesap = ekip.Degerlendir(20, 5);
            Console.WriteLine(hesap);

            ekip = new SinerjikEtki();
            hesap = ekip.Degerlendir(5, 10);
            Console.WriteLine(hesap);

            hesap = (new SinerjikEtki()).Degerlendir(elemanSayilari);
            Console.WriteLine(hesap);
        }
    }
}
