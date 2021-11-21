using System;

namespace Task_2.Models
{
    class Envelope : IComparable<Envelope>
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public Envelope(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public int CompareTo(Envelope thatEnvelope)
        {
            if ((this.SideA > thatEnvelope.SideA && this.SideB > thatEnvelope.SideB) ||
                (this.SideA > thatEnvelope.SideB && this.SideB > thatEnvelope.SideA))
            {
                return 1;
            } 
            return 0;
        }
    }
}
