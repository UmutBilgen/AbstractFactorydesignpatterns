using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
    // Oluşucak Ürününü Hangi Fabrikanın üreteceğini if-else blokları olmadan seçmek için 
    abstract class AbstractFactoryClass
    {
        // miras alınması için ürün özelliklerinin fonksiyonları
       public abstract IBoyut CreateBoyut();

        public abstract ITur CreateTur();

    }
}
