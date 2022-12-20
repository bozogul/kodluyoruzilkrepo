using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ArrayList list = new ArrayList();
        list.Add("Ayşe");
        list.Add(2);
        list.Add(true);
        list.Add('a');

        //içerisinde verilere erişim
        Console.WriteLine(list[1]);

        foreach (var item in list)
        {
            Console.WriteLine(item.GetType());            
        }
        //Adrange
        string[] renkler = {"kırmızı","sarı","yeşil"};
        List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
        list.AddRange(renkler);
        list.AddRange(sayılar);
    }   
}