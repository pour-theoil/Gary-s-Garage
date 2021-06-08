using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

            int CurrentTankPercentage { get; set; } = 0;

        public string GetCurrentTankPercentage()
        {
            return ($"Cessna tank is {CurrentTankPercentage}% full");
        }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies over you.  Wooooshhhh!");
        }
    }
}