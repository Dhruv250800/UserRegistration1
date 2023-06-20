using System.Text.RegularExpressions;

public class PasswordValidationRule3
{
    public bool ValidatePasswordRule3(string password)
    {
        string pattern = ".*\\d.*";
        return Regex.IsMatch(password, pattern);
    }
}

public class PasswordValidationRule3Test
{
    private readonly PasswordValidationRule3 passwordValidationRule3;

    public PasswordValidationRule3Test()
    {
        passwordValidationRule3 = new PasswordValidationRule3();
    }

    public void ValidatePasswordRule3_PasswordContainsNumericDigit_ReturnsTrue()
    {
        string password = "Password1";
        bool isValid = passwordValidationRule3.ValidatePasswordRule3(password);
        Assert.IsTrue(isValid);
    }

    public void ValidatePasswordRule3_PasswordDoesNotContainNumericDigit_ReturnsFalse()
    {
        string password = "Password";
        bool isValid = passwordValidationRule3.ValidatePasswordRule3(password);
        Assert.IsFalse(isValid);
    }
}