using System;

namespace Task_3
{
    public partial class Triangle
    {
        public static class Factory
        {
            public static Triangle Create(string name, double a, double b, double c)
            {
                try
                {
                    if (IsTriangleValid(a, b, c))
                    {
                        return new Triangle(name, a, b, c);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            }
            private static bool IsTriangleValid(double a, double b, double c)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
