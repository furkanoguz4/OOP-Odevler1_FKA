using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    internal class Hayvanlar : IEylemler
    {
        string isim { get; set; }
        string tur { get; set; }
        int yas { get; set; }

        public Hayvanlar( string _isim , string _tur ,int _yas)
        {
            isim = _isim ;
            tur = _tur ;   
            yas = _yas ;
        }
        public virtual void sesCikar()
        {
            
        }

        public virtual void ucar()
        {
            Console.WriteLine( "Uçamaz");
        }

        public void yemekYe()
        {
            Console.WriteLine("yemek yenildi");
        }
    }
}
