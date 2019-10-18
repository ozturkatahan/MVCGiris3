namespace MVCGiris3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCGiris3.Models.KisiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCGiris3.Models.KisiContext context)
        {
            if (!context.Kisiler.Any())
            {
                context.Kisiler.Add(new Models.Kisi { Ad = "Ayd�n" });
                context.Kisiler.Add(new Models.Kisi { Ad = "Ayten" });
                context.Kisiler.Add(new Models.Kisi { Ad = "Aykut" });
            }

            if (!context.Sehirler.Any())
            {
                if (!context.Sehirler.Any())
                {
                    context.Sehirler.Add(new Models.Sehir { Id = 1, SehirAd = "Adana" });
                    context.Sehirler.Add(new Models.Sehir { Id = 2, SehirAd = "Ad�yaman" });
                    context.Sehirler.Add(new Models.Sehir { Id = 3, SehirAd = "Afyonkarahisar" });
                    context.Sehirler.Add(new Models.Sehir { Id = 4, SehirAd = "A�r�" });
                    context.Sehirler.Add(new Models.Sehir { Id = 5, SehirAd = "Amasya" });
                    context.Sehirler.Add(new Models.Sehir { Id = 6, SehirAd = "Ankara" });
                    context.Sehirler.Add(new Models.Sehir { Id = 7, SehirAd = "Antalya" });
                    context.Sehirler.Add(new Models.Sehir { Id = 8, SehirAd = "Artvin" });
                    context.Sehirler.Add(new Models.Sehir { Id = 9, SehirAd = "Ayd�n" });
                    context.Sehirler.Add(new Models.Sehir { Id = 10, SehirAd = "Bal�kesir" });
                    context.Sehirler.Add(new Models.Sehir { Id = 11, SehirAd = "Bilecik" });
                    context.Sehirler.Add(new Models.Sehir { Id = 12, SehirAd = "Bing�l" });
                    context.Sehirler.Add(new Models.Sehir { Id = 13, SehirAd = "Bitlis" });
                    context.Sehirler.Add(new Models.Sehir { Id = 14, SehirAd = "Bolu" });
                    context.Sehirler.Add(new Models.Sehir { Id = 15, SehirAd = "Burdur" });
                    context.Sehirler.Add(new Models.Sehir { Id = 16, SehirAd = "Bursa" });
                    context.Sehirler.Add(new Models.Sehir { Id = 17, SehirAd = "�anakkale" });
                    context.Sehirler.Add(new Models.Sehir { Id = 18, SehirAd = "�ank�r�" });
                    context.Sehirler.Add(new Models.Sehir { Id = 19, SehirAd = "�orum" });
                    context.Sehirler.Add(new Models.Sehir { Id = 20, SehirAd = "Denizli" });
                    context.Sehirler.Add(new Models.Sehir { Id = 21, SehirAd = "Diyarbak�r" });
                    context.Sehirler.Add(new Models.Sehir { Id = 22, SehirAd = "Edirne" });
                    context.Sehirler.Add(new Models.Sehir { Id = 23, SehirAd = "Elaz��" });
                    context.Sehirler.Add(new Models.Sehir { Id = 24, SehirAd = "Erzincan" });
                    context.Sehirler.Add(new Models.Sehir { Id = 25, SehirAd = "Erzurum" });
                    context.Sehirler.Add(new Models.Sehir { Id = 26, SehirAd = "Eski�ehir" });
                    context.Sehirler.Add(new Models.Sehir { Id = 27, SehirAd = "Gaziantep" });
                    context.Sehirler.Add(new Models.Sehir { Id = 28, SehirAd = "Giresun" });
                    context.Sehirler.Add(new Models.Sehir { Id = 29, SehirAd = "G�m��hane" });
                    context.Sehirler.Add(new Models.Sehir { Id = 30, SehirAd = "Hakkari" });
                    context.Sehirler.Add(new Models.Sehir { Id = 31, SehirAd = "Hatay" });
                    context.Sehirler.Add(new Models.Sehir { Id = 32, SehirAd = "Isparta" });
                    context.Sehirler.Add(new Models.Sehir { Id = 33, SehirAd = "Mersin" });
                    context.Sehirler.Add(new Models.Sehir { Id = 34, SehirAd = "�stanbul" });
                    context.Sehirler.Add(new Models.Sehir { Id = 35, SehirAd = "�zmir" });
                    context.Sehirler.Add(new Models.Sehir { Id = 36, SehirAd = "Kars" });
                    context.Sehirler.Add(new Models.Sehir { Id = 37, SehirAd = "Kastamonu" });
                    context.Sehirler.Add(new Models.Sehir { Id = 38, SehirAd = "Kayseri" });
                    context.Sehirler.Add(new Models.Sehir { Id = 39, SehirAd = "K�rklareli" });
                    context.Sehirler.Add(new Models.Sehir { Id = 40, SehirAd = "K�r�ehir" });
                    context.Sehirler.Add(new Models.Sehir { Id = 41, SehirAd = "Kocaeli" });
                    context.Sehirler.Add(new Models.Sehir { Id = 42, SehirAd = "Konya" });
                    context.Sehirler.Add(new Models.Sehir { Id = 43, SehirAd = "K�tahya" });
                    context.Sehirler.Add(new Models.Sehir { Id = 44, SehirAd = "Malatya" });
                    context.Sehirler.Add(new Models.Sehir { Id = 45, SehirAd = "Manisa" });
                    context.Sehirler.Add(new Models.Sehir { Id = 46, SehirAd = "Kahramanmara�" });
                    context.Sehirler.Add(new Models.Sehir { Id = 47, SehirAd = "Mardin" });
                    context.Sehirler.Add(new Models.Sehir { Id = 48, SehirAd = "Mu�la" });
                    context.Sehirler.Add(new Models.Sehir { Id = 49, SehirAd = "Mu�" });
                    context.Sehirler.Add(new Models.Sehir { Id = 50, SehirAd = "Nev�ehir" });
                    context.Sehirler.Add(new Models.Sehir { Id = 51, SehirAd = "Ni�de" });
                    context.Sehirler.Add(new Models.Sehir { Id = 52, SehirAd = "Ordu" });
                    context.Sehirler.Add(new Models.Sehir { Id = 53, SehirAd = "Rize" });
                    context.Sehirler.Add(new Models.Sehir { Id = 54, SehirAd = "Sakarya" });
                    context.Sehirler.Add(new Models.Sehir { Id = 55, SehirAd = "Samsun" });
                    context.Sehirler.Add(new Models.Sehir { Id = 56, SehirAd = "Siirt" });
                    context.Sehirler.Add(new Models.Sehir { Id = 57, SehirAd = "Sinop" });
                    context.Sehirler.Add(new Models.Sehir { Id = 58, SehirAd = "Sivas" });
                    context.Sehirler.Add(new Models.Sehir { Id = 59, SehirAd = "Tekirda�" });
                    context.Sehirler.Add(new Models.Sehir { Id = 60, SehirAd = "Tokat" });
                    context.Sehirler.Add(new Models.Sehir { Id = 61, SehirAd = "Trabzon" });
                    context.Sehirler.Add(new Models.Sehir { Id = 62, SehirAd = "Tunceli" });
                    context.Sehirler.Add(new Models.Sehir { Id = 63, SehirAd = "�anl�urfa" });
                    context.Sehirler.Add(new Models.Sehir { Id = 64, SehirAd = "U�ak" });
                    context.Sehirler.Add(new Models.Sehir { Id = 65, SehirAd = "Van" });
                    context.Sehirler.Add(new Models.Sehir { Id = 66, SehirAd = "Yozgat" });
                    context.Sehirler.Add(new Models.Sehir { Id = 67, SehirAd = "Zonguldak" });
                    context.Sehirler.Add(new Models.Sehir { Id = 68, SehirAd = "Aksaray" });
                    context.Sehirler.Add(new Models.Sehir { Id = 69, SehirAd = "Bayburt" });
                    context.Sehirler.Add(new Models.Sehir { Id = 70, SehirAd = "Karaman" });
                    context.Sehirler.Add(new Models.Sehir { Id = 71, SehirAd = "K�r�kkale" });
                    context.Sehirler.Add(new Models.Sehir { Id = 72, SehirAd = "Batman" });
                    context.Sehirler.Add(new Models.Sehir { Id = 73, SehirAd = "��rnak" });
                    context.Sehirler.Add(new Models.Sehir { Id = 74, SehirAd = "Bart�n" });
                    context.Sehirler.Add(new Models.Sehir { Id = 75, SehirAd = "Ardahan" });
                    context.Sehirler.Add(new Models.Sehir { Id = 76, SehirAd = "I�d�r" });
                    context.Sehirler.Add(new Models.Sehir { Id = 77, SehirAd = "Yalova" });
                    context.Sehirler.Add(new Models.Sehir { Id = 78, SehirAd = "Karab�k" });
                    context.Sehirler.Add(new Models.Sehir { Id = 79, SehirAd = "Kilis" });
                    context.Sehirler.Add(new Models.Sehir { Id = 80, SehirAd = "Osmaniye" });
                    context.Sehirler.Add(new Models.Sehir { Id = 81, SehirAd = "D�zce" });
                }

            }
        }
    }
}
