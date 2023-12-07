using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        {
            // Arrange
            string[] input = Array.Empty<string>();

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.Empty);
        }
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new[] { "GOLd 8", "SILveR 30" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        {
            // Arrange
            string[] input = new[] { "GOLd 8", "SILveR 30",
                "cOPPER 100",
                "GolD 2" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo($"gold -> 10{Environment.NewLine}silver -> 30{Environment.NewLine}copper -> 100"));
        }
    }
}
