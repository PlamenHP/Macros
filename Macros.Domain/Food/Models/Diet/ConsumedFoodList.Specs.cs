using System;
using FluentAssertions;
using Macros.Domian.Food.Exceptions;
using Xunit;

namespace Macros.Domian.Food.Models.Diet
{
    public class ConsumedFoodListSpec
    {
        [Fact]
        public void ConsumedFoodList_InvalidName_ThrowException()
        {
            // Act
            Action act = () => new ConsumedFoodList("");

            // Assert
            act.Should().Throw<InvalidConsumedFoodListException>($"Instantiating {nameof(ConsumedFoodList)} should thorow exception for invalid name.");
        }

        [Fact]
        public void ConsumedFoodList_ValidName_NotThrowException()
        {
            // Act
            Action act = () => new ConsumedFoodList("My new Diet record");

            // Assert
            act.Should().NotThrow<InvalidConsumedFoodListException>($"Instantiating {nameof(ConsumedFoodList)} should not thorow exception for valid name.");
        }

        [Fact]
        public void ConsumedFoodList_UpdateName_UpdatesConsumedFoodListName()
        {
            // Arrange
            var systemUnderTest = new ConsumedFoodList("My new Diet record");
            string newName = "My updated diet record name";

            // Act
            systemUnderTest.UpdateName(newName );


            // Assert
            systemUnderTest.Name.Should().Be(newName, $"Updaing {nameof(ConsumedFoodList)} 'Name' should update to the new name.");
        }
    }
}
