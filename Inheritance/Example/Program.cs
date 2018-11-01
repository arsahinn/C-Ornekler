using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        class sakaryaUni
        {
            public string IsletmeFAk;
            public string MuhFAk;


            public void fakulteGoster()
            {
                Console.WriteLine("Yonetim Bilişim Sistemleri {0} 'dedir", IsletmeFAk);
                Console.WriteLine("Gıda Muhendisligi {0} 'dedir.", MuhFAk);
            }
        }

        class ogrenci : sakaryaUni
        {
            public string aldıgıDers;

            public void ders()
            {
                Console.WriteLine("Aldıgı ders : " + aldıgıDers);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
