using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Ogrenci : Musteri

    {
        
        public Ogrenci(string isim , string soyisim , double hesapBakiyesi) : base(isim , soyisim , hesapBakiyesi)
        {

        }
        // öğrenciya tanınan bonuslu ayrıcalık 
        public override void Yatirim(double miktar)  
        {
            hesapBakiyesi = hesapBakiyesi + miktar*1.03;
            Console.WriteLine("Hesabınızdaki Miktar : " + hesapBakiyesi );
        }
    }
}
