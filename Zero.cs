using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
       
        int CurrentChargePercentage {get; set; } = 0;

         public string GetCurrentChargePercentage()
        {
            return ($"Zero battery is {CurrentChargePercentage}% charged");
        }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero roles. MMMMMmmmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero leans into the turn hard");
        }
    }
}