﻿using Macros.Domain.Common.Exceptions;

namespace Macros.Domain.Menu.Exceptions
{
    public class InvalidCategoryException : BaseDomainException
    {
        public InvalidCategoryException()
        {
        }

        public InvalidCategoryException(string error) => this.Error = error;
    }
}
