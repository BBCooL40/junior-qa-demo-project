namespace JuniorQaDemo.Tests;
using NUnit.Framework;
public class UserValidatorTests
{
    [Test]
    public void ValidateRegistration_WithValidData_ReturnsValidMessage()
    {
        // Arrange
        string name = "Anton";
        string email = "anton.test@example.com";
        string password = "Test123!";
        string confirmPassword = "Test123!";
        string expected = "Registration data is valid.";

        // Act
        string actual = UserValidator.ValidateRegistration(name, email, password, confirmPassword);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateRegistration_WithEmptyRequiredFields_ReturnsRequiredFieldsMessage()
    {
        // Arrange
        string name = "";
        string email = "";
        string password = "";
        string confirmPassword = "";
        string expected = "All fields are required.";

        // Act
        string actual = UserValidator.ValidateRegistration(name, email, password, confirmPassword);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateRegistration_WithInvalidEmailFormat_ReturnsInvalidEmailMessage()
    {
        // Arrange
        string name = "Anton";
        string email = "anton.test";
        string password = "Test123!";
        string confirmPassword = "Test123!";
        string expected = "Invalid email format.";

        // Act
        string actual = UserValidator.ValidateRegistration(name, email, password, confirmPassword);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateRegistration_WithShortPassword_ReturnsPasswordLengthMessage()
    {
        // Arrange
        string name = "Anton";
        string email = "anton.test@example.com";
        string password = "123";
        string confirmPassword = "123";
        string expected = "Password must be at least 6 characters.";

        // Act
        string actual = UserValidator.ValidateRegistration(name, email, password, confirmPassword);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateRegistration_WithMismatchedPasswords_ReturnsPasswordsDoNotMatchMessage()
    {
        // Arrange
        string name = "Anton";
        string email = "anton.test@example.com";
        string password = "Test123!";
        string confirmPassword = "Test456!";
        string expected = "Passwords do not match.";

        // Act
        string actual = UserValidator.ValidateRegistration(name, email, password, confirmPassword);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateLogin_WithValidData_ReturnsValidMessage()
    {
        // Arrange
        string email = "anton.test@example.com";
        string password = "Test123!";
        string expected = "Login data is valid.";

        // Act
        string actual = UserValidator.ValidateLogin(email, password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateLogin_WithEmptyFields_ReturnsRequiredFieldsMessage()
    {
        // Arrange
        string email = "";
        string password = "";
        string expected = "Email and password are required.";

        // Act
        string actual = UserValidator.ValidateLogin(email, password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateLogin_WithInvalidEmailFormat_ReturnsInvalidEmailMessage()
    {
        // Arrange
        string email = "anton.test";
        string password = "Test123!";
        string expected = "Invalid email format.";

        // Act
        string actual = UserValidator.ValidateLogin(email, password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}