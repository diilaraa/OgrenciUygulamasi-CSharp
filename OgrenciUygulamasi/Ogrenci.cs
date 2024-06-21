using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    public class Ogrenci
    {
        private int ogrenciId;
        private string isim;
        private string soyisim;
        private int vize;
        private int kisaSinav;
        private int final;
        private string okulIsmi;

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası:" + ogrenciId);
            Console.WriteLine("Öğrenci İsmi:" + isim);
            Console.WriteLine("Öğrenci Soyismi:" + soyisim);
            Console.WriteLine("Öğrenci Vize Notu:" + vize);
            Console.WriteLine("Öğrenci Kısa Sınav Notu:" + kisaSinav);
            Console.WriteLine("Öğrenci Final Notu:" + final);
            Console.WriteLine("Öğrenci Üniversite İsmi:" + okulIsmi);
        }

    }
}
