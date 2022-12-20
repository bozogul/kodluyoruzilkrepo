internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(10);
        sayiListesi.Add(23);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);
        

        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);    
        }

        foreach (var renk in renkListesi)
        {
            Console.WriteLine(renk);
        }
        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        sayiListesi.ForEach(renk=> Console.WriteLine(renk));

        sayiListesi.Remove(4);
        renkListesi.Remove("yeşil");
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        if (sayiListesi.Contains(10))
        {
            Console.WriteLine("10 Liste içerisinde bulundu");
        }

        Console.WriteLine(renkListesi.BinarySearch("sarı"));

        //Diziyi Listeye çevirme
        string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

        List<string> hayvanListesi = new List<string>(hayvanlar);
        hayvanListesi.Clear();
        
    }
}