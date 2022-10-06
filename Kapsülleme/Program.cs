using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ogrenci classımdan bir nesne türetelim.
            Ogrenci ogrenci1 = new Ogrenci();

            //isim değişkenime erişim sağlayamıyorum çünkü private.O yüzden set ve get kullanmam gerekiyor.
            ogrenci1.setIsim("Reşit");
            string gelen = ogrenci1.getIsim();

            if (gelen == "Reşit")
            {
                Console.WriteLine("İşlem başarılı, kapsülleme uygulanmıştır");
            }
            else
            {
                Console.WriteLine("İşlem başarısız,kapsülleme uygulanmamıştır.");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");

            Film film = new Film();
            film.FilmAdı = "Limitless";
            film.FilmSüresi = 100;
            film.set("Bilim Kurgu");
            string gelen2=film.get();

            Console.WriteLine(film.FilmAdı+"film süresi :"+" "+film.FilmSüresi);
            Console.WriteLine(gelen2);


        }
    }
}
