using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        Asker[] birlik1 = new Asker[7];

        public Asker[] Birlik1 { get { return birlik1; } set { birlik1 = value; } }
       public int takim1sagligi = 700;

        Asker[] birlik2 = new Asker[7];

        public Asker[] Birlik2 { get { return birlik2; }set { birlik2 = value; } }
       public int takim2sagligi = 700;

        public Takim()
        {
            for(int i=0;i<4;i++)
            {
                Birlik1[i]= new Er();
            }

            for(int i=4;i<6;i++)
            {
                birlik1[i] = new Yuzbasi();

            }
            for(int i=6;i<7;i++)
            {
                birlik1[i] = new Tegmen();
            }

            for (int i = 0; i < 4; i++)
            {
                Birlik2[i] = new Er();
            }

            for (int i = 4; i < 6; i++)
            {
                birlik2[i] = new Yuzbasi();

            }
            for (int i = 6; i < 7; i++)
            {
                birlik2[i] = new Tegmen();
            }
          
       
       



                }


            }


            }
           







