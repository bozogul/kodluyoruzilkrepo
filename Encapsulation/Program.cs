class Program
{
     static void Main(string[] args)
    {
        Ogrenci ogrenci= new Ogrenci();
        ogrenci.Isim ="Ayşe ";
        ogrenci.SoyIsim="Yılmaz";
        ogrenci.OgrenciNo=151515151;
        ogrenci.Sinif=4;
        ogrenci.OgrenciBilgileriniGetir();
}
}
class Ogrenciler {

    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim {get => isim; set => isim = value ;}
    public string SoyIsim{get => soyisim; set=>soyisim = value;}
    public int OgrenciNo{get => ogrenciNo; set => ogrenciNo = value;}
    public int Sinif{get=> sinif;set=>sinif = value;}

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif){
        Isim=isim;
        SoyIsim=soyisim;
        OgrenciNo=ogrenciNo;
        Sinif=sinif;
    }
    public void OgrenciBilgileriniGetir(){
        Console.WriteLine("Öğrenci Adi              :{0}",this.Isim);
        Console.WriteLine("Öğrenci Soyadı              :{0}",this.SoyIsim);
        Console.WriteLine("Öğrenci Numarası              :{0}",this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıfı              :{0}",this.Sinif);

    }    
    

}