using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC7_pwdr3
{
    internal class Patterns
    {
        //atleast one uppercase
        public static string regexrule = "^[a-zA-Z0-9]{7}([0-9]+)$";
        public bool Stringvalid(string password)
        {
            return Regex.IsMatch(password, regexrule);

        }

    }
}
