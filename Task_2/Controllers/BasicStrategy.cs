namespace Task_2.Controllers
{
    public class BasicStrategy : IInsertStrategy
    {
        public bool CanBeInserted(double a, double b, double c, double d)
        {
            return a >= c && b >= d ? true : false;
        }
    }
}
