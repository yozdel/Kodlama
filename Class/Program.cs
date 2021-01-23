using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Yasin ÖZDEL";
            kurs3.IzlenmeOranı = 80;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine("kurs adı : " + kurs.KursAdi);
                Console.WriteLine("kurs eğitmeni : " + kurs.Egitmen);
                Console.WriteLine("kurs izlenme oranı" + kurs.IzlenmeOranı);
                Console.WriteLine("-------------------------------------------");

            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}