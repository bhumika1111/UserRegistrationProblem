using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegixDemo
{
    class MobileFormate
    {
        public static string REGEX_MOBILENUMBER = "^[91]{2}[\\s][6-9]{1}[0-9]{9}$";
        public bool ValidateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, REGEX_MOBILENUMBER);

        }
    }
}
