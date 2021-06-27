using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechStore.Utilities.Exceptions
{
    public class HutechStoreException : Exception
    {
        public HutechStoreException()
        {
        }

        public HutechStoreException(string message) : base(message)
        {
        }

        public HutechStoreException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
