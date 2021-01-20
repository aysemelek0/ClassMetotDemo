using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " İsimli müşteri  sisteme eklendi.");

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşterilerin  bilgileri  listelendi. " + "İsim:" + musteri.ad + " Soyad: " + musteri.soyad +
             " ID No:  " + musteri.Id + " Yaş:  " + musteri.yas);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " İsimli müşteri sistemden silindi. ");
        }
    }
}
