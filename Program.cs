internal class Program
{
    public static void Main(string[] args)
    {
        // Soz dizimi
        //  class sinifAdi
        //  {
        //     [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
        //     [Erisim Belirleyici] [Geri Donus Tipi] MetotAdi(Parametre Listesi)
        //     {
        //         //Metot Komutlari
        //     }
        //  }

        //  Erisim Belirleyiciler
        //  *public
        //  *private
        //  *internal
        //  *protected

        Console.WriteLine("Calisan 1");
        Calisan calisan1= new Calisan("Nazli","Kara",2145697830,"Satis");
        calisan1.CalisanBilgileri();

        Console.WriteLine(" ");

        Console.WriteLine("Calisan 2");
        Calisan calisan2= new Calisan();
        calisan2.Ad="Mahmut";
        calisan2.Soyad="Yildirim";
        calisan2.No=2145697831;
        calisan2.Departman="Insan kaynaklari";
        calisan2.CalisanBilgileri();

        Console.WriteLine(" ");

        Console.WriteLine("Calisan 3");
        Calisan calisan3= new Calisan("Aysegul","Eski");
        calisan3.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(){}

    public Calisan(string ad, string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;   
    }

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi:{0}",Ad);
        Console.WriteLine("Calisan Soyadi:{0}",Soyad);
        Console.WriteLine("Calisan Numarasi:{0}",No);
        Console.WriteLine("Calisan Departmani:{0}",Departman);
    }
}