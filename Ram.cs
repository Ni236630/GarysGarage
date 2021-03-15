using System; 
namespace GarysGarage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
           CurrentTankPercentage = 100; 
        }
           public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} {this.Model} Roars past you as smoke billows from its aftermarket exhaust system.");
        }
        public override void Turn()
        {
            Console.WriteLine($"the {this.Model} ripes around the corner with a heavy growl spewing thick clouds of toxic fumes out the back of it.");
        }
    }
}