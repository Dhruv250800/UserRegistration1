

public class EmailValidationTest1
{

    public void TestEmailValidation()
    {
        UserValidation userValidation = new UserValidation();

        string[] emailSamples = { "abc.xyz@bl.co.in", "test@example.com", "invalid-email" };

        foreach (var email in emailSamples)
        {
            bool isValid = userValidation.ValidateEmail(email);
            Assert.IsTrue(isValid, $"Email: {email} - Valid: {isValid}");
        }
    }
}