using System.Text.RegularExpressions;

public class EmailValidation
{
    public bool ValidateEmail(string email)
    {
        string pattern = "^[a-zA-Z0-9]+([.\\-_][a-zA-Z0-9]+)*@[a-zA-Z0-9]+\\.[a-zA-Z]{2,3}(\\.[a-zA-Z]{2})?$";
        return Regex.IsMatch(email, pattern);
    }
}

public class EmailValidationTest
{
    private readonly EmailValidation emailValidation;

    public EmailValidationTest()
    {
        emailValidation = new EmailValidation();
    }

    public void ValidateEmail_ValidEmail_ReturnsTrue()
    {
        string email = "abc.xyz@bl.co.in";
        bool isValid = emailValidation.ValidateEmail(email);
        Assert.IsTrue(isValid);
    }

    public void ValidateEmail_InvalidEmail_ReturnsFalse()
    {
        string email = "abc.xyz@bl";
        bool isValid = emailValidation.ValidateEmail(email);
        Assert.IsFalse(isValid);
    }

    internal void TestParameterizedEmailValidation()
    {
        throw new NotImplementedException();
    }
}