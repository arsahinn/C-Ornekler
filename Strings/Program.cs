using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Ali Rıza ";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Şahin";
            Console.WriteLine(result2);
            Console.WriteLine(result);

            bool result3 = sentence.EndsWith("n");

            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");

            var result6 = sentence.Insert(0, "Hello, ");

            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result6);



            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
