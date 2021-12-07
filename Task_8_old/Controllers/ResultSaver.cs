using Task_8_.Controllers;

namespace Task_8_old.Controllers
{
    class ResultSaver
    {
        private  RequestResolver resolver = new RequestResolver(new FibonacciNumbers());
        private  Result result = new Result();

        public void Add(int lenght)
        {
            if (!result.Lenght.ContainsKey(lenght))
            {
                result.Lenght.Add(lenght, resolver.Result(lenght));
            }
        }
        public void Add((int min, int max) range)
        {
            if (!result.Range.ContainsKey(range))
            {
                result.Range.Add(range, resolver.Result(range));
            }
        }
        public Result GetResult()
        {
            return result;
        }
    }
}
