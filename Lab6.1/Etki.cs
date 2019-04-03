using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    abstract class Etki
    {
        abstract public int Degerlendir(int x, int y);
    }

    class SinerjikEtki : Etki
    {
        public override int Degerlendir(int x, int y)
        {
            return x * y;
        }
        public int Degerlendir(int[] arr)
        {
            int y = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                y = y * arr[i];
            }
            if (arr.Length < 1) { return 0; }
            else { return y; }
        }
    }
    class DuzEtki : Etki
    {
        public override int Degerlendir(int x, int y)
        {
            return x + y;
        }
    }
}