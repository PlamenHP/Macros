﻿using Macros.Domain.Exceptions;

namespace Macros.Domian.Food.Exceptions
{
    public class InvalidFoodListException : BaseDomainException
    {
        public InvalidFoodListException()
        {
        }

        public InvalidFoodListException(string error) => this.Error = error;
    }
}