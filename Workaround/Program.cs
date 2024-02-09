using Entities.Concrete;
using System;
using System.Data;
using Business.Concrete;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer("Enes");
            SelamVer("Süleyman");
            SelamVer("Abuzer");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Enes";
            string ogrenci2 = "Sülo";
            string ogrenci3 = "Abuzer";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Enes";
            ogrenciler[1] = "Sülo";
            ogrenciler[2] = "Abuzer";
            
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Kırklareli", "Bursa", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Enes";
            person1.LastName = "Yüksel";
            person1.DateOfBirthYear = 2005;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Süleyman";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yeniSehirler1 = new List<string>{"Ankara 1", "İstanbul 1", "İzmir 1"};
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim= "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Enes";
            string soyad = "Yüksel";
            int dogumYili = 2005;
            long tcNo = 12345678910;


            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
