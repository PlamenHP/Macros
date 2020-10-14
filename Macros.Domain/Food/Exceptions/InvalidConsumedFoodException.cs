using System;
using System.Collections.Generic;
using System.Text;
using Macros.Domain.Exceptions;

namespace Macros.Domian.Food.Exceptions
{
    public class InvalidConsumedFoodException : BaseDomainException
    {
        public InvalidConsumedFoodException()
        {
        }

        public InvalidConsumedFoodException(string error) => this.Error = error;
    }
}
