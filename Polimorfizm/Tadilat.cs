using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
     class Tadilat
    {
        /*  -Polimorfizmde(Çok biçimlilikte) amacım kalıtım yaptığım sınıftan
             bazı değerleri(hepsini değil) alıp kullanmak.

           - Bunu yaparkende override yani ezme işlemi uygularız.


         */

        public virtual void Change()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "BU BİR TADİLAT PROJESİDİR";
            Console.WriteLine("");

            Console.WriteLine("SALONUN DUVAR RENGİ ORJİNALİNDE MAVİDİR");

            Console.ReadKey();
        }

    }
}
