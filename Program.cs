internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hoşgeldiniz");
        Console.WriteLine("Lütfen Adınızı Giriniz:");
        string ad = Console.ReadLine();
        Console.WriteLine("Lütfen Soy Adınızı Giriniz:");
        string soy_ad = Console.ReadLine();
        Console.WriteLine("Sisteme Giriş yapıldı " +  ad + " " + soy_ad );
}
}