using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
    // Led Televizyon Üreten Fabrika 
    class FactoryLed : AbstractFactoryClass
    {
        public override IBoyut CreateBoyut() //  Televizyonun Ekran Boyutunu Belirlemek için kullandığımız fonksiyon
        {
            return new BuyukBoyut(); 
        }

        public override ITur CreateTur()//  Televizyonun Türünü Boyutunu Belirlemek için kullandığımız fonksiyon
        {
            return new LedEkran();
        }
    }
}
