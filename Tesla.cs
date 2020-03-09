using System;

namespace inheritanceIntro
{
  public class Tesla : Vehicle
  {  // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
      Console.WriteLine($"Rumble Rumble goes the {MainColor} {Name}");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {Name} is {direction}");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {Name} stopped its battery");
    }
    public override string ToString()
    {
      return "DIS MY TESLA";
    }
  }
}