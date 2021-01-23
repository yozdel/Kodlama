using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] isimler = new string[] { "Yasin", "Ali","Ayşe","Merve" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "Hakkı";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "Yasin", "Ali", "Ayşe", "Merve" };
            foreach (var isimler in isimler2)
            {
                Console.WriteLine(isimler);
            }
            isimler2.Add("Hakkı");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}