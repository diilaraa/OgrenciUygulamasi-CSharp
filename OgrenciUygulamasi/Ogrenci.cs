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

        public Ogrenci(int _ogrenciID, string _isim, string _soyisim, int _vize, int _kisaSinav, int _final, string _okulIsmi) //Parametere olduğu anlaşılsın diye _ koydum
        {
            ogrenciId = _ogrenciID;
            isim = _isim;
            soyisim = _soyisim;
            vize = _vize;
            kisaSinav = _kisaSinav; 
            final = _final; 
            okulIsmi = _okulIsmi;
        }
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
        public double OgrenciNotu() //not virgüllüde olabileceğinden double tanımlandı
        {
            double ortalama = vize*0.35 + kisaSinav*0.15 + final*0.5;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Ogrencinin okuduğu Üniversite:" + okulIsmi);
        }
    }
}
