using System;
using System.Text.RegularExpressions;

public class UserValidation2
{
    // Validate first name using lambda function
    public bool ValidateFirstName1(string firstName)
    {
        // First name starts with a capital letter and has a minimum of 3 characters
        Func<string, bool> firstNameValidator = name => !string.IsNullOrEmpty(name) && char.IsUpper(name[0]) && name.Length >= 3;
        return firstNameValidator(firstName);
    }

    // Validate last name using lambda function
    public bool ValidateLastName1(string lastName)
    {
        // Last name starts with a capital letter and has a minimum of 3 characters
        Func<string, bool> lastNameValidator = name => !string.IsNullOrEmpty(name) && char.IsUpper(name[0]) && name.Length >= 3;
        return lastNameValidator(lastName);
    }

    // Validate email using lambda function
    public bool ValidateEmail1(string email)
    {
        // Email has 3 mandatory parts (abc, bl, co) and 2 optional parts (xyz, in)
        // with precise @ and . positions
        Func<string, bool> emailValidator = email =>
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string[] emailParts = email.Split('@');
            if (emailParts.Length != 2)
                return false;

            string[] domainParts = emailParts[1].Split('.');
            if (domainParts.Length < 2 || domainParts.Length > 3)
                return false;

            return true;
        };

        return emailValidator(email);
    }

    // Validate mobile using lambda function
    public bool ValidateMobile1(string mobile)
    {
        // Mobile format: Country code followed by a space and a 10-digit number
        Func<string, bool> mobileValidator = mobile => !string.IsNullOrEmpty(mobile) && mobile.Length == 13 && mobile.StartsWith("91 ");
        return mobileValidator(mobile);
    }

    // Validate password using lambda function
    public bool ValidatePassword1(string password)
    {
        // Password rules: Minimum 8 characters, at least 1 uppercase, 1 numeric digit, and 1 special character
        Func<string, bool> passwordValidator = password =>
        {
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
        };

        return passwordValidator(password);
    }
}