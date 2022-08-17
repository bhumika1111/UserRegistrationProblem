using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegixDemo
{
   public class PasswordRule3
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[0-9]{1}[A-Z a-z]{7}$";
        public bool ValidatePasswordThree(string Password)
        {
            return Regex.IsMatch(Password, REGEX_PASSWORD);

        }
    }
}
