using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
     class Araba
    {
        public virtual void Degistir()
        {
            Console.BackgroundColor=ConsoleColor.Green;
            Console.WriteLine("Arabanın Rengi Yeşildir.");
            Console.ReadKey();
        }
    }
}
