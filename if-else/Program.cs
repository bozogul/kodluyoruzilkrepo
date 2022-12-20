internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if (time>=6 && time<=10){
            Console.WriteLine("Günaydın");
        }
        else if( time>=10 &&  time <= 18 ){
            Console.WriteLine("İyi Günler");
        }
        else{
            Console.WriteLine("İyi Geceler");
        }
        string sonuc = time <=18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);
        sonuc = time>=6 && time<=10 ? "Günaydın " : time>=10 &&  time <= 18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);
    }
}