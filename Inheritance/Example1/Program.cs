using Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{

    class memeli
    {
        protected double mBoy;
        protected double mAgirlik;

        public memeli(double boy, double agirlik)
        {
            this.mBoy = boy;
            this.mAgirlik = agirlik;
        }
        public void ozellikGoster()
        {
            Console.WriteLine("Boy : " + mBoy);
            Console.WriteLine("Agirlik :" + mAgirlik);
        }
        public double boy { get; set; }
        public double agirlik { get; set; }
    }
    class kedi : memeli
    {
        public string tur;
        public kedi(double boy, double agirlik, string tur) : base(boy, agirlik)
        {
            this.tur = tur;
        }
        public void turGoster()
        {
            Console.WriteLine(tur + "Kedisi");
        }
    }
    class koyun : memeli
    {
        public string tur;
        public koyun(double boy, double agirlik, string tur) : base(boy, agirlik)
        {
            this.tur = tur;
        }
        public void turGorster()
        {
            Console.WriteLine(tur + "Koyunu");
        }
    }
    class MainMetodu
    {
        public static void Goster(memeli memeli)
        {
            Console.WriteLine("Boy :" + memeli.boy);
            Console.WriteLine("Agirlik : " + memeli.agirlik);
        }
        static void Main()
        {
            memeli memeli1 = new memeli(10, 35);
            Goster(memeli1);

            kedi kedi1 = new kedi(10, 5, "Van");
            Goster(kedi1);

            koyun koyun1 = new koyun(52, 70, "Karaman");
            Goster(koyun1);
            Console.Read();
        }
    }
}

