using System;
class Program
{
    static void Main(string[] args)
    {
        Transport auto = new Transport(new EarthMove());
        auto.Move();
        auto.Movable = new WaterMove();
        auto.Move();

        Console.ReadLine();
    }
}
interface IMovable
{
    void Move();
}

class EarthMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение по земле");
    }
}

class WaterMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение по воде");
    }
}
class Transport
{

    public Transport(IMovable mov)
    {
        Movable = mov;
    }
    public IMovable Movable { private get; set; }
    public void Move()
    {
        Movable.Move();
    }
}