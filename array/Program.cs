internal class Program
{
    private static void Main(string[] args)
    {
        // Dizi tanımlama
        string[] renkler = new string[5];
        string[] hayvanlar = {"Kedi","Köpek","Kuş","Anaconda"};
        int[] dizi;
        dizi = new int[5];

        //Dizilere Değer Atama ve Erişim
        renkler[0]= "Bordo";
        Console.WriteLine(hayvanlar[1]);
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);
        Console.WriteLine(dizi);

        //Döngülerle Dizi Kullanımı
        Console.WriteLine("Lütfen dizinin eleman sayısını giriniz :" );
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];
        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayıyı giriniz" ,i++);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }
        Console.Write("Ortalama"+ toplam/diziUzunlugu);
    }
}