using System.Text.RegularExpressions;

public class PasswordValidationRule4
{
    public bool ValidatePasswordRule4(string password)
    {
        string pattern = "^(?=.*[!@#$%^&*]).*$";
        return Regex.IsMatch(password, pattern) && GetSpecialCharacterCount(password) == 1;
    }

    private int GetSpecialCharacterCount(string password)
    {
        int count = 0;
        foreach (char c in password)
        {
            if (IsSpecialCharacter(c))
            {
                count++;
            }
        }
        return count;
    }

    private bool IsSpecialCharacter(char c)
    {
        return "!@#$%^&*".Contains(c);
    }
}

public class PasswordValidationRule4Test
{
    private readonly PasswordValidationRule4 passwordValidationRule4;

    public PasswordValidationRule4Test()
    {
        passwordValidationRule4 = new PasswordValidationRule4();
    }

    public void ValidatePasswordRule4_PasswordHasExactlyOneSpecialCharacter_ReturnsTrue()
    {
        string password = "Password!";
        bool isValid = passwordValidationRule4.ValidatePasswordRule4(password);
        Assert.IsTrue(isValid);
    }

    public void ValidatePasswordRule4_PasswordDoesNotHaveExactlyOneSpecialCharacter_ReturnsFalse()
    {
        string password = "Password!!";
        bool isValid = passwordValidationRule4.ValidatePasswordRule4(password);
        Assert.IsFalse(isValid);
    }
}