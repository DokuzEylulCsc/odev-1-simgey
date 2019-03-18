using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {

        Ermeydani m = new Ermeydani();
       
        Bolge konum;

       
        public Bolge k
        {
            get
            {
                return konum;
            }
            set
            {
                konum = value;
            }

        }




        public override void HaraketEt()
        {
            Random r = new Random();

            int sayi = r.Next(4);
            m.HareketKontrol(this, sayi);
            SinirKontrol(sayi);


           
        }
        public void SinirKontrol(int m)
        {
          
            if (m == 0)
            {
                if (Koordinat.X==0&&saglik!=0||(Koordinat.X == 0 && Koordinat.Y == 0) &&saglik!=0||(Koordinat.X == 15 && Koordinat.Y == 0) && saglik != 0)//(0,0)yukarı ve (15,0)aşağı n
                {
                    Koordinat.Y = Koordinat.Y + 1;
                  

                }
                else
                {

                    Koordinat.X = Koordinat.X - 1;

                }


            }
            if (m == 1)
            {


                if (Koordinat.X == 15 &&saglik!=0||(Koordinat.X == 15 && Koordinat.Y == 15) &&saglik!=0||(Koordinat.X == 0 && Koordinat.Y == 15) && saglik != 0)  //(15,15 )aşağı ve (0,15)yukarı 
                {
                    Koordinat.Y = Koordinat.Y - 1;

                }
                else
                {

                    Koordinat.X = Koordinat.X + 1;


                }
                if(m==2)
                {
                    if(Koordinat.Y==0&&Koordinat.X!=0&&Koordinat.X!=15&&saglik!=0)
                    {
                        Koordinat.Y = Koordinat.Y - 1;
                    }
                    else
                    {
                        Koordinat.Y = Koordinat.Y + 1;//sağ
                    }
                }
                if(m==3)
                {
                    if(Koordinat.Y==15&&Koordinat.X!=0&&Koordinat.X!=15&&saglik!=0)
                    {
                        Koordinat.Y = Koordinat.Y + 1;
                    }
                    else
                    {
                        Koordinat.Y = Koordinat.Y - 1;//sol
                    }
                }

              
            }




        }


        public override void AtesEt()
        {
            Random r = new Random();
            int sayi = r.Next(3);

            if (sayi == 0)
            {
                hasar = 10;
            }
            if (sayi == 1)
            {
                hasar = 20;

            }
            if (sayi == 2)
            {
                hasar = 25;
            }
            m.AtesEtKontrol(this, sayi);

        }



        public override void Bekle()
        {
            Koordinat.X = Koordinat.X;
            Koordinat.Y = Koordinat.Y;

        }
    }

}
