using System;
using System.Collections.Generic;
using System.Text;

namespace KullaniciDLL
{
    public class Admin : Kullanici
    {
        DateTime sistemegiris;

        public DateTime SistemGirisTarihi
        {
            get { return sistemegiris; }
            set { sistemegiris = value; }
        }


    }
}





//admin sisteme giris yaptigi tarih rapor -> ID,AdminID,GirişTarihi