using System;
using FluentAssertions;
using Macros.Domain.Menu.Exceptions;
using Xunit;

namespace Macros.Domain.Diet.Models
{
    public class NutrientSpec
    {
        [Fact]
        public void Nutrient_InvalidName_ThrowException()
        {
            // Act
            Action act = () => new Nutrient("",2, new DateTime(2020, 10, 10));

            // Assert
            act.Should().Throw<InvalidNutrientException>("Instantiating Nutrient should thorow exception for invalid name.");
        }

        [Fact]
        public void Nutrient_ValidName_NotThrowException()
        {
            // Act
            Action act = () => new Nutrient("Rice", 2, new DateTime(2020, 10, 10));

            // Assert
            act.Should().NotThrow<InvalidNutrientException>("Instantiating Nutrient should not thorow exception for valid name.");
        }
    }
}
