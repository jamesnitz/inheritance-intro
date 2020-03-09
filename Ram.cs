using System;

namespace inheritanceIntro
{
  public class Ram : Vehicle
  {  // Gas powered truck
    public double FuelCapacity { get; set; }

    public override void Drive()
    {
      Console.WriteLine($"RRRRUM RRRRRRUM goes the {MainColor} {Name}");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {Name} is {direction}");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {Name} stopped in the woods");
    }
    public void RefuelTank() { }
  }
}