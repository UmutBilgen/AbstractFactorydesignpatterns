using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
    // Oluşuycak Ürün Özelliğini Tanımladığımız Yer
    class KucukBoyut : IBoyut
    {   
        // Ekran Boyutuyla Alakalı Herhangi bir detayı buraya giriyoruz  
        public string buildboyut()
        {             
            return "Ekran Boyutu = Küçük";
 
        }
    }
}
