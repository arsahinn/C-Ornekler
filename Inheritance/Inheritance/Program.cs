using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        class memeli
        {
            public double boy;
            public double agirlik;


            public void ozellikGoster()
            {
                Console.WriteLine("Boy :  " + boy);
                Console.WriteLine("Agırlık : " + agirlik);
            }
        }

        class kedi : memeli
        {
            public string turu;

            public void turuGoster()
            {
                Console.WriteLine("Turu : " + turu);
            }
        }

        static void Main(string[] args)
        {
            kedi kedi1 = new kedi();
            kedi1.agirlik = 5;
            kedi1.boy = 10;
            kedi1.turu = "Van Kedisi";

            kedi1.ozellikGoster();
            kedi1.turuGoster();

            Console.WriteLine("\n****************\n");

            kedi kedi2 = new kedi();
            kedi2.agirlik = 4;
            kedi2.boy = 12;
            kedi2.turu = "İran Kedisi";

            kedi2.ozellikGoster();
            kedi2.turuGoster();

            Console.Read();
        }
    }
}
