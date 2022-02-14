// See https://aka.ms/new-console-template for more information

Kedi kedi = new Kedi();
kedi.Besle();
kedi.AsiYap();

Hayvan hayvan = new Hayvan();
hayvan.Besle();
hayvan.AsiYap();

Hayvan tekir = new Kedi();
tekir.Besle();
tekir.AsiYap();
abstract class Hayvan
{
    public virtual void Besle()
    {
        Console.WriteLine("Hayvan Beslendi");
    }

    public virtual void AsiYap()
    {
        Console.WriteLine("Aşı yapıldı");
    }

    public abstract void Ses();
}

class Kedi:Hayvan
{
    public override void AsiYap()
    {
        Console.WriteLine("Kediye aşı yapıldı");
    }

    public override void Ses()
    {
        Console.WriteLine("Kedi Sesi");
    }

    public override void Besle()
    {
        base.Besle();
    }
}

class Kopek:Hayvan
{
    public override void Ses()
    {
        Console.WriteLine("Kopek Sesi");
    }
}
