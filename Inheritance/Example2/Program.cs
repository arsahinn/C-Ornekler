using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class program
    {
        class Memeli
        {
            public double boy;
            public double agirlik;

            public Memeli(double boy, double agirlik)
            {
                this.boy = boy;
                this.agirlik = agirlik;

            }
            virtual public void konus()
            {
                Console.WriteLine("Ben konusamam!");
            }
        }
        class kedi : Memeli
        {
            public string turu;

            public kedi(double boy, double agirlik, string turu) : base(boy, agirlik)
            {
                this.turu = turu;
            }
            public override void konus()
            {
                Console.WriteLine("Ben bir kediyim!");
            }
        }
        class koyun : Memeli
        {
            public string turu;

            public koyun(double boy, double agirlik, string turu) : base(boy, agirlik)
            {
                this.turu = turu;
            }
            public override void konus()
            {
                Console.WriteLine("Ben bir koyunum!");
            }
        }


        static void Main(string[] args)
        {
            Memeli memeli1 = new Memeli(10, 35);
            kedi kedi1 = new kedi(5, 10, "Van");
            koyun koyun1 = new koyun(50, 65, "Karaman");

            memeli1 = kedi1;
            memeli1.konus();

            memeli1 = koyun1;
            memeli1.konus();
            Console.Read();
        }
    }

}

