using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    internal class Program
    {   
        //Kedi sınıfından türettiğim nesneye    değerlerini girdim.
        //Normalde bu sınıf içerisinde yazılı hiç bir bilgi yok.
        //Ancak kalıtım uyguladıgım icin hayvan sınıfının bilgiler  geçiş yaptı kediye.
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.Ismi = "Duman";
            kedi.Cinsiyet = "Erkek";

            kedi.HayvanBilgiGoster();


            
            BenzinliArac bnzarac = new BenzinliArac();
            bnzarac.Marka = "BMW";
            bnzarac.Kilometresi = 35000;
            bnzarac.CıkısTarihi = 2020;
            bnzarac.KmBasiYakit = 4.8;

            bnzarac.AracBilgiGoster();
            aracbilgigoster();

            void aracbilgigoster()
            {
                Console.WriteLine("arac kilometre başı yakıt :" + bnzarac.KmBasiYakit); 
            }
            Console.ReadKey();
            
        }
    }
}
