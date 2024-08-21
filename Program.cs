using System;
using CarFactory;


class Program
{

    static public void Main(string[] args)
    {
        List<Car> arabalar = new List<Car>();

        while (true)
        {
            // Kullanıcıya araba üretmek isteyip istemediğini soruyoruz 
            Console.WriteLine("Araba üretmek istiyor musunuz? (e/h): "); 
            string cevap = Console.ReadLine().ToLower();
            // Cevap hayırsa programı sonlandırıyoruz
            if (cevap == "h")
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;
            }
            // Cevap "e" ise yeni bir Car nesnesi üreterek programı başlatıyoruz
            else if (cevap == "e")
            {
                Car yeniAraba = new Car();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

            KapıSayisiYeniden:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    yeniAraba.KapiSayisi = int.Parse(Console.ReadLine());
                    if (!(yeniAraba.KapiSayisi == 2 || yeniAraba.KapiSayisi == 4))
                    {
                        Console.WriteLine("2 ve 4 değeri gir.");
                        goto KapıSayisiYeniden;
                    }

                }


                catch (FormatException)
                {

                    Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                    goto KapıSayisiYeniden;
                }


                arabalar.Add(yeniAraba);

                Console.WriteLine("\nYeni Car Bilgileri:");
                Console.WriteLine($"Üretim Tarihi: {yeniAraba.UretimTarihi}");
                Console.WriteLine($"Seri Numarası: {yeniAraba.SeriNumarasi}");
                Console.WriteLine($"Marka: {yeniAraba.Marka}");
                Console.WriteLine($"Model: {yeniAraba.Model}");
                Console.WriteLine($"Renk: {yeniAraba.Renk}");
                Console.WriteLine($"Kapı Sayısı: {yeniAraba.KapiSayisi}");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' giriniz.");
            }

            // Kullanıcıya başka araba üretmek isteyip istemediğini soralım
            Console.WriteLine("\nBaşka bir araba üretmek ister misiniz? (e/h): ");
            string devamCevap = Console.ReadLine().ToLower();

            if (devamCevap == "h")
            {
            bitis:
                Console.WriteLine("\nTüm Arabalar:");
                foreach (var araba in arabalar)
                {
                    Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
                }
                break;
            }
            else if (devamCevap != "e")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' giriniz.");
            }
        }

    }




}