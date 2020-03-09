using System;

namespace inheritanceIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      var myBike = new Zero();
      //I can still reference the inherited class
      myBike.MainColor = "Black";
      myBike.MaxOccupancy = 2;

      var myTesla = new Tesla();
      myTesla.MainColor = "Midnight Silver";
      myTesla.MaxOccupancy = 6;

      var myRam = new Ram();
      var myCessna = new Cessna();

      myBike.Drive();
      myTesla.Drive();
      myCessna.Drive();
      myRam.Drive();

      Console.WriteLine(myTesla);
    }
  }
}
