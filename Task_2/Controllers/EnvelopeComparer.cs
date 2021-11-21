using System.Collections.Generic;
using Task_2.Models;

namespace Task_2.Controllers
{
    class EnvelopeComparer : IComparer<Envelope>
    {
        public int Compare(Envelope firstEnvelope, Envelope secondEnvelope)
        {
            return firstEnvelope.CompareTo(secondEnvelope);
        }
    }
}
