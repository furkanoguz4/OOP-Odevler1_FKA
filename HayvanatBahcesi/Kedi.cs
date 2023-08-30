using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    internal class Kedi : Hayvanlar
    {
        public Kedi(string isim, string tur, int yas) : base(isim, tur, yas)
        {

        }

        public override void sesCikar()
        {
            Console.WriteLine("miyav");
        }

    }
}
