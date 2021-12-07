using System;

namespace Task_2.Models
{
    public class Envelope
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Envelope(double sideA, double sideB)
        {
            SideA = Math.Min(sideA, sideB);
            SideB = Math.Max(sideA, sideB);
        }
    }
}
