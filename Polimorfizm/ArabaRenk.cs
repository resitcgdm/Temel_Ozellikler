using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
     class ArabaRenk:Araba
    {
        public override void Degistir()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Arabanın rengi KIRMIZI olarak değiştirildi");
            Console.ReadKey();  
        }
    }
}
