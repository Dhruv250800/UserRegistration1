public class InvalidUserDetailsException : Exception
{
    public InvalidUserDetailsException(string message) : base(message)
    {
    }
}

public class UserRegistration1
{
    public void RegisterUser(string firstName, string lastName, string email, string mobile, string password)
    {
        if (!IsValidFirstName(firstName))
        {
            throw new InvalidUserDetailsException("Invalid first name.");
        }

        if (!IsValidLastName(lastName))
        {
            throw new InvalidUserDetailsException("Invalid last name.");
        }

        if (!IsValidEmail(email))
        {
            throw new InvalidUserDetailsException("Invalid email.");
        }

        if (!IsValidMobile(mobile))
        {
            throw new InvalidUserDetailsException("Invalid mobile number.");
        }

        if (!IsValidPassword(password))
        {
            throw new InvalidUserDetailsException("Invalid password.");
        }

        // Perform user registration logic
        // ...
    }

    private bool IsValidEmail(string email)
    {
        throw new NotImplementedException();
    }

    private bool IsValidMobile(string mobile)
    {
        throw new NotImplementedException();
    }

    private bool IsValidLastName(string lastName)
    {
        throw new NotImplementedException();
    }

    private bool IsValidFirstName(string firstName)
    {
        throw new NotImplementedException();
    }

    private bool IsValidPassword(string password)
    {
        throw new NotImplementedException();
    }
}

