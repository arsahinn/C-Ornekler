using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {

        static void Yaz(int bicim, params object[] nesne)
        {
            if (nesne.Length == 0)
                return;
            if (bicim == 0)
                foreach (object o in nesne)
                    Console.WriteLine(o.ToString() + " ");
            else
                foreach (object o in nesne)
                {
                    Console.WriteLine(o.ToString());
                }

        }

        static void Main(string[] args)
        {
            Yaz(1, "deneme", 2, 25f, 26.2);
            Yaz(0, 1, 2, 3, 'c');
            Yaz(1);
            Console.ReadKey();

        }
    }
}
