using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram d2500 = new Ram();

            d2500.MainColor = "silver";
            fxs.MainColor = "yellow";
            modelS.MainColor = "black";
            mx410.MainColor = "white";

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine("");


            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine("");

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine("");

            d2500.Drive();
            d2500.Turn();
            d2500.Stop();
            Console.WriteLine("");
        }
    }
}
