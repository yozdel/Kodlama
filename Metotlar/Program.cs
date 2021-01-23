using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Name = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Name = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };


            foreach (Product product in urunler)
            {

                Console.WriteLine(product.Name);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------");

            }

            Console.WriteLine("----------Metotlar----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


        }
    }
}