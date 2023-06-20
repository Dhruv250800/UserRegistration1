using System.Text.RegularExpressions;

public class LastNameValidation
{
    public bool ValidateLastName(string lastName)
    {
        string pattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
        return Regex.IsMatch(lastName, pattern);
    }
}

public class LastNameValidationTest
{
    private readonly LastNameValidation lastNameValidation;

    public LastNameValidationTest()
    {
        lastNameValidation = new LastNameValidation();
    }

    public void ValidateLastName_ValidLastName_ReturnsTrue()
    {
        string lastName = "Doe";
        bool isValid = lastNameValidation.ValidateLastName(lastName);
        Assert.IsTrue(isValid);
    }

    public void ValidateLastName_InvalidLastName_ReturnsFalse()
    {
        string lastName = "do";
        bool isValid = lastNameValidation.ValidateLastName(lastName);
        Assert.IsFalse(isValid);
    }
}
