using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Motorcycle : IVehicle, ICompany
    {
        public bool HasSaddleBags { get; set; }
        public int WheelCount { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int MirrorCount { get; set; }
        public string Make { get; set; }
        public string CoName { get; set; }
        public string Logo { get; set; }
    }
}
