class Base
{
    public virtual void virtualFunc()
    {
    }
}

class Child : Base
{
    public override void virtualFunc()
    {
        Console.WriteLine($"{this}");
    }
}

class Child2 : Child
{
    public override void virtualFunc()
    {
        Console.WriteLine($"{this}");
    }
}

class Program3
{
    /*
    static void Main()
    {
        Base b = new Base();

        Child c = new Child();
        Child2 c2 = new Child2();

        b = c2;
        b.virtualFunc();
    }
    */
}
