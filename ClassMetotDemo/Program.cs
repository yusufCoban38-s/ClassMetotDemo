using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Yusuf";
            musteri1.Soyad = "Çoban";
            musteri1.TcNO = "128 605 812 92";
            musteri1.Id = 10;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Zeynep";
            musteri2.Soyad = "Yıldız";
            musteri2.TcNO = "122 622 829 82";
            musteri2.Id = 14;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Derya";
            musteri3.Soyad = "Yılmaz";
            musteri3.TcNO = "144 655 832 98";
            musteri3.Id = 16;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "İsmail";
            musteri4.Soyad = "Aydın";
            musteri4.TcNO = "144 632 823 33";
            musteri4.Id = 19;

            Musteri[] musteri_ = new Musteri[] {musteri1,musteri2,musteri3,musteri4};

           
            // MetotLar--
            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Listele(musteri_);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri4);
            musteriEkle.Ekle(musteri2);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            musteriEkle.Sil(musteri3);

           
            Console.ReadLine();
            
        }
    }
}
