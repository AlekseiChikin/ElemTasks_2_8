using System.Collections.Generic;

namespace Task_8_.Controllers
{
    public abstract class Sequence<T>
    {
        public abstract IEnumerable<T> GetSequence();
    }
}
