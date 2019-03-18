using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } }

     

        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.

        // abstract method bak
        public abstract void HaraketEt();

        public abstract void Bekle();

        public abstract void AtesEt();

        public int saglik = 100;
        public int hasar;




        // ..... //

    }
}
