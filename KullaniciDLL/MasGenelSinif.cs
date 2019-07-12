using System;
using System.Collections.Generic;
using System.Text;

namespace MasDLL
{
    public class Rapor
    {
       // int KeyID, AliciID, SiparisID;
      //  DateTime BaslamaTarih, BitisTarih;
       // string UrunKodu, UretimAdet, HurdaAdet, SiparisAdet, OperatorGrupAd, OperasyonTuru, DurusTuru, MakineAdi,NetAdet,AliciAD;
       // float OrtalamaUretimMiktari, OrtalamaSiparisMiktari, OrtalamaHurdaMiktari, OrtalamaPerformans;

        int makineid, operasyonid,en,alicisirketno,boy,siparisid,aliciid,keyid,planid,isemrino,isemriadet,urunid,miktar,uretimadet, hurdaadet, siparisadet;
        int durusid, uretimid;
        string makineadi, makinekodu, operasyonadi, urunadi, urunaciklama,aliciad,durusad,durusaciklama,urunkodu;
        DateTime istedigitarih, teslimtarihi,baslamatarihi,bitistarihi,durusbaslangictarih,durusbitistarih;



        public int KeyID
        {
            get { return keyid; }
            set { keyid = value; }
        }

        public int AliciID
        {
            get { return aliciid; }
            set { aliciid = value; }
        }

        public int SiparisID
        {
            get { return siparisid; }
            set { siparisid = value; }
        }

        public DateTime BaslamaTarih
        {
            get { return baslamatarihi; }
            set { baslamatarihi = value; }
        }

        public DateTime BitisTarih
        {
            get { return bitistarihi; }
            set { bitistarihi = value; }
        }

        public string UrunKodu
        {
            get { return urunkodu; }
            set { urunkodu = value; }
        }

        public int UretimAdet
        {
            get { return uretimadet; }
            set { uretimadet = value; }
        }

        public int HurdaAdet
        {
            get { return hurdaadet; }
            set { hurdaadet = value; }
        }

        public int SiparisAdet
        {
            get { return siparisadet; }
            set { siparisadet = value; }
        }

        public string MakineAdı
        {
            get { return makineadi; }
            set { makineadi = value; }
        }

        public int MakineID
        {
            get { return makineid; }
            set { makineid = value; }
        }

        public string MakineKodu
        {
            get { return makinekodu; }
            set { makinekodu = value; }
        }

        public string MakineAdi
        {
            get { return makineadi; }
            set { makineadi = value; }
        }

        public int OperasyonID
        {
            get { return operasyonid; }
            set { operasyonid = value; }
        }

        public string OperasyonAdi
        {
            get { return operasyonadi; }
            set { operasyonadi = value; }
        }

        public string AliciAD
        {
            get { return aliciad; }
            set { aliciad = value; }
        }

        public int AliciSirketNo
        {
            get { return alicisirketno; }
            set { alicisirketno = value; }
        }


    }
}



//işemri rapor tablosu siparisadet,aliciid,aliciad, keyid,baslamatarih,bitistarih,makineadi,urunkodu,aliciid,uretimadet,hurdaadet,netadet,siparisadet
//operator tablosu kişi 1, kişi 2, kişi 3 ad,soyad,tckimlik,dogumtarihi,sicilno,operatorgrupid
//operator grup tablosu kırmızı,turuncu,mavi grup id,grup
//admin tablosu admin kişi 1 , admin kişi 2 , admin kişi 3 id,ad,soyad,sifre,sicilno
//makine listesi tablosu kesici,lazer,robotikkol id,makineadi
//duruş tablosu arıza,yanık id,durusad
//operasyon tablosu rodaj,kesim id,opadi
//alici listesi -> id,ad
//ortalama performans rapor tablosu
// ortalama performans rapor tablosu view ile görülüyor