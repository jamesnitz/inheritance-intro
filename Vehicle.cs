using System;

namespace inheritanceIntro
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string Name { get; set; }
    public int MaxOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("VA-VA-VROOM!");
    }

    public virtual void Turn(string direction)
    {
      Console.WriteLine($"Vin Diesel drives past you!");
    }
    public virtual void Stop()
    {
      Console.WriteLine($"Vin Diesel stops up and mean mugs");
    }
  }
}