using System;

enum TrafikIsigi
{
    Red,
    Yellow,
    Green
}

class TrafikKontrol
{
    public static string DurumMesaji(TrafikIsigi isik)
    {
        switch (isik)
        {
            case TrafikIsigi.Red:
                return "Dur! Kırmızı ışık yanıyor.";
            case TrafikIsigi.Yellow:
                return "Hazır ol! Sarı ışık yanıyor.";
            case TrafikIsigi.Green:
                return "Geç! Yeşil ışık yanıyor.";
            default:
                return "Geçersiz durum!";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrafikIsigi durum = TrafikIsigi.Red;

        Console.WriteLine("Durum: " + durum);
        Console.WriteLine("Mesaj: " + TrafikKontrol.DurumMesaji(durum)); // Dur! Kırmızı ışık yanıyor.

        durum = TrafikIsigi.Green;
        Console.WriteLine("Durum: " + durum);
        Console.WriteLine("Mesaj: " + TrafikKontrol.DurumMesaji(durum)); // Geç! Yeşil ışık yanıyor.
    }
}
