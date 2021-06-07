using System;

namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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