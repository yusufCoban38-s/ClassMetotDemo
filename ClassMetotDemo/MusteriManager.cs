using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriEkle)
        {
            Console.WriteLine("Müşteri Eklendi :"+musteriEkle.Ad+" "+musteriEkle.Soyad);
        }
        public void Listele(Musteri[] musteris)
        {
            Console.WriteLine("Müşteri Listesi");
            foreach (var musteri0 in musteris)
            {
                Console.WriteLine("İsim : " + musteri0.Ad + "\n" + "Soyisim : " + musteri0.Soyad + "\n" + "Müşteri Id : " + musteri0.Id + "\n" + "Müşteri Tc No : " + musteri0.TcNO + "\n");
            }
        }
        public void Sil(Musteri musteriSil)
        {
            Console.WriteLine("Müşteri Silindi : "+musteriSil.Ad+" "+musteriSil.Soyad);
        }
    }
}
