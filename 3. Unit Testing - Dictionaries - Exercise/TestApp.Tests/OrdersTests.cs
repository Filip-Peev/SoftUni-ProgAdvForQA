using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 1.99 3",
            "banana 3.75 1",
            "orange 1.98 1"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 2 3",
            "banana 4 1",
            "orange 2 1"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.00{Environment.NewLine}banana -> 4.00{Environment.NewLine}orange -> 2.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 2 2.5",
            "banana 2 1.2",
            "orange 1.98 1.6"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.00{Environment.NewLine}banana -> 2.40{Environment.NewLine}orange -> 3.17"));
    }
}