using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegixDemo
{
  public  class UserFirstName
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2}$";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);

        }
    }

   
}
