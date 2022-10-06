using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
     class Duvar:Tadilat
    {
        public override void Change()
        {
           
            Console.Title = "BU BİR TADİLAT PROJESİDİR";
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("SALONUN DUVAR RENGİ ANA PLANDAKİYLE DEĞİŞİKLİK GÖSTERMEKTEDİR.");
        }
    }
}
