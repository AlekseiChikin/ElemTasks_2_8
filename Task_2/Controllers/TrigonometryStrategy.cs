using System;

namespace Task_2.Controllers
{
    public class TrigonometryStrategy : IInsertStrategy
    {
        public bool CanBeInserted(double x, double y, double X, double Y)
        {
            const double eps = 1e-6;

            double d = 4 * y * y * (x * x + y * y - X * X);
            double q = 2 * (x * x + y * y);
            double alpha1 = d < 0 ? 0 : Math.Acos((2 * X * x + Math.Sqrt(d)) / q);
            double alpha2 = d < 0 ? 0 : Math.Acos((2 * X * x - Math.Sqrt(d)) / q);
            bool Check(double a)
            {
                return Math.Cos(a) > -eps && Math.Sin(a) > -eps &&
                    x * Math.Cos(a) + y * Math.Sin(a) < X + eps &&
                    x * Math.Sin(a) + y * Math.Cos(a) < Y + eps;
            }
            return Check(alpha1) || Check(alpha2);
        }
    }
}
