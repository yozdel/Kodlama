using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            //basvuruManager.BasvuruYap(tasitKrediManager, new FileLoggerService());
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,konutKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        } 
    }
}
