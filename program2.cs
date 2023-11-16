class Destructor
{
    public Destructor()
    {
        Console.WriteLine("Constructor Object Created");
    }
    ~Destructor()
    {
        string type = GetType().Name;
        Console.WriteLine($"Object {type} is Destroyed");
    }
}

class Vehicle // Base class
{
    public int maxVelocity = 0;
    private int wheels = 0;
    public bool isTurned;

    public Vehicle(int wheels)
    {
        this.wheels = wheels;
    }

    public void turnOn()
    {
        isTurned = true;
    }

    public void turnOff()
    {
        isTurned = false;
    }

    public void status()
    {
        Console.WriteLine($"MaxVel: {maxVelocity}\nWheels: {getWheels()}\nTurned: {isTurned}");
    }

    public int getWheels()
    {
        return this.wheels;
    }

    public void setWheels(int value)
    {
        if (value < 0)
        {
            this.wheels = 0;
        }
        else if (value > 25)
        {
            this.wheels = 25;
        }
        else
        {
            this.wheels = value;
        }
    }

}

class Car : Vehicle
{
    string name = "", color = "";

    public Car(string name, string color) : base(0)
    {
        maxVelocity = 120;
        this.name = name;
        this.color = color;
        turnOff();
    }
}

class CombatCar : Car
{
    public int ammo = 0;
    public CombatCar() : base("Combat Car", "Green")
    {
        setWheels(6);
        ammo = 100;
    }
}

class Program2
{
    /*
    static void Main()
    {
        Car c1 = new Car("Fast", "Red");
        c1.turnOn();
        c1.status();

        CombatCar cc1 = new CombatCar();
    }
    */
}
