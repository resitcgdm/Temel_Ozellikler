using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int CıkısTarihi;
        public int Kilometresi;



        public void AracBilgiGoster()
        {
            Console.WriteLine("Arac Markası : "+Marka+" "+"Arac Model : "+" "+
                "Arac Cıkıs Tarihi : "+" "+"Arac KM : "+" "+Kilometresi);
        }
    }
}
