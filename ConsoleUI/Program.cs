using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            var vehicles = new List<Vehicle>();

            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2000",
                Make = "Honda",
                Model = "Accord"

            
            };

            var motorcycle1 = new Motorcycle() 
            {
                HasSideCart = true,
                Year = "2001",
                Make = "Kawasaki",
                Model = "Ninja",

            };
            Vehicle vehicle1 = new Car() 
            {
                
                Year = "2020",
                Make = "Tesla",
                Model = "X",

            };
            Vehicle vehicle2 = new Motorcycle() 
            { 
                
               Year = "2010",
               Make = "Suzuki",
               Model = "GXR200",
            };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year:{vehicle.Year}");
                Console.WriteLine($"Make:{vehicle.Make}");
                Console.WriteLine($"Model:{vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

        }
    }
}
