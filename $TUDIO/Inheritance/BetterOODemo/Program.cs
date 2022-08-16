using System;
using System.Collections.Generic;

namespace BetterOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRenter = "Truck Renter" });
            rentals.Add(new Sailboat() { CurrentRenter = "Sailboat Renter" });
            rentals.Add(new Car() { CurrentRenter = "Car Renter" });

            foreach (var r in rentals)
            {
                if (r is Truck t)
                {
                    
                }

            }
        }
    }
}
