using System;

namespace GarysGarage
{
    public class Vehicle
    {   
        public string Model { get ; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

     public virtual void Drive(){
        Console.WriteLine("vroom");
     }
     public virtual void Turn(){
         Console.WriteLine("The vehicle carfully turns right");
     }
     public virtual void Stop(){
         Console.WriteLine("The vehcle stops at after an appropriate distance of braking.");
     }
    }
}