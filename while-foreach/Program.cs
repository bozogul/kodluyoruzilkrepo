internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı giriniz.");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <= sayi )
        {
            toplam+=sayac;
            sayac ++;
        }
        Console.WriteLine("Ortalama: "+ toplam/sayi);

// A'dan Z'ye kadar tüm harfleri ekrana yazdırma
        char character = 'a';
        while (character< 'z')
        {
            Console.WriteLine(character);
            character++;
        }

//Foreach döngüsü
        string[] araba = {"volkswagen","mercedes","togg"};
        foreach (var item in araba)
        {
            Console.WriteLine(araba);
        }
    }
}