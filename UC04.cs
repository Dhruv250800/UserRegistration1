using System.Text.RegularExpressions;

public class MobileValidation
{
    public bool ValidateMobile(string mobile)
    {
        string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
        return Regex.IsMatch(mobile, pattern);
    }
}

public class MobileValidationTest
{
    private readonly MobileValidation mobileValidation;

    public MobileValidationTest()
    {
        mobileValidation = new MobileValidation();
    }

    public void ValidateMobile_ValidMobile_ReturnsTrue()
    {
        string mobile = "91 9919819801";
        bool isValid = mobileValidation.ValidateMobile(mobile);
        Assert.IsTrue(isValid);
    }

    public void ValidateMobile_InvalidMobile_ReturnsFalse()
    {
        string mobile = "919919819801";
        bool isValid = mobileValidation.ValidateMobile(mobile);
        Assert.IsFalse(isValid);
    }
}