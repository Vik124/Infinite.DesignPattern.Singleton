using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.DesignPattern.Factory
{
  
             public class ExecuteClass
        {
            static void Main(string[] args)
            {
                IFactory factory = null;
                Console.WriteLine("Enter the Vehicle type to drive :");
                string type = Console.ReadLine();
                ConcreteVehicleFactory concreteVehicle = new ConcreteVehicleFactory();
                factory = concreteVehicle.GetVehicleDetails(type);
                factory.Drive();
            }
        }
    }
  