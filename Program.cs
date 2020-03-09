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
      myBike.Name = "Zero";

      var myTesla = new Tesla();
      myTesla.MainColor = "Midnight Silver";
      myTesla.MaxOccupancy = 6;
      myTesla.Name = "Tesla";

      var myRam = new Ram();
      myRam.MainColor = "blue";
      myRam.Name = "Ram";
      myRam.MaxOccupancy = 5;

      var myCessna = new Cessna();
      myCessna.MainColor = "green";
      myCessna.Name = "Cessna";
      myCessna.MaxOccupancy = 10;

      myBike.Drive();
      myTesla.Drive();
      myCessna.Drive();
      myRam.Drive();

      myBike.Turn("taking a left");
      myBike.Stop();

      myTesla.Turn("taking a right");
      myTesla.Stop();

      myRam.Turn("taking several wrong turns");
      myRam.Stop();

      myCessna.Turn("doing loops!");
      myCessna.Stop();




    }
  }
}
