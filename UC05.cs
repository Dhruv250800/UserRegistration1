using System.Text.RegularExpressions;

public class PasswordValidation
{
    public bool ValidatePassword(string password)
    {
        // Password rules:
        // Rule1 - Minimum 8 characters
        // Rule2 - Should have at least 1 uppercase letter
        // Rule3 - Should have at least 1 numeric digit
        // Rule4 - Should have exactly 1 special character

        string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$";
        return Regex.IsMatch(password, pattern);
    }
}

public class PasswordValidationTest
{
    private readonly PasswordValidation passwordValidation;

    public PasswordValidationTest()
    {
        passwordValidation = new PasswordValidation();
    }

    public void ValidatePassword_ValidPassword_ReturnsTrue()
    {
        string password = "Passw0rd!";
        bool isValid = passwordValidation.ValidatePassword(password);
        Assert.IsTrue(isValid);
    }

    public void ValidatePassword_InvalidPassword_ReturnsFalse()
    {
        string password = "password";
        bool isValid = passwordValidation.ValidatePassword(password);
        Assert.IsFalse(isValid);
    }
}