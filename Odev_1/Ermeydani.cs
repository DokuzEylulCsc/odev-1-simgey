using System;

namespace Odev_1
{
    class Ermeydani  //Bazı yerlerde emir bulut ve tayfun yaltur dan yardım aldım.
    {
        Bolge[,] harita = new Bolge[16, 16];

        public Bolge[,] Harita { get { return harita; } set { harita = value; } }

        public Ermeydani()  //meydanı olusturuyoruz
        {

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    harita[i, j] = new Bolge(i, j);
                }
            }



        }

        public void Konum()   //Birlikleri meydan a yerleştiriyoruz.
        {
            Takim t = new Takim();


            for (int j = 0; j < 4; j++)
            {
                t.Birlik1[j].Koordinat = harita[0, j];

            }
            for (int j = 4; j < 6; j++)
            {
                t.Birlik1[j].Koordinat = harita[0, j];
            }
            for (int j = 6; j < 7; j++)
            {
                t.Birlik1[j].Koordinat = harita[0, j];

            }
            for (int j = 8; j < 12; j++)
            {
                t.Birlik2[j].Koordinat = harita[15, j];

            }
            for (int j = 12; j < 14; j++)
            {
                t.Birlik2[j].Koordinat = harita[15, j];
            }
            for (int j = 14; j < 15; j++)
            {
                t.Birlik2[j].Koordinat = harita[15, j];

            }



        }



       public void HangiAsker() // hangi asker olucagını seciyor
        {

            Er e = new Er();
            Tegmen t = new Tegmen();
            Yuzbasi y = new Yuzbasi();
            Random r = new Random();
            int sayi = r.Next(1, 4);


            if (sayi == 0)
            {

                Sec(e);
                AtesEtKontrol(e, sayi);

            }
            if (sayi == 1)
            {

                Sec(t);
                AtesEtKontrol(t, sayi);
            }
            if (sayi == 2)
            {

                Sec(y);
                AtesEtKontrol(y, sayi);

            }



        }
        public void Sec(Asker asker) // askerin yapacagı hareketi belirliyor.
        { Takim t = new Takim();
            do
            {


                Random r = new Random();
                int sayi2 = r.Next(1, 4);
                if (sayi2 == 0)
                {
                    asker.HaraketEt();

                }
                if (sayi2 == 1)
                {
                    asker.AtesEt();


                }
                if (sayi2 == 2)
                {
                    asker.Bekle();
                }

            } while (t.takim1sagligi != 0 && t.takim2sagligi != 0);



            }

        public void AtesEtKontrol(Asker a,int m)  //ates edebildiği menzilde asker var mı kontrol 
        {
            Takim t = new Takim();

            foreach (Asker asker in t.Birlik1)
            {    if(m==0)
                {
                    if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0)
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderkenasker varsa

                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " ("+ (asker.Koordinat.X +","+asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " "+ (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                    if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                }

                if (m==1)
                {
                    if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0)
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderkenasker varsa

                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                    if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X - 2 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0)
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X + 2 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderkenasker varsa

                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                    if (a.Koordinat.Y - 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y + 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                }
                if (m == 2)
                {
                    if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0)
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderkenasker varsa

                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                    if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X - 2 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0)
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X + 2== asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderkenasker varsa

                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                    if (a.Koordinat.Y - 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y + 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 2 == asker.Koordinat.X && a.Koordinat.Y - 2 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }

                    }


                    if (a.Koordinat.X - 2 == asker.Koordinat.X && a.Koordinat.Y + 2 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }



                    if (a.Koordinat.X + 2== asker.Koordinat.X && a.Koordinat.Y - 2== asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 2 == asker.Koordinat.X && a.Koordinat.Y + 2 == asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 3 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0)
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }
                    if (a.Koordinat.X + 3 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderkenasker varsa

                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }

                    if (a.Koordinat.Y - 3 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y + 3== asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 3 == asker.Koordinat.X && a.Koordinat.Y - 3== a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 3 == asker.Koordinat.X && a.Koordinat.Y + 3 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 3 == asker.Koordinat.X && a.Koordinat.Y - 3 == asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                    {
                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 3 == asker.Koordinat.X && a.Koordinat.Y + 3 == asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                    {

                        asker.saglik -= a.hasar;
                        t.takim1sagligi -= a.hasar;
                        Console.WriteLine("1.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim1sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:2.TAKİM");
                        }
                    }






                }


            }


                foreach (Asker asker in t.Birlik2)
                {
                if(m==0)
                {
                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }

                }
                if (m==1)
                {
                    if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }
                    if (a.Koordinat.X - 2 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 2 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y - 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.Y + 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                }
                if (m == 2)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                        {
                            asker.saglik -= a.hasar;
                            t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }



                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                        {
                            asker.saglik -= a.hasar;
                            t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                        if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                        {
                            asker.saglik -= a.hasar;
                            t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                        if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                        {
                            asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                        {
                            asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                        {
                            asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                        {
                            asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                        {
                            asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }




                    if (a.Koordinat.X - 2== asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 2 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y - 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.Y + 2 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 2 == asker.Koordinat.X && a.Koordinat.Y - 2 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 2== asker.Koordinat.X && a.Koordinat.Y + 2 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.X + 2 == asker.Koordinat.X && a.Koordinat.Y - 2== asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.X + 2== asker.Koordinat.X && a.Koordinat.Y + 2== asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }
                    if (a.Koordinat.X - 3 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }



                    if (a.Koordinat.X + 3== asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.Y - 3 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.Y + 3 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 3 == asker.Koordinat.X && a.Koordinat.Y - 3 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.X - 3 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }


                    if (a.Koordinat.X + 3 == asker.Koordinat.X && a.Koordinat.Y - 3 == asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi == 0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }

                    }


                    if (a.Koordinat.X + 3 == asker.Koordinat.X && a.Koordinat.Y + 3== asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                    {
                        asker.saglik -= a.hasar;
                        t.takim2sagligi -= a.hasar;
                        Console.WriteLine("2.takimdan" + " (" + (asker.Koordinat.X + "," + asker.Koordinat.Y) + "Koordinatlarındaki askeri" + a.hasar + " canı azalmıştır KALAN CAN:" + " " + (asker.saglik - a.hasar ));
                        if (t.takim2sagligi==0)
                        {
                            Console.WriteLine("OYUN BİTTİ....Kazanan:1.TAKİM");
                        }
                    }
                }
                }

            }





            public bool HareketKontrol(Asker a, int y)
            {
                Takim t = new Takim();

                foreach (Asker asker in t.Birlik1)
                { if (y == 0)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                        {
                            return false;
                        }
                    }
                    if (y == 1)
                    {
                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                        {
                            return false;
                        }
                    }
                    if (y == 2)
                    {
                        if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                        {
                            return false;

                        }
                    }
                    if (y == 3)
                    {
                        if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                        {
                            return false;

                        }
                    }
                    if (y == 4)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                        {
                            return false;
                        }
                    }
                    if (y == 5)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                        {
                            return false;

                        }

                    }
                    if (y == 6)
                    {
                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                        {
                            return false;

                        }
                    }
                    if (y == 7)
                    {
                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                        {

                            return false;
                        }
                    }



          

                }


                foreach (Asker asker in t.Birlik2)
                { if (y == 0)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //yukarı giderken dolu olması
                        {
                            return false;

                        }
                    }

                    if (y == 1)
                    {
                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y == asker.Koordinat.Y && asker.saglik != 0) //asagi giderken dolu olması

                        {
                            return false;
                        }
                    }
                    if (y == 2)
                    {
                        if (a.Koordinat.Y - 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) //sola giderkn dolu olması
                        {
                            return false;

                        }
                    }
                    if (y == 3)
                    {
                        if (a.Koordinat.Y + 1 == asker.Koordinat.Y && a.Koordinat.X == asker.Koordinat.X && asker.saglik != 0) // sağa giderken dolu olmasi
                        {
                            return false;
                        }
                    }
                    if (y == 4)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == a.Koordinat.Y && asker.saglik != 0) //sol çapraz yukarı
                        {
                            return false;
                        }
                    }
                    if (y == 5)
                    {
                        if (a.Koordinat.X - 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0) //sağ çapraz yukarı
                        {
                            return false;

                        }
                    }
                    if (y == 6)
                    {
                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y - 1 == asker.Koordinat.Y && asker.saglik != 0) //sol  çapraz aşaği
                        {
                            return false;
                            

                        }
                    }
                    if (y == 7)
                    {
                        if (a.Koordinat.X + 1 == asker.Koordinat.X && a.Koordinat.Y + 1 == asker.Koordinat.Y && asker.saglik != 0)// sağ çapraz aşağı
                        {
                            return false;
                        }
                    }


                }
                return true;

             
            }







    }
    }










    