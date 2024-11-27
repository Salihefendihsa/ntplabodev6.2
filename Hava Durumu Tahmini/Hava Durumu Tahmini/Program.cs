using System;

enum HavaDurumu
{
    Sunny,
    Rainy,
    Cloudy,
    Stormy
}

class HavaTahmini
{
    public static string Tavsiye(HavaDurumu durum)
    {
        switch (durum)
        {
            case HavaDurumu.Sunny:
                return "Hava güneşli! Dışarı çıkarken güneş gözlüğü alın.";
            case HavaDurumu.Rainy:
                return "Yağmurlu! Şemsiyenizi yanınıza alın.";
            case HavaDurumu.Cloudy:
                return "Bulutlu! Hava serin olabilir, hafif bir ceket giyin.";
            case HavaDurumu.Stormy:
                return "Fırtına var! Evde kalmayı tercih edin.";
            default:
                return "Geçersiz hava durumu!";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HavaDurumu bugun = HavaDurumu.Rainy;

        Console.WriteLine("Bugünkü hava durumu: " + bugun);
        Console.WriteLine("Tavsiye: " + HavaTahmini.Tavsiye(bugun)); // Yağmurlu! Şemsiyenizi yanınıza alın.

        bugun = HavaDurumu.Sunny;
        Console.WriteLine("Bugünkü hava durumu: " + bugun);
        Console.WriteLine("Tavsiye: " + HavaTahmini.Tavsiye(bugun)); // Hava güneşli! Dışarı çıkarken güneş gözlüğü alın.
    }
}
