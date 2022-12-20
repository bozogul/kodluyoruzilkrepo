internal class Program
{
    private static void Main(string[] args)
    {
        
        Calisanlar calisan1 = new Calisanlar();
        calisan1.Ad="Batuhan";
        calisan1.Soyad="Özoğul";
        calisan1.No=10;
        calisan1.Departman="IT";
        calisan1.calisanBilgileri();
        
}
}
class Calisanlar
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void calisanBilgileri()
    {
    Console.WriteLine("Calisan Adı:{0}" ,Ad);
    Console.WriteLine("Calisan SoyAdı:{0}" ,Soyad);
     Console.WriteLine("Calisan No:{0}" ,No);
      Console.WriteLine("Calisan Departman:{0}" ,Departman);
    }
}