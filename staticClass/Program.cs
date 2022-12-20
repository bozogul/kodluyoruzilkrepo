internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ayşe","Yılmaz","İnsan Kaynakları");
        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
    }
}

class Calisan{
    private static int calisanSayisi;
    public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }
    private string Isim;
    private string Soyisim;
    private string Depertman;

    static Calisan(){
        calisanSayisi = 0 ;

    }
    public Calisan(string ısim, string soyisim, string depertman)
    {
        this.Isim = ısim;
        this.Soyisim = soyisim;
        this.Depertman = depertman;
        calisanSayisi++;
    }


}