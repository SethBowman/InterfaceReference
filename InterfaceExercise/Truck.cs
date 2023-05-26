using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int TruckBedSpace { get; set; }
        public int WheelCount { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int MirrorCount { get; set; }
        public string Make { get; set; }
        public string CoName { get; set; }
        public string Logo { get; set; }
    }
}
