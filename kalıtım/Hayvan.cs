using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    public class Hayvan
    {
        //erişim belirleyicimi public yani herkese açık getirdikten sonra değişkenleri oluşturuyoruz.

        public string Ismi;
        public string Cinsiyet;

        //private olarak tanımlanan değişkenime main method üzerinden erişemeyiz.
        private int Yas;


        public void HayvanBilgiGoster()
        { 
            Console.WriteLine("Hayvanın ismi : "+Ismi+" "+"Hayvanın Cinsiyeti : "+Cinsiyet);
        }
    }
}
