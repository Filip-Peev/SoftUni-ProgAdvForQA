using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("ivan_ivanov@softuni.bg")]
    [TestCase("angel_ivanov@abv.bg")]
    [TestCase("angel+123@yahoo.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("ivan ivanov@softuni.bg")]
    [TestCase("ivan_ivanov softuni.bg")]
    [TestCase("ivan_ivanov@soft_uni.b")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}
