using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
    // Oled Televizyon Üreten Fabrika 
    class FactoryOled :AbstractFactoryClass
    {
        public override IBoyut CreateBoyut()//  Televizyonun Ekran Boyutunu Belirlemek için kullandığımız fonksiyon
        {
            return new KucukBoyut();
        }

        public override ITur CreateTur()//  Televizyonun Türünü Boyutunu Belirlemek için kullandığımız fonksiyon
        {
            return new OledEkran();
        }
    }
}
