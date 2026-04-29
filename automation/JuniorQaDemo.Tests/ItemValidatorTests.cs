namespace JuniorQaDemo.Tests;
using NUnit.Framework;
public class ItemValidatorTests
{
    [Test]
    public void ValidateItemTitle_WithValidTitle_ReturnsValidMessage()
    {
        // Arrange
        string title = "Test task";
        string expected = "Item title is valid.";

        // Act
        string actual = ItemValidator.ValidateItemTitle(title);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateItemTitle_WithEmptyTitle_ReturnsTitleRequiredMessage()
    {
        // Arrange
        string title = "";
        string expected = "Title is required.";

        // Act
        string actual = ItemValidator.ValidateItemTitle(title);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateItemTitle_WithWhitespaceTitle_ReturnsTitleRequiredMessage()
    {
        // Arrange
        string title = "   ";
        string expected = "Title is required.";

        // Act
        string actual = ItemValidator.ValidateItemTitle(title);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateItemTitle_WithMoreThan100Characters_ReturnsTitleTooLongMessage()
    {
        // Arrange
        string title = new string('A', 101);
        string expected = "Title cannot be longer than 100 characters.";

        // Act
        string actual = ItemValidator.ValidateItemTitle(title);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateItemDescription_WithValidDescription_ReturnsValidMessage()
    {
        // Arrange
        string description = "Created by QA test";
        string expected = "Item description is valid.";

        // Act
        string actual = ItemValidator.ValidateItemDescription(description);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ValidateItemDescription_WithMoreThan500Characters_ReturnsDescriptionTooLongMessage()
    {
        // Arrange
        string description = new string('A', 501);
        string expected = "Description cannot be longer than 500 characters.";

        // Act
        string actual = ItemValidator.ValidateItemDescription(description);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}