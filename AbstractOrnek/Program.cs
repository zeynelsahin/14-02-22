// See https://aka.ms/new-console-template for more information



Muzisyen muzisyen1 = new Muzisyen();

muzisyen1.Ad = "Zeynel";
muzisyen1.Soyad = "Şahin";
muzisyen1.Calinanlar=new MuzikAletleri[]{new Flüt(){Adi = "Flüt",Marka = "blalala"},new Keman(){Adi = "Keman",Marka = "Deneme"}};

foreach (var muzik in muzisyen1.Calinanlar)
{
    Console.WriteLine("Müzik Aletinin Adı: "+muzik.Adi);
    Console.WriteLine("Müzik Aletinin Markası"+muzik.Marka);
    muzik.Cal();
}


class Muzisyen
{
    public string Ad { get; set; }

    public string Soyad { get; set; }
    public MuzikAletleri[] Calinanlar { get; set; }
}


abstract class MuzikAletleri
{
    public string Adi { get; set; }
    public string Marka { get; set; }
    public abstract void Cal();
}
class Flüt:MuzikAletleri
{
    public override void Cal()
    {
        Console.WriteLine("Flüt Çalınacak");
    }
}

class Keman : MuzikAletleri
{
    public override void Cal()
    {
        Console.WriteLine("Keman Çalınacak");
    }
}
class Gitar : MuzikAletleri
{
    public override void Cal()
    {
        Console.WriteLine("Gitar Çalınacak");
    }
}