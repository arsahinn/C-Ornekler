using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        class sekil
        {
            public double boy;
            public double en;

            public sekil(double boy, double en)
            {
                this.boy = boy;
                this.en = en;
            }
            virtual public double Alan()
            {
                return 0;
            }
        }
        class dortgen : sekil
        {
            public dortgen(int boy, int en) : base(boy, en)
            {

            }
            public override double Alan()
            {
                return en * boy;
            }
        }
        class ucgen : sekil
        {
            public ucgen(int boy, int en) : base(boy, en)
            {

            }
            public override double Alan()
            {
                return en * boy / 2;
            }
        }
        class mainMetodu
        {
            public static void alanBul(sekil sekil)
            {
                Console.WriteLine("Seklin alanı : " + sekil.Alan());
            }
            static void Main()
            {
                ucgen ucgen = new ucgen(10, 50);
                alanBul(ucgen);

                dortgen dortgen = new dortgen(10, 50);
                alanBul(dortgen);

                sekil sekil = new sekil(10, 50);
                alanBul(sekil);
                Console.Read();
            }
        }
    }
}
