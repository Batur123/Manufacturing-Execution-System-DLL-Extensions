using System;
using System.Collections.Generic;
using System.Text;

namespace KullaniciDLL
{
    public class Operator : Kullanici
    {
        int operatorid,operatorgrupid;
        DateTime isbaslangictarih, iscikistarih;
        string tckimlik;
        string sicilno;
        int durumap;
        DateTime dogumtarih;

        public int OperatorID
        {
            get { return operatorid; }
            set { operatorid = value; }
        }

        public int DurumAP
        {
            get { return durumap; }
            set { durumap = value; }
        }

        public DateTime IsBaslangicTarihi
        {
            get { return isbaslangictarih; }
            set { isbaslangictarih = value; }
        }

        public DateTime IsCikisTarihi
        {
            get { return iscikistarih; }
            set { iscikistarih = value; }
        }

        public string SicilNO
        {
            get { return sicilno; }
            set { sicilno = value; }
        }

        public int OperatorGrupID
        {
            get { return operatorgrupid; }
            set { operatorgrupid = value; }
        }

        public string TCKimlik
        {
            get { return tckimlik; }
            set { tckimlik = value; }
        }

        public DateTime DogumTarihi
        {
            get { return dogumtarih; }
            set { dogumtarih = value; }
        }


    }
}


//operator tablosu kişi 1, kişi 2, kişi 3 ad,soyad,tckimlik,dogumtarihi,sicilno,operatorgrupid