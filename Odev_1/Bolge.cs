using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Bolge
    {
        int x; int y;
        public int X
        {
            get
            {
                return x;

            }
            set
            {
                x = value;
            }
        }
        public int Y
        {

            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Bolge(int x, int y)
        {
            //construction method araştır

            this.x = x;
            this.y = y;


        }
    }
}




    
