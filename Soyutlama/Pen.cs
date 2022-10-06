using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama
{
    internal abstract class Pen
    {   //override methodunu yazmak icin ya abstract class yada virtual method oluşturmamız gerek.
        public string Brand { get; set; }
        public string Color { get; set; }
        public abstract string Write();

        public virtual string Erase()
        {
            return "Silgi işlevim var";
        }

    }
}
