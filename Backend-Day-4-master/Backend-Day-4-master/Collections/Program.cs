using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //// stack         // heap
        //string[] names = new string[] { "ali", "veli", "ayse ", "mehmet" };
        //console.writeline(names[0]);
        //console.writeline(names[1]);
        //console.writeline(names[2]);
        //console.writeline(names[3]);

        //new dedigin anda bellekte yeni bir adres olusur 5 elemanlı; bu yüzden sadece 4 ü tanımladıysan kalanlar boş kalır
        //names = new string[5];
        //names[4] = "zeynep";
        //console.writeline(names[4]);
        //console.WriteLine(names[0]);

        
        List<String> names2 = new List<String> {"Ali", "Veli", "Ayse ", "Mehmet"};
        Console.WriteLine(names2[0]);
        Console.WriteLine(names2[1]);
        Console.WriteLine(names2[2]);
        Console.WriteLine(names2[3]);
        names2.Add("Abuzer");
        Console.WriteLine(names2[0]);
        Console.WriteLine(names2[4]);

    }
}