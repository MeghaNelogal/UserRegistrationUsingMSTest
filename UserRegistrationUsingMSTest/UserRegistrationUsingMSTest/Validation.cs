using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingMSTest
{
    public class Validation
    {
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public const string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_REGEX = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        public static string MOBILENUMBER_REGEX = "^[0-9]{1,3}[ ][6789][0-9]{9}$";
        public static string PASSWORD_REGEX = "^[A-Z a-z]{8,}$";
        public string ValidateFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRSTNAME_REGEX))
            {
                Console.WriteLine("First Name Matches");
            }
            else
            {
                Console.WriteLine("Verify First Name Again");
            }
            return firstname;
        }
        public string ValidateLastName(string lastname)
        {
            if (Regex.IsMatch(lastname, LAST_NAME_REGEX))
            {
                Console.WriteLine("Last Name Matches");
            }
            else
            {
                Console.WriteLine("Verify Last Name Again");
            }
            return lastname;
        }
        public string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEX))
            {
                Console.WriteLine("Email Matches");
            }
            else
            {
                Console.WriteLine("Verify Email Again");
            }
            return email;
        }
        public string ValidateMobileNumber(string mobilenumber)
        {
            if (Regex.IsMatch(mobilenumber, MOBILENUMBER_REGEX))
            {
                Console.WriteLine("Mobile Number Matches.");
            }
            else
            {
                Console.WriteLine("Verify Mobile Number Again.");
            }
            return mobilenumber;
        }
        public string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX))
            {
                Console.WriteLine("Password Matches");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
            return password;
        }
    }
}


    



