using System.Collections.Generic;
using System;

namespace Infinite.DesignPattern.Factory
{
    //Product
    public interface IFactory
    {
        void Drive();
    }

    //Concrete Product
    public class Bike : IFactory
    {
        public void Drive()
        {
            Console.WriteLine("Driving Bike");
        }
    }

    public class Scooter : IFactory
    {
        public void Drive()
        {
            Console.WriteLine("Driving Scooter");
        }
    }

    //Factory - Creator
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicleDetails(string vehicleType);
    }

    //Concrete class
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicleDetails(string vehicleType)
        {
            if (vehicleType == "bike")
            {
                return new Bike();
            }
            else if (vehicleType == "scooter")
            {
                return new Scooter();
            }
            else
            {
                throw new ApplicationException("Vehicle type doesn't exists");
            }
        }
    }
    public class ExecuteClass1
    {
        static void Main1(string[] args)
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
