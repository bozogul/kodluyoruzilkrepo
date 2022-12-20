internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Bir sayı Giriniz");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i < sayac; i++)
        {
            if (i%2==1)
            {
                Console.WriteLine(i);
            }
        }

        int tektoplam=0;
        int cifttoplam=0;
        for (int i = 1; i < 1000; i++)
        {
            if (i%2==1)
            {
                tektoplam +=i;
            }
            else{
                cifttoplam += i;
            }
        }
        Console.WriteLine("Tek Toplam:"+tektoplam);
        Console.WriteLine("Çift Toplam:"+cifttoplam);


        for (int i = 1; i < 10; i++)
        {
            if (i==4)
            {
                break;
            }
            Console.WriteLine(i);
        }

        for (int i = 1; i < 10; i++)
        {
            if (i==4)
            {
            continue;    
            }
            Console.WriteLine(i); 
        }
       
    }
}