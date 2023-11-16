class Car2
{
    private int velMax;

    public Car2()
    {
        this.velMax = velMaxGetSet;
    }

    public void setVelMax(int value)
    {
        this.velMax = value;
    }

    public int velMaxGetSet
    {
        get { return this.velMax; }
        set
        {
            if (value > 300)
            {
                this.velMax = 300;
            }
            else if (value < 0)
            {
                this.velMax = 0;
            }
            else
            {
                this.velMax = value;
            }
        }
    }
}

class Program4
{
    static void Main()
    {
        Car2 c = new Car2();

        c.velMaxGetSet = 350;
        Console.WriteLine($"[Velocity: {c.velMaxGetSet}]");
    }
}
