using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }



        int CurrentTankPercentage { get; set; } = 0;

        public string GetCurrentTankPercentage()
        {
            return ($"Ram tank is {CurrentTankPercentage}% full");
        }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you.  RRrrrrrummbbble!");
        }
    }
}