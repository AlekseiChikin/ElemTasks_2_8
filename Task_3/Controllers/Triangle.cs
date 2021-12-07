using System;
using System.Collections.Generic;

namespace Task_3
{
    public partial class Triangle : IComparable<Triangle>, IComparer<Triangle>
    {
        public string Name { get; init; }
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public double Area { get; init; }
        protected Triangle(string name, double a , double b , double c)
        {
            Name = name;
            SideA = a;
            SideB = b;
            SideC = c;
            Area = AreaOfATriangle();
        }
        private double AreaOfATriangle() 
        {
            double p = (SideA + SideB + SideC) / 2;
            double result = Math.Sqrt((p * (p - SideA) * (p - SideB) * (p - SideC)));

            return result;
        }
        public int Compare(Triangle x, Triangle y)
        {
            return x.CompareTo(y);
        }
        public int CompareTo(Triangle other)
        {
            return Area.CompareTo(other.Area);
        }
    }
}
