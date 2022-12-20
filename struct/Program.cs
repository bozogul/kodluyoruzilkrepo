internal class Program
{
    private static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.kisaKenar=10;
        dikdortgen.uzunKenar=20;
        Console.WriteLine("Dikdörtgenin Alanı : {0}",dikdortgen.alanHesapla());

        DikdortgenStruct diktörtgen_struct = new DikdortgenStruct();
        diktörtgen_struct.kisaKenar = 15;
        diktörtgen_struct.uzunKenar = 30;
        Console.WriteLine("Dikdörtgenin Alanı  {0}", diktörtgen_struct.alanHesapla());
    }
}
class Dikdortgen{
    public int kisaKenar;
    public int uzunKenar;
    public long alanHesapla(){
        return this.kisaKenar*this.uzunKenar;        
    }
}
struct DikdortgenStruct{
    public int kisaKenar;
    public int uzunKenar;
    public long alanHesapla(){
        return this.kisaKenar*this.uzunKenar;
    }
}