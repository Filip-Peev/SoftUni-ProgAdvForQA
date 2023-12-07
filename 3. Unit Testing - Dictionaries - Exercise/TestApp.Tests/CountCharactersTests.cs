using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a", "bbb", "abc" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 2");
        sb.AppendLine("b -> 4");
        sb.AppendLine("c -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "!", "bb!b", "abc" };
        StringBuilder sb = new();
        sb.AppendLine("! -> 2");
        sb.AppendLine("b -> 4");
        sb.AppendLine("a -> 1");
        sb.AppendLine("c -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void Test_Count_WithUpperCaseAndNumberCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "!", "bb!b", "abc1A" };
        StringBuilder sb = new();
        sb.AppendLine("! -> 2");
        sb.AppendLine("b -> 4");
        sb.AppendLine("a -> 1");
        sb.AppendLine("c -> 1");
        sb.AppendLine("1 -> 1");
        sb.AppendLine("A -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}