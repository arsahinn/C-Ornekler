using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMetot
{
    class Program
    {
        static double[] karekokBulma(params double[] sayilar)
        {

            double[] kokler = new double[sayilar.Length];

            for (int i = 0; i < sayilar.Length; i++)
            {
                kokler[i] = Math.Sqrt(sayilar[i]);
            }
            return kokler;
        }
        static void Main(string[] args)
        {

            double[] dizi = karekokBulma(1, 2, 4, 9, 144, 500);

            foreach (double i in dizi)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
