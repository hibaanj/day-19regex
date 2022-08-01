using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC6_pwdr2
{
    internal class Patterns
    {
        //atleast one uppercase
        public static string regexrule = "^[a-zA-Z0-9]{8}$";
        public bool Stringvalid(string password)
        {
            return Regex.IsMatch(password, regexrule);

        }

    }
}
