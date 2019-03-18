using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker 
    {
       
     
        Bolge konum;
        Ermeydani m = new Ermeydani();


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

            int sayi = r.Next(0, 2);
            m.HareketKontrol(this, sayi);
            SinirKontrol(sayi);

            
           
             
           



        }
        public void SinirKontrol(int m)
        {


            if (m == 0)
            {
                if ((Koordinat.X == 0 && Koordinat.Y==0)&&saglik!=0||(Koordinat.X==15&&Koordinat.Y==0)&&saglik != 0)//(0,0)yukarı ve (15,0)aşağı n
                {
                    Koordinat.Y = Koordinat.Y + 1;
                   
                }
                else
                {

                        Koordinat.X = Koordinat.X - 1;

                }

            }
            if(m==1)
            {
              

                if ((Koordinat.X == 15&&Koordinat.Y==15) &&(Koordinat.X==0&&Koordinat.Y==15)&& saglik != 0)  //(15,15 )aşağı ve (0,15)yukarı 
                {
                    Koordinat.Y = Koordinat.Y- 1;

                }
                else
                {

                        Koordinat.X = Koordinat.X + 1;


                }

            }



        }

        public override void AtesEt()
        {
            Random r = new Random();
            int sayi = r.Next(3);

            if (sayi == 0)
            {
                hasar = 5;
            }
            if (sayi == 1)
            {
                hasar = 10;

            }
            if (sayi == 2)
            {
                hasar = 15;
            }
            m.AtesEtKontrol(this,sayi);



        }


        public override void Bekle()
        {
            Koordinat.X = Koordinat.X;
            Koordinat.Y = Koordinat.Y;


        }


    }


}
