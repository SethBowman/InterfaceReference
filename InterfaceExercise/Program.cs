using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV



            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var sedan = new Car();
            sedan.Make = "Toyota";
            sedan.TrunkSpace = 4;
            sedan.MirrorCount = 2;
            sedan.WheelCount = 4;
            sedan.HasSteeringWheel = true;
            sedan.Logo = "H";

            var f150 = new Truck();
            f150.TruckBedSpace = 8;
            f150.Make = "Ford";
            f150.MirrorCount = 2;
            f150.WheelCount = 4;

            var harley = new Motorcycle();
            harley.HasSaddleBags = true;
            harley.Make = "Harley";
            harley.MirrorCount = 2;
            harley.WheelCount = 2;



            var carLot = new List<IVehicle>();
            carLot.Add(sedan);
            carLot.Add(f150);
            carLot.Add(harley);


            foreach (var car in carLot)
            {
                if(car.GetType() == typeof(Car))
                {
                    Console.WriteLine($"This is a {car.Make}. It has {car.MirrorCount} mirrors, and it has {car.WheelCount} wheels. It has a trunk space of {sedan.TrunkSpace}.");
                }
                else if(car.GetType() == typeof(Truck))
                {
                    Console.WriteLine($"This is a {car.Make}. It has {car.MirrorCount} mirrors, and it has {car.WheelCount} wheels. It has a truck bed space of {f150.TruckBedSpace}.");
                }
                else if(car.GetType() == typeof(Motorcycle))
                {
                    Console.WriteLine($"This is a {car.Make}. It has {car.MirrorCount} mirrors, and it has {car.WheelCount} wheels. It is {harley.HasSaddleBags} that it has saddle bags.");
                }
                else
                {
                    Console.WriteLine($"This is a {car.Make}. It has {car.MirrorCount} mirros, and it has {car.WheelCount} wheels.");
                }
            }



        }
    }
}
