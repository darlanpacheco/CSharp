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
  public int maxVelocity, wheels;
  public bool isTurned;

  public void turnOn()
  {
    isTurned = true;
  }

  public void turnOff()
  {
    isTurned = false;
  }
}

class Car : Vehicle
{
  string name = "", color = "";

  public Car(string name, string color)
  {
    wheels = 4;
    maxVelocity = 120;
    this.name = name;
    this.color = color;
    turnOff();
  }
}

class Program2
{
  static void Main()
  {
    Car c1 = new Car("Fast", "Red");
  }
}
