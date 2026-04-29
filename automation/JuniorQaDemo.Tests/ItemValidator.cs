namespace JuniorQaDemo.Tests;

public static class ItemValidator
{
    public static string ValidateItemTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return "Title is required.";
        }

        if (title.Length > 100)
        {
            return "Title cannot be longer than 100 characters.";
        }

        return "Item title is valid.";
    }

    public static string ValidateItemDescription(string description)
    {
        if (description != null && description.Length > 500)
        {
            return "Description cannot be longer than 500 characters.";
        }

        return "Item description is valid.";
    }
}