public class Bitkiler:Canlilar
{
 public void Fotosentez(){
    Console.WriteLine("Bitkiler Fotosentez Yapar");
 }
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Bitkiler güneşe Tepki verir.");
    }
}
public class TohumluBitkiler:Bitkiler{
    public TohumluBitkiler(){
        base.UyaranlaraTepki();
    }
    public void TohumlaCogalma(){
        Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır");
    }
}
public class TohumsuzBitkiler:Bitkiler{
    public void SporlaCogalma(){
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}

