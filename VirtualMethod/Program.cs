
Customer customer = new Customer();
customer.Eat();
Worker worker = new Worker();
worker.Eat();

class Person
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Adress { get; set; }

    public virtual void Eat()
    {
        Console.WriteLine("Yemek ye..");
    }
}

class Customer:Person
{
    public double TotalAmount { get; set; }

    public override void Eat()
    {
        Console.WriteLine("Customer yemek ye");
    }
}

class Worker:Person
{
    public double Salary { get; set; }   
}


class MyClass
{
    
}