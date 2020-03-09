using System;

namespace inheritanceIntro
{
  public class Zero : Vehicle
  {  // Electric motorcycle
    public double BatteryKWh { get; set; }
    public override void Drive()
    {
      Console.WriteLine($"ZOOM ZOOM goes the {MainColor} {Name}");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {Name} is {direction}");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {Name} stopped on the highway");
    }

    public void ChargeBattery() { }
  }
}