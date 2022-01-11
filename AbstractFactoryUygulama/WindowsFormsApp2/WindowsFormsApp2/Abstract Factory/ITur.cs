using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
    interface ITur// Türleri tek tek ifle kontrol etmemek için soyutlama yapacağız bu soyutlamanın interfacesi
    {
        // Bütün türlere miras verilecek fonksiyon
        string buildTur();
    }
}
