using System;

struct KarmaşıkSayı
{
    public double Real { get; private set; }
    public double Imaginary { get; private set; }

    public KarmaşıkSayı(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Toplama işlemi
    public KarmaşıkSayı Topla(KarmaşıkSayı other)
    {
        return new KarmaşıkSayı(this.Real + other.Real, this.Imaginary + other.Imaginary);
    }

    // Çıkarma işlemi
    public KarmaşıkSayı Çıkar(KarmaşıkSayı other)
    {
        return new KarmaşıkSayı(this.Real - other.Real, this.Imaginary - other.Imaginary);
    }

    // Karmaşık sayıyı "a + bi" formatında döndüren metot
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        KarmaşıkSayı sayi1 = new KarmaşıkSayı(3, 4);
        KarmaşıkSayı sayi2 = new KarmaşıkSayı(1, 2);

        KarmaşıkSayı toplam = sayi1.Topla(sayi2);
        KarmaşıkSayı fark = sayi1.Çıkar(sayi2);

        Console.WriteLine("Sayı 1: " + sayi1); // 3 + 4i
        Console.WriteLine("Sayı 2: " + sayi2); // 1 + 2i
        Console.WriteLine("Toplam: " + toplam); // 4 + 6i
        Console.WriteLine("Fark: " + fark); // 2 + 2i
    }
}
