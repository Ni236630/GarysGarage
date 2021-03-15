using System;

namespace GarysGarage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }
  
        public void ChargeBattery()
        {   
            CurrentChargePercentage = 100;
        }
        
           public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.Model} Silently whizzes by you like a rocket. you shake your fist at it like an old man angry at the world!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {this.Model} never turns...");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.Model} drives into the sunset...never to be seen again");
        }

    }
}