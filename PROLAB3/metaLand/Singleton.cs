using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaLand
{
    public sealed class Singleton
    {

        private Singleton() { }

        private static Singleton _instance;

        
        public int[] array;
        public string KullanıcıAd;
        public string KullanıcıSoyAd;
        public string KullnıcıSifre;
        public string oyuncuAd;
        public string oyuncuSifre;
        public string yöneticiAd;
        public string yöneticiSifre;
        public string haritaID;
        public string haritaIDOyuncu;
        public string haritaBoyutOyuncu;
        public int haritaboyut;
        public int ürünFİyat;
        public int alanNo;
        public string calısanAd;
        public string calısanHarita;
        public int calısanAlanNo;
        public int calısanSaat;
        public int calısanUcret;


        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                _instance.array = new int[5];
                _instance.KullanıcıAd = null;
                _instance.KullanıcıSoyAd = null;   
                _instance.KullnıcıSifre = null;
                _instance.oyuncuAd = null;
                _instance.oyuncuSifre = null;
                _instance.yöneticiAd = null;
                _instance.yöneticiSifre = null;
                _instance.haritaID = null;
                _instance.haritaboyut = 0;
                _instance.ürünFİyat = 0;
                _instance.alanNo = 0;
                _instance.calısanAd = null;
                _instance.calısanHarita = null;
                _instance.calısanAlanNo = 0;
                _instance.calısanSaat = 0;
                _instance.calısanUcret = 0;
                _instance.haritaBoyutOyuncu = null;
                _instance.haritaIDOyuncu=null;

            }
            return _instance;
        }



    }
}
