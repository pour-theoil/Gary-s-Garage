using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
       

        public void ChargeBattery()
        {
            // method definition omitted
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