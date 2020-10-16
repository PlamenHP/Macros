using System;
using FakeItEasy;
using FluentAssertions;
using Macros.Domain.Food.Exceptions;
using Xunit;

namespace Macros.Domain.Food.Models.Diet
{
    public class ConsumedFoodListSpec
    {
        [Fact]
        public void ConsumedFoodList_InvalidName_ThrowException()
        {
            // Act
            Action act = () => A.Dummy<ConsumedFoodList>();

            // Assert
            act.Should().Throw<InvalidConsumedFoodListException>($"Instantiating {nameof(ConsumedFoodList)} should thorow exception for invalid name.");
        }

        [Fact]
        public void ConsumedFoodList_ValidName_NotThrowException()
        {
            // Act
            Action act = () => A.Dummy<ConsumedFoodList>();

            // Assert
            act.Should().NotThrow<InvalidConsumedFoodListException>($"Instantiating {nameof(ConsumedFoodList)} should not thorow exception for valid name.");
        }

        [Fact]
        public void ConsumedFoodList_UpdateName_UpdatesConsumedFoodListName()
        {
            // Arrange
            var systemUnderTest = A.Dummy<ConsumedFoodList>();
            string newName = "My updated diet record name";

            // Act
            systemUnderTest.UpdateName(newName );


            // Assert
            systemUnderTest.Name.Should().Be(newName, $"Updaing {nameof(ConsumedFoodList)} 'Name' should update to the new name.");
        }
    }
}
