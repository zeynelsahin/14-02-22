// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Abstract classlarda statik metodlar tanımlayabiliyoruz
A.Methodd();


B b = new B();
b.Id = 1;
b.FullName = "Mustafa";
b.Adress = "İstanbul";

b.List();

abstract class A
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public string Adress { get; set; }

    public static void Methodd()
    {
        Console.Write("Newlenmeden çalışabilen method");
    }
    public abstract void List();
}

class B:A
{
    public override void List()
    {
        Console.WriteLine($"{Id} - {FullName} - {Adress}");
    }
}
