using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StaffManagement_WF_ADO.Utils
{
    public class Validator
    {
        public static bool IsPhone(string input)
        {
            return Regex.IsMatch(input, Constants.REGEX_PHONE);
        }

        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
