internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        int y = 7;
        y = y + 2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 3;
        x *= 2;
        Console.WriteLine(x);

        bool isSucces = true;
        bool isCompleted = false;

        if(isSucces&& isCompleted)
            Console.WriteLine("Perfect!");
        if(isSucces || isCompleted)
            Console.WriteLine("Great!");
        if(isSucces && isCompleted)
            Console.WriteLine("Fine!");
        

        int a = 3;
        int b = 4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);
        
        int sayi1=10;
        int sayi2=20;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 ++;
        Console.WriteLine(sonuc1);

        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);
    }
}