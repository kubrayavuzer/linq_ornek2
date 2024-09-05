using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> isimler = new List<string>
        {
            "Ayşe", "Fatma", "Ali", "Kadriye", "Kemalettin", "Seda", "Hayriye", "Su", "Hava", "Toprak"
        };

        //ismi beş harften kısa olanlar
        var kisaIsimler = isimler.Where(isim => isim.Length < 5).ToList();
        Console.WriteLine("İsmi 5 harften kısa olanlar:");
        kisaIsimler.ForEach(Console.WriteLine);

        //ismi yedi harften uzun olanlar 
        var uzunIsimler = isimler.Where(isim => isim.Length > 7).ToList();
        Console.WriteLine("İSmi 7 harften uzun olanlar:");
        uzunIsimler.ForEach(Console.WriteLine);

        //isminde a haerfi bulunanlar
        var aHarfiOlanlar = isimler.Where(isim => isim.Contains('a')).ToList();
        Console.WriteLine("İsminde a harfi bulunanlar:");
        aHarfiOlanlar.ForEach(Console.WriteLine);

        //isminde e harfi bulunanlar
        var eHarfiOlanlar = isimler.Where(isim => isim.Contains('e')).ToList();
        Console.WriteLine("İsminde e harfi olanlar:");
        eHarfiOlanlar.ForEach (Console.WriteLine);

        //ismi A harfi ile başlayanlar
        var aIleBaslayanlar = isimler.Where(isim => isim.StartsWith("A")).ToList();
        Console.WriteLine("İsmi A harfi ile başlayanlar:");
        aIleBaslayanlar.ForEach(Console.WriteLine);

        //isimlerin ters hali
        var tersIsımler = isimler.Select(isim => new string (isim.Reverse().ToArray())).ToList();
        Console.WriteLine("İsimlerin tersten yazılışı");
        tersIsımler.ForEach(Console.WriteLine);


    }
}
