using System.Text.RegularExpressions;

namespace JuniorQaDemo.Tests;

public static class UserValidator
{
    public static string ValidateRegistration(string name, string email, string password, string confirmPassword)
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(confirmPassword))
        {
            return "All fields are required.";
        }

        if (!IsValidEmail(email.Trim()))
        {
            return "Invalid email format.";
        }

        if (password.Length < 6)
        {
            return "Password must be at least 6 characters.";
        }

        if (password != confirmPassword)
        {
            return "Passwords do not match.";
        }

        return "Registration data is valid.";
    }

    public static string ValidateLogin(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            return "Email and password are required.";
        }

        if (!IsValidEmail(email.Trim()))
        {
            return "Invalid email format.";
        }

        return "Login data is valid.";
    }

    private static bool IsValidEmail(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }
}