using System;

namespace inheritanceIntro
{
  public class Cessna : Vehicle
  {  // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public override void Drive()
    {
      Console.WriteLine($"ZIP ZIP goes the {MainColor} {Name}");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {Name} is {direction}");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {Name} stopped on the runway");
    }

    public void RefuelTank() { }
  }
}