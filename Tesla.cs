using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        int CurrentChargePercentage {get; set; } = 0;

        public string GetCurrentChargePercentage()
        {
            return ($"Tesla battery is {CurrentChargePercentage}% charged");
        }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla smugs by your.  Sound Copywrited!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla slams on its brakes in an autopilot fail");
        }
    }
}