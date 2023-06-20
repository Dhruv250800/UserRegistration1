using System;

class Program
{
    static void Main(string[] args)
    {
        // User registration data
        string firstName = "John";
        string lastName = "Doe";
        string email = "johndoe@example.com";
        string mobile = "91 9919819801";
        string password = "Passw0rd!";

        // UserValidation instance
        UserValidation userValidation = new UserValidation();

        // Validate first name (UC1)
        bool isFirstNameValid = userValidation.ValidateFirstName(firstName);
        Console.WriteLine($"First Name: {firstName} - Valid: {isFirstNameValid}");

        // Validate last name (UC2)
        bool isLastNameValid = userValidation.ValidateLastName(lastName);
        Console.WriteLine($"Last Name: {lastName} - Valid: {isLastNameValid}");

        // Validate email (UC3)
        bool isEmailValid = userValidation.ValidateEmail(email);
        Console.WriteLine($"Email: {email} - Valid: {isEmailValid}");

        // Validate mobile (UC4)
        bool isMobileValid = userValidation.ValidateMobile(mobile);
        Console.WriteLine($"Mobile: {mobile} - Valid: {isMobileValid}");

        // Validate password (UC5 to UC8)
        bool isPasswordValid = userValidation.ValidatePassword(password);
        Console.WriteLine($"Password: {password} - Valid: {isPasswordValid}");

        // Separate email samples validation (UC9)
        string[] emailSamples = { "abc.xyz@bl.co.in", "test@example.com", "invalid-email" };
        Console.WriteLine("Email Samples Validation:");
        foreach (var sample in emailSamples)
        {
            bool isValid = userValidation.ValidateEmail(sample);
            Console.WriteLine($"{sample} - Valid: {isValid}");
        }

        // JUnit Test for User Entry validation (UC10)
        EmailValidationTest userValidationTest = new EmailValidationTest();
        userValidationTest.Equals(userValidation);

        // JUnit Parameterized Test for Email Address (UC11)
        userValidationTest.TestParameterizedEmailValidation();

        try
        {
            // Custom Exception for Invalid User Details (UC12)
            userValidation.ValidateUserDetailsWithExceptions(firstName, lastName, email, mobile, password);
        }
        catch (InvalidUserDetailsException ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

        // Lambda Function to validate User Entry (UC13)
        bool isUserEntryValid = userValidation.ValidateUserEntryWithLambda(firstName, lastName, email, mobile, password);
        Console.WriteLine($"User Entry Valid: {isUserEntryValid}");

        Console.ReadLine();
    }
}