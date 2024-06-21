using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
öğrencinin öğrenciNo, isim, soyisim, vize, kısasınav, final ve okulismi adında değişkenler olacak ve erişim belirleyicileri private durumda olacak.
ogrenciBilgiGoster(),ogrenciOrtalamasiBul() ve okulGetir() adında metotlar bulunacak.
Ögrencinin seçimlerine göre islemler yapilacak: 
1-Öğrenci Bilgilerini gösterr
2-Öğrenci Ortalşamasını Göster
3-Öğrencinin okulunu getir
4-Çıkış Yap
*/
namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(2005416458, "Elisa", "Badeci", 75, 63, 80, "Kaynarca Üniversitesi") ;
            Console.WriteLine("Öğrenci Bilgi Sistemine Hoşgeldiniz");
            Console.WriteLine("Gerçekleştirmek istediğiniz işlemi seçiniz");
            islemler();

            while (kontrol)
            {
                string secim = Console.ReadLine();
                switch(secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogrenciOrtalama = ogrenci1.OgrenciNotu();
                        Console.WriteLine("Öğrencinin Ortalaması: " + ogrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;


                }

            }
            
        }

        static void islemler()
        {
            Console.WriteLine("1 - Öğrenci Bilgilerini Göster");
            Console.WriteLine("2 - Öğrenci Ortalamasını Göster");
            Console.WriteLine("3 - Öğrencinin okulunu getir");
            Console.WriteLine("4 - Çıkış Yap");
        }
    }
}
