using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
        //Herşeyin Birleştiği ve oluştuüu class
    class Client
    {

        private AbstractFactoryClass _abstractFactoryClass; // kullanmak istediğimiz fabrikayı seçmek için
        // o fabrikanın kullandığı ürünleri almak için
        private ITur _Tur; 
        private IBoyut _boyut;

        // Constructor Programda kullanacağımız zaman yukarıda tanımlanan değişkenlerin içini doldurmak için 
        public Client (AbstractFactoryClass   abstractFactoryClass) // alacağımız parametre hangi fabrikayı kullanacağımızı belirtiyor 
        {
            // belirtilen parametreye göre fabrikanın kullandığı özellikler değişkenlere atanıyor
            _abstractFactoryClass = abstractFactoryClass;
            _Tur = _abstractFactoryClass.CreateTur();
            _boyut = abstractFactoryClass.CreateBoyut();
        }

      
        public string BuildTV() 
        {
          string tur= _Tur.buildTur();
           string boyut= _boyut.buildboyut();
            return tur + boyut;
        }
       
    }
}
