using System;
using FluentAssertions;
using Macros.Domian.Food.Exceptions;
using Xunit;

namespace Macros.Domian.Food.Models.Diet
{
    public class ConsumedFoodSpec
    {
        [Fact]
        public void ConsumedFood_InvalidName_ThrowException()
        {
            // Act
            Action act = () => new ConsumedFood("");

            // Assert
            act.Should().Throw<InvalidConsumedFoodException>($"Instantiating {nameof(ConsumedFood)} should thorow exception for invalid name.");
        }

        [Fact]
        public void ConsumedFood_ValidName_NotThrowException()
        {
            // Act
            Action act = () => new ConsumedFood("My new Diet record");

            // Assert
            act.Should().NotThrow<InvalidConsumedFoodException>($"Instantiating {nameof(ConsumedFood)} should not thorow exception for valid name.");
        }

        [Fact]
        public void ConsumedFood_UpdateName_UpdatesConsumedFoodListName()
        {
            // Arrange
            var systemUnderTest = new ConsumedFood("My new Diet record");
            string newName = "My updated diet record name";

            // Act
            systemUnderTest.UpdateName(newName );


            // Assert
            systemUnderTest.Name.Should().Be(newName, $"Updaing {nameof(ConsumedFood)} 'Name' should update to the new name.");
        }
    }
}
