using System.Text.RegularExpressions;

public class PasswordValidationRule2
{
    public bool ValidatePasswordRule2(string password)
    {
        string pattern = ".*[A-Z].*";
        return Regex.IsMatch(password, pattern);
    }
}

public class PasswordValidationRule2Test
{
    private readonly PasswordValidationRule2 passwordValidationRule2;

    public PasswordValidationRule2Test()
    {
        passwordValidationRule2 = new PasswordValidationRule2();
    }

    public void ValidatePasswordRule2_PasswordContainsUppercaseLetter_ReturnsTrue()
    {
        string password = "Password1";
        bool isValid = passwordValidationRule2.ValidatePasswordRule2(password);
        Assert.IsTrue(isValid);
    }

    public void ValidatePasswordRule2_PasswordDoesNotContainUppercaseLetter_ReturnsFalse()
    {
        string password = "password1";
        bool isValid = passwordValidationRule2.ValidatePasswordRule2(password);
        Assert.IsFalse(isValid);
    }
}