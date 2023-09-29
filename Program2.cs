class DestructorDemo
{
    public DestructorDemo()
    {
        Console.WriteLine("Constructor Object Created");
    }
    ~DestructorDemo()
    {
        string type = GetType().Name;
        Console.WriteLine($"Object {type} is Destroyed");
    }
}

class Program2
{
    static void Main()
    {
        DestructorDemo obj1 = new DestructorDemo();
        DestructorDemo obj2 = new DestructorDemo();
    }
}
