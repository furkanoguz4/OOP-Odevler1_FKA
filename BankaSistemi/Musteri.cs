using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Musteri : İslemler
    {
        public string isim { get; set; }
        public string soyad { get; set; }
        public double hesapBakiyesi { get; set; }

        public Musteri(string _isim, string _soyad, double _hesapBakiyesi)
        {
            this.isim = _isim;
            this.soyad = _soyad;
            this.hesapBakiyesi = _hesapBakiyesi;
        }
         // Çekim metodu (fix)
        public void Cekim(double miktar)
        {
            if (miktar > hesapBakiyesi)
            {
                Console.WriteLine("Yetersiz Bakiye ...");
            }
            else
            {
                hesapBakiyesi -= miktar;
                Console.WriteLine($"Hesabınızda Kalan Para {hesapBakiyesi} :");
            }
        }
        // ezilebilir yatirim metodu 
        public virtual void Yatirim(double miktar)
        {
            hesapBakiyesi += miktar;
            Console.WriteLine($"Hesabınızdaki Miktar {hesapBakiyesi}");


        }
    
    }
}
