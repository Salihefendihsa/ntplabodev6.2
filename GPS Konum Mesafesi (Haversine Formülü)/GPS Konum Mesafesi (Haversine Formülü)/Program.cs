using System;

struct GPSKonum
{
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }

    public GPSKonum(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    // İki GPS konumu arasındaki mesafeyi kilometre olarak hesaplayan metot
    public double Mesafe(GPSKonum other)
    {
        const double R = 6371; // Dünya yarıçapı (kilometre cinsinden)

        double lat1Rad = ToRadians(Latitude);
        double lon1Rad = ToRadians(Longitude);
        double lat2Rad = ToRadians(other.Latitude);
        double lon2Rad = ToRadians(other.Longitude);

        double deltaLat = lat2Rad - lat1Rad;
        double deltaLon = lon2Rad - lon1Rad;

        double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                   Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                   Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return R * c; // Mesafe (kilometre cinsinden)
    }

    // Dereceyi radyana çeviren yardımcı metot
    private static double ToRadians(double derece)
    {
        return derece * Math.PI / 180;
    }

    public override string ToString()
    {
        return $"Latitude: {Latitude}, Longitude: {Longitude}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        GPSKonum konum1 = new GPSKonum(41.0082, 28.9784); // İstanbul
        GPSKonum konum2 = new GPSKonum(39.9208, 32.8541); // Ankara

        Console.WriteLine("Konum 1: " + konum1); // İstanbul koordinatları
        Console.WriteLine("Konum 2: " + konum2); // Ankara koordinatları
        Console.WriteLine("Mesafe (km): " + konum1.Mesafe(konum2)); // 350-450 km arası
    }
}
