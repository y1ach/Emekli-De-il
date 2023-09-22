using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cinsiyetiniz Nedir? E/K");
        string cinsiyet = Console.ReadLine().ToLower();

        if (cinsiyet == "e" || cinsiyet == "k")
        {
            Console.WriteLine("Yaşınızı Giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaşınızı Giriniz");
            double maas = Convert.ToDouble(Console.ReadLine());

            int emeklilikYasi = (cinsiyet == "e") ? 60 : 58;
            int minCalismaGunu = (cinsiyet == "e") ? 6000 : 4500;

            if (yas >= emeklilikYasi)
            {
                double ikramiye = maas * 10;
                Console.WriteLine($"Emekli oldunuz. İkramiyeniz: {ikramiye:C}");
            }
            else
            {
                Console.WriteLine("Kaç Gün Çalıştınız?");
                int calismaGun = Convert.ToInt32(Console.ReadLine());

                if (calismaGun >= minCalismaGunu)
                {
                    double ikramiye = maas * 11;
                    Console.WriteLine($"Emekli oldunuz. İkramiyeniz: {ikramiye:C}");
                }
                else
                {
                    Console.WriteLine("Çalışma Gününüz Doldurmuş Bulunmamaktasınız. Emekli Olamadınız. Çalış Köle!");
                }
            }
        }
        else
        {
            Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Tekrar Giriniz.");
        }
    }
}
