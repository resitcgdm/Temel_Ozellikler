using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    class Ogrenci
    {   
       /* 
        Kapsüllemeyi , private değişkenlere program içerisinde erişim sağlamak için kullanıyorum.
        
        */

        private string isim;

        public void setIsim(string _isim)
        {
            isim = _isim;
        } 
        public string getIsim()
        {   
            //değişkenimi döndürdüm.
            return isim;
        }

    }
}
