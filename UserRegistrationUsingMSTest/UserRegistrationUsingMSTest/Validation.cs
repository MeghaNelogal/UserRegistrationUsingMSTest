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

    }
}
