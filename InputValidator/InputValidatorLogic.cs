using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidatorForm
{
    public class InputValidatorLogic
    {
        public bool ValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                return true;
            return false;
        }

        public bool ValidPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"(\+[0-9]{2})[.\- ]?[0-9]{2}[.\- ]?[0-9]{3}[.\- ]?[0-9]{4}"))
                return true;
            return false;
        }

        public bool ValidName(string name)
        {
            if (Regex.IsMatch(name, @"^([A-Za-z]*\s*)+$"))
                return true;
            return false;
        }
    }
}
