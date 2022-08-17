using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegixDemo
{
    class UserLastName
    {
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2}$";
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTNAME);

        }
    }
}

