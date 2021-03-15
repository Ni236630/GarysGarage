using System;

namespace GarysGarage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
    
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
           public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.Model} passes overhead at an altitude too high to hear the roaring of the engines.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.Model}, after a slightly bumpy touch down, coasts to a stop near the ennd of the runway. signling the end or beginnig of a new adventuer for its passengers.");
        }
    }
}