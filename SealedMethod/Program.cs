// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


A a = new A();
a.MyMethod();

B b = new B();
b.MyMethod();

C c = new C();
c.MyMethod();
class A
{

    public string Name { get; set; }

    public virtual void MyMethod()
    {
        Console.WriteLine("Class A daki Virtual olan method");
    }
}

class B:A
{
    public  override void MyMethod()
    {
        Console.WriteLine("Class B deki virtual olan method");
    }
}
class C : B
{
    public override void MyMethod()
    {
        Console.WriteLine("Class C deki virtual olan method");
    }
    
}

