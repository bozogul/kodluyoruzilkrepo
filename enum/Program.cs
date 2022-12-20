internal class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine(Gunler.Pazar); 
       Console.WriteLine((int)Gunler.Cumartesi);
       Console.WriteLine(Gunler.Cumartesi);
       int sicaklik = 23 ;
       if (sicaklik <= (int)HavaDurumu.Normal)
        Console.WriteLine("Dışarı çıkmak için havanın biraz daha ısınmasını bekleyelim");
       else if (sicaklik>= (int)HavaDurumu.Sıcak)
         Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
       else if (sicaklik>= (int)HavaDurumu.Normal && sicaklik<= (int)HavaDurumu.Sıcak)
        Console.Write("Hadi Dışarı Çıkalım");
       
        
       
}
}
enum Gunler{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar,
}
enum HavaDurumu{
        Soguk  = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30,
}