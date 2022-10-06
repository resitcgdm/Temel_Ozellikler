using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama
{
    internal class EyePen : Pen
    {
        public bool DoesHaveBrush { get; set; }
        public override string Write()
        {
            return "I am a EYE PEN";
        }
    }
}
