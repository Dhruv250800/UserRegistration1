using System;

public class InvalidUserDetailsException1 : Exception
{
    public InvalidUserDetailsException1(string message) : base(message)
    {
    }
}

public class UserValidation
{
    // Validate first name
    public bool ValidateFirstName(string firstName)
    {
        // First name starts with a capital letter and has a minimum of 3 characters
        return !string.IsNullOrEmpty(firstName) && char.IsUpper(firstName[0]) && firstName.Length >= 3;
    }

    // Validate last name
    public bool ValidateLastName(string lastName)
    {
        // Last name starts with a capital letter and has a minimum of 3 characters
        return !string.IsNullOrEmpty(lastName) && char.IsUpper(lastName[0]) && lastName.Length >= 3;
    }

    // Validate email
    public bool ValidateEmail(string email)
    {
        // Email has 3 mandatory parts (abc, bl, co) and 2 optional parts (xyz, in)
        // with precise @ and . positions
        if (string.IsNullOrEmpty(email))
            return false;

        string[] emailParts = email.Split('@');
        if (emailParts.Length != 2)
            return false;

        string[] domainParts = emailParts[1].Split('.');
        if (domainParts.Length < 2 || domainParts.Length > 3)
            return false;

        return true;
    }

    // Validate mobile
    public bool ValidateMobile(string mobile)
    {
        // Mobile format: Country code followed by a space and a 10-digit number
        return !string.IsNullOrEmpty(mobile) && mobile.Length == 13 && mobile.StartsWith("91 ");
    }

    // Validate password
    public bool ValidatePassword(string password)
    {
        // Password rules: Minimum 8 characters, at least 1 uppercase, 1 numeric digit, and 1 special character
        if (string.IsNullOrEmpty(password) || password.Length < 8)
            return false;

        bool hasUpperCase = false;
        bool hasNumeric = false;
        bool hasSpecialChar = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                hasUpperCase = true;
            else if (char.IsDigit(c))
                hasNumeric = true;
            else if (!char.IsLetterOrDigit(c))
                hasSpecialChar = true;
        }

        return hasUpperCase && hasNumeric && hasSpecialChar;
    }

    // Validate user details with custom exceptions
    public void ValidateUserDetailsWithExceptions(string firstName, string lastName, string email, string mobile, string password)
    {
        if (!ValidateFirstName(firstName))
            throw new InvalidUserDetailsException("Invalid First Name");

        if (!ValidateLastName(lastName))
            throw new InvalidUserDetailsException("Invalid Last Name");

        if (!ValidateEmail(email))
            throw new InvalidUserDetailsException("Invalid Email");

        if (!ValidateMobile(mobile))
            throw new InvalidUserDetailsException("Invalid Mobile");

        if (!ValidatePassword(password))
            throw new InvalidUserDetailsException("Invalid Password");
    }

    internal bool ValidateUserEntryWithLambda(string firstName, string lastName, string email, string mobile, string password)
    {
        throw new NotImplementedException();
    }
}