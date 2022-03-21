using System;
using System.Runtime.Serialization;

namespace Ordering.Application.Exceptions
{
    [Serializable]
    internal class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}