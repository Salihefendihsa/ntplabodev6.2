using System;

enum CalisanRol
{
    Manager,
    Developer,
    Designer,
    Tester
}

class MaasHesaplama
{
    public static decimal Hesapla(CalisanRol rol)
    {
        switch (rol)
        {
            case CalisanRol.Manager:
                return 15000; // Yönetici maaşı
            case CalisanRol.Developer:
                return 12000; // Yazılım geliştirici maaşı
            case CalisanRol.Designer:
                return 10000; // Tasarımcı maaşı
            case CalisanRol.Tester:
                return 8000; // Test uzmanı maaşı
            default:
                return 0; // Geçersiz rol
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalisanRol rol = CalisanRol.Developer;

        Console.WriteLine("Çalışan rolü: " + rol);
        Console.WriteLine("Maaş: " + MaasHesaplama.Hesapla(rol) + " TL"); // 12000 TL

        rol = CalisanRol.Manager;
        Console.WriteLine("Çalışan rolü: " + rol);
        Console.WriteLine("Maaş: " + MaasHesaplama.Hesapla(rol) + " TL"); // 15000 TL
    }
}
