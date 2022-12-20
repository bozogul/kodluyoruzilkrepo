internal class Program
{
    private static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hoşgeldiniz";
        string degisken2 = "Dersimiz CSharp";
        // Lenght cümlede kaç karakter olduğunu gösterir
        Console.Write(degisken.Length);
        //ToUpper ToLower 
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());
        //Concat
        Console.WriteLine(String.Concat(degisken,"Merhaba"));
        //Compare CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken,degisken2,true));
        //Contains
        Console.WriteLine(degisken.Contains(degisken2));
        //EndsWith
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
        //StartsWith
        Console.WriteLine(degisken.StartsWith("Dersimiz"));
        //IndexOf
        Console.WriteLine(degisken.IndexOf("CS"));
        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba"));
        //PadLeft, PadRight
        Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
        //Remove 
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        //Replace
        Console.WriteLine(degisken.Replace("Csharp","C#"));
        //Split 
        Console.WriteLine(degisken.Split(' ')[1]);
        //Substring
        Console.WriteLine(degisken.Substring(4));
    }
}