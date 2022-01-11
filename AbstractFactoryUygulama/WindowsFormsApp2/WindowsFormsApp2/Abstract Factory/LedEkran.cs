using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{   
   
    class LedEkran : ITur
    {
        // Türden miras aldığı fonksiyonun içeriğini boyut türünün özelliğiyle doldurur
        public string buildTur()
        {    // Tür özellikleri buraya
            return "Ekran Türü = Led";
        }
    }
}
