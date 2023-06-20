using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    internal bool ValidateFirstName(string firstName)
    {
        throw new NotImplementedException();
    }
}

public class FirstNameValidationTest
{
    private readonly UserRegistration userRegistration;

    public FirstNameValidationTest()
    {
        userRegistration = new UserRegistration();
    }

    public void ValidateFirstName_ValidFirstName_ReturnsTrue()
    {
        string firstName = "John";
        bool isValid = userRegistration.ValidateFirstName(firstName);
        Assert.IsTrue(isValid);
    }

    public void ValidateFirstName_InvalidFirstName_ReturnsFalse()
    {
        string firstName = "jo";
        bool isValid = userRegistration.ValidateFirstName(firstName);
        Assert.IsFalse(isValid);
    }
}



public static class Assert
{
    public static void IsTrue(bool condition, string v)
    {
        if (!condition)
        {
            throw new Exception("Assertion failed: Expected true, but got false");
        }
    }

    public static void IsFalse(bool condition)
    {
        if (condition)
        {
            throw new Exception("Assertion failed: Expected false, but got true");
        }
    }

    internal static void IsTrue(bool isValid)
    {
        throw new NotImplementedException();
    }
}