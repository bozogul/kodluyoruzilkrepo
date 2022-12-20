public class Canlilar
{
    public void Beslenme(){
        Console.WriteLine("Canlılar Beslenir");
    }
    public void Solunum(){
        Console.WriteLine("Canlılar Solunum Yapar"); 
    }
    public void Boşaltım(){
        Console.WriteLine("Canlılar Boşaltım Yapar"); 
    }
    public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
}
