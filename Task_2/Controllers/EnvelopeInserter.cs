using System;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class EnvelopeInserter<S> 
        where S : IInsertStrategy, new()
    {
        private Envelope firstEnvelope;
        private Envelope secondEnvelope;
        public S InsertStrategy { get; init; }
        
        public EnvelopeInserter(Envelope firstEnvelope, Envelope secondEnvelope)
        {
            this.firstEnvelope = firstEnvelope;
            this.secondEnvelope = secondEnvelope;
            InsertStrategy = new S();
        }
        public bool Insertable()
        {
            bool isInsertable = InsertStrategy.CanBeInserted(firstEnvelope.SideA, firstEnvelope.SideB, secondEnvelope.SideA, secondEnvelope.SideB) ||
                                InsertStrategy.CanBeInserted(secondEnvelope.SideA, secondEnvelope.SideB, firstEnvelope.SideA, firstEnvelope.SideB);
            
            return isInsertable;
        }
        
    }
}