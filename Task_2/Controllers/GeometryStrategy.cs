namespace Task_2.Controllers
{
    public class GeometryStrategy : IInsertStrategy
    {
        public bool CanBeInserted(double A, double B, double C, double D)
        {
            //Здесь A,B - конверт, C,D - открытка.
            //Должно выполняться неравенство pi/2-BOD-COA>=DOC. Обе части неравенства лежат на отрезке [0..pi/2].
            //На этом отрезке sin возрастающая функция, поэтому мы можем взять от обеих частей sin.
            //После преобразований мы получим условия, которые мы и проверяем в последней строчке функции.

            if (A >= C && B >= D) return true;
            if (C * C + D * D > A * A + B * B) return false;
            if (A * A >= C * C + D * D) return B >= C;
            return (A * B > 2 * C * D) && ((C * C + D * D - B * B) * (C * C + D * D - A * A) <= A * A * B * B - 4 * A * B * C * D + 4 * C * C * D * D);
        }
    }
}
