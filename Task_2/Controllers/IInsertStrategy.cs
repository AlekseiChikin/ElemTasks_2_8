namespace Task_2.Controllers
{
    public interface IInsertStrategy
    {
        bool CanBeInserted(double a, double b, double c, double d);
    }
}
