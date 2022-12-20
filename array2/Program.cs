internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] sayiDizisi = { 23, 12, 10, 7, 90, 72, 3, 11, 17 };
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
        Array.Sort(sayiDizisi);
        Console.WriteLine("Sıralı Dizi");
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }

        //Clear
        Console.WriteLine("Array Clear");
        Array.Clear(sayiDizisi,2,2);
           foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
        //Reverse
        Console.WriteLine("Array Reverse");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
        //İndexOF
        Console.WriteLine("İndexOf");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));
         //Resize
        Console.WriteLine("Array Resize");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8]=99;
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
    }
}