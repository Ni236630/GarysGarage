using System;

namespace GarysGarage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage {get; set;}
       
       
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.Model} Silently whirls by you like a jet before a sonic boom!");
        }
    }
}