using NUnit.Framework;

using System;
using System.Numerics;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result,Is.Empty);
    }


    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] {
            "Rose"
        };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}Rose"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] {
            "Rosee",
            "*====",
            "-----"
        };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 5 letters:{Environment.NewLine}Rosee{Environment.NewLine}*===={Environment.NewLine}-----"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] {
            "rOse",
            "lilieS"
        };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}rOse{Environment.NewLine}Plants with 6 letters:{Environment.NewLine}lilieS"));
    }
}
