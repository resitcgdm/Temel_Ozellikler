using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
     class Film
    {
        public string FilmAdı;
        public int FilmSüresi;
        private string FilmCesidi;

        public void set(string _ad)
        {
            FilmCesidi = _ad;
        }
        public string get()
        {
            return FilmCesidi;
        }
        
    }
}
