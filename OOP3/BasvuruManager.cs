using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {

            krediManager.Hesapla();
            foreach (var logerService in loggerServices)
            {
                logerService.Log();
            }

        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (IKrediManager kredi in krediler)
            {

                kredi.Hesapla();

            }

        }

    }
}
