using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            //yukardakinin amacı ürün var onu tanımlıyoruz ve dizilerde de kolaylık sağlar kullanabiliriz.Manav yönetim sistemi gibi

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //Urun urun demek >>> dönecek elemana takma ismi veriyoruz.
            // type-safe == neyle çaışcağımı bilmek istiyorum değişkenin tipini ver diyor. C# böyle çalışır
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");

                Console.WriteLine("Ürünün Adı: " + urun.Adi + "\nÜrünün Açıklaması: " + urun.Aciklama + "\nFiyat: " + urun.Fiyatı + "\n");


            }



            Console.WriteLine("------------Metotlar---------------");

            //Bu işlemin ismi instance- örnek 
            //Encapsulation


            SepetManager sepetmanager= new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            //bu alttaki de farklı bi kullanım ama tercih edilmez.Yeni bir şey eklemek istediğin zaman çok uğraştırır.
            sepetmanager.Ekle2("Armut", "Yeşil", 14);
            sepetmanager.Ekle2("Ceviz", "Sarı", 50);
            
        }
    }
}


// dont repeat yourself - dry prensibi - clean code -  best practice  
// metotlar tekrar kullanmayı önler . Bir değişiklik olduğunda kolaylık sağlar.
