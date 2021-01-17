using CleanArch.Domain.Core.Events;
using System;

namespace CleanArch.Domain.Core.Queries
{
    public abstract class Query<T> : Message<T>
    {
        public DateTime TimeStamp { get; protected set; }

        protected Query()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
