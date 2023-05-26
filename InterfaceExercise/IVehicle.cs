using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {


        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

        public int WheelCount { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int MirrorCount { get; set; }
        public string Make { get; set; }

    }
}
