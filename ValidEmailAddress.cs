using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegixDemo
{
    class ValidEmailAddress
    {
        public static string REGEX_EMAIL = "^[a-z]{3}['@'][a-z]{5}['.'][a-z]{3}$";
        public bool ValidateEmailAdd(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);

        }
    }
}
