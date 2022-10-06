using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama
{
    internal class BoardPen : Pen
    {
        public bool CanRefill { get; set; }
        public override string Write()
        {
            return " I am a BOARD PEN";
        }
    }
}
