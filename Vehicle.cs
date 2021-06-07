using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

           public virtual void Drive()
        {
            Console.WriteLine($"The Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine($"The vehicle turns right");
        
        }

         public virtual void Stop()
        {
            Console.WriteLine($"The vehicle comes to a nice stop");
        
        }
    }
}