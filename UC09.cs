public class EmailValidationSamples
{
    public bool ValidateEmailSamples(List<string> emailSamples)
    {
        EmailValidation emailValidation = new EmailValidation();
        foreach (string email in emailSamples)
        {
            if (!emailValidation.ValidateEmail(email))
            {
                return false;
            }
        }
        return true;
    }
}

public class EmailValidationSamplesTest
{
    private readonly EmailValidationSamples emailValidationSamples;

    public EmailValidationSamplesTest()
    {
        emailValidationSamples = new EmailValidationSamples();
    }

    public void ValidateEmailSamples_AllValidEmailSamples_ReturnsTrue()
    {
        List<string> emailSamples = new List<string>
        {
            "abc.xyz@bl.co.in",
            "john.doe@example.com",
            "test123@test.co"
        };
        bool isValid = emailValidationSamples.ValidateEmailSamples(emailSamples);
        Assert.IsTrue(isValid);
    }

    public void ValidateEmailSamples_InvalidEmailSample_ReturnsFalse()
    {
        List<string> emailSamples = new List<string>
        {
            "abc.xyz@bl",
            "john.doe@example.com",
            "test123@test.co"
        };
        bool isValid = emailValidationSamples.ValidateEmailSamples(emailSamples);
        Assert.IsFalse(isValid);
    }
}