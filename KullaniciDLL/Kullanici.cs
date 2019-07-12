using System;

namespace KullaniciDLL
{

    public class Kullanici
    {
        int kullaniciid;
        string _isim, _soyisim, _sifre;
        string kadi;

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }

        public string Isim
        {
            get { return _isim; }
            set { _isim = value; }
        }

        public string Soyisim
        {
            get { return _soyisim; }
            set { _soyisim = value; }
        }

        public int KullaniciID
        {
            get { return kullaniciid; }
            set { kullaniciid = value; }
        }

        public string KullaniciAdi
        {
            get { return kadi; }
            set { kadi = value; }
        }


    }
}
