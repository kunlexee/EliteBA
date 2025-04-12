using System.Text.RegularExpressions;

namespace Models;

public class Customer
{
    private string _email;
    private string _phoneNumber;

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public required string Email
    {
        get => _email;
        set
        {
            var validatedEmail = Validators.ValidateEmail(value);
            if (validatedEmail == null)
            {
                return;
            }

            _email = validatedEmail;
        }
    }

    public required string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            var validatedPhone = Validators.ValidatePhoneNumber(value);
            if (validatedPhone == null)
            {
                return;
            }

            _phoneNumber = validatedPhone;
        }
    }

    public string? Address { get; set; }

    public int AccountId { get; set; }
}