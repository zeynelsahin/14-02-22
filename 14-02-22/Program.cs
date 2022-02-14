// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Musteri musteri = new Musteri()
{
 Isim   = "Zeynel",Adress = "BILA bıla bıla",ToplamAlisverisTutari = 500
};


class Kisi
{
    public string Isim { get; set; }
    public string Adress { get; set; }
    
}
class Musteri:Kisi
{
    public decimal ToplamAlisverisTutari { get; set; }
}

class Calisan:Kisi
{
    public decimal Maas { get; set; }

}
