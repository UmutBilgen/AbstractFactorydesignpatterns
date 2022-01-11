using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Abstract_Factory
{
    interface IBoyut // Boyutları tek tek ifle kontrol etmemek için soyutlama yapacağız bu soyutlamanın interfacesi
    {
     
            // Tüm boyut seçeneklerine miras verilecek fonksiyon
        string buildboyut();
    }
}
